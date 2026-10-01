using System;
using System.Collections.Generic;
using System.Net.Mail;
using CareerLink.Models;
using CareerLink.Repositories;

namespace CareerLink.BusinessLogic
{
    
    public class UserService
    {
        private const int MaxResetAttempts = 3;
        private const string LockedMessage =
            "Too many wrong attempts. Please ask an administrator to reset your password.";

        
        private static readonly Dictionary<string, int> failedAttempts =
            new Dictionary<string, int>();

        private readonly UsersRepository repo = new UsersRepository();

        private static string NormalizeAnswer(string answer)
        {
            
            return string.Join(" ", (answer ?? "").Trim().ToLowerInvariant()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        private static void ValidateEmail(string email)
        {
            try
            {
                if (new MailAddress(email).Address == email) return;
            }
            catch (FormatException) { }

            throw new BusinessRuleException("Please enter a valid email address.");
        }

        private static void ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 6)
                throw new BusinessRuleException("Password must be at least 6 characters.");
        }

        public bool IsFirstUser()
        {
            return repo.CountUsers() == 0;
        }

       
        public List<User> GetAllUsers()
        {
            return repo.GetAllUsers();
        }

        public User GetUser(int userid)
        {
            return repo.GetUser(userid);
        }

        public User Login(string email, string password)
        {
            email = (email ?? "").Trim();
            if (email == "" || string.IsNullOrEmpty(password))
                throw new BusinessRuleException("Please enter your email and password.");

            User user = repo.GetUserByEmail(email);

            if (user == null || !PasswordHelper.Verify(password, user.PasswordHash))
                throw new BusinessRuleException("Incorrect email or password.");

            return user;
        }

    
        public User Register(string firstName, string surname, string email, string password,
                             string userType,
                             string question1, string answer1,
                             string question2, string answer2)
        {
            firstName = (firstName ?? "").Trim();
            surname = (surname ?? "").Trim();
            email = (email ?? "").Trim();

            if (firstName == "" || surname == "" || email == "" || string.IsNullOrEmpty(password))
                throw new BusinessRuleException("Please fill in all the fields.");

            ValidateEmail(email);
            ValidatePassword(password);

           
            if (IsFirstUser())
                userType = UserTypes.Admin;
            else if (Array.IndexOf(UserTypes.SignUp, userType) < 0)  
                throw new BusinessRuleException("Please choose a user type.");

            if (string.IsNullOrEmpty(question1) || string.IsNullOrEmpty(question2))
                throw new BusinessRuleException("Please choose two security questions.");
            if (question1 == question2)
                throw new BusinessRuleException("Please choose two different security questions.");
            if (NormalizeAnswer(answer1) == "" || NormalizeAnswer(answer2) == "")
                throw new BusinessRuleException("Please answer both security questions.");

            
            if (repo.EmailExists(email, 0))
                throw new BusinessRuleException("An account with this email already exists.");

            var user = new User
            {
                FirstName = firstName,
                Surname = surname,
                Email = email,
                UserType = userType,
                PasswordHash = PasswordHelper.Hash(password),
                Question1 = question1,
                Answer1Hash = PasswordHelper.Hash(NormalizeAnswer(answer1)),
                Question2 = question2,
                Answer2Hash = PasswordHelper.Hash(NormalizeAnswer(answer2))
            };

            user.UserId = repo.CreateUser(user);
            return user;
        }

      
        public void UpdateUser(User user, int actingUserId, string newPassword = null)
        {
            user.FirstName = (user.FirstName ?? "").Trim();
            user.Surname = (user.Surname ?? "").Trim();
            user.Email = (user.Email ?? "").Trim();

            if (user.FirstName == "" || user.Surname == "" || user.Email == "")
                throw new BusinessRuleException("Please fill in all the fields.");

            ValidateEmail(user.Email);

            if (Array.IndexOf(UserTypes.All, user.UserType) < 0)
                throw new BusinessRuleException("Please choose a user type.");

            
            if (user.UserId == actingUserId && user.UserType != UserTypes.Admin)
                throw new BusinessRuleException("You can't remove your own Admin rights.");

            if (repo.EmailExists(user.Email, user.UserId))
                throw new BusinessRuleException("That email is already used by another account.");

            bool changePassword = !string.IsNullOrEmpty(newPassword);
            if (changePassword)
                ValidatePassword(newPassword);       

            repo.UpdateUser(user);

            if (changePassword)
                repo.UpdatePasswordHash(user.UserId, PasswordHelper.Hash(newPassword));
        }


        public void DeleteUser(int userid, int actingUserId)
        {
            
            if (userid == actingUserId)
                throw new BusinessRuleException("You can't delete the account you are logged in with.");

            repo.DeleteUser(userid);
        }

        
        public (string question1, string question2)? GetSecurityQuestions(string email)
        {
            User user = repo.GetUserByEmail((email ?? "").Trim());

            if (user == null || user.Question1 == null || user.Answer1Hash == null ||
                user.Question2 == null || user.Answer2Hash == null)
                return null;

            return (user.Question1, user.Question2);
        }

        public bool IsLockedOut(string email)
        {
            int n;
            return failedAttempts.TryGetValue((email ?? "").Trim().ToLowerInvariant(), out n)
                   && n >= MaxResetAttempts;
        }

        
        public void ResetPasswordWithAnswers(string email, string answer1, string answer2, string newPassword)
        {
            email = (email ?? "").Trim();
            string key = email.ToLowerInvariant();

            if (IsLockedOut(email))
                throw new BusinessRuleException(LockedMessage);

            if (NormalizeAnswer(answer1) == "" || NormalizeAnswer(answer2) == "")
                throw new BusinessRuleException("Please answer both questions.");

            ValidatePassword(newPassword);

            User user = repo.GetUserByEmail(email);

            bool correct = user != null
                && user.Answer1Hash != null && user.Answer2Hash != null
                && PasswordHelper.Verify(NormalizeAnswer(answer1), user.Answer1Hash)
                && PasswordHelper.Verify(NormalizeAnswer(answer2), user.Answer2Hash);

            if (!correct)
            {
                int n;
                failedAttempts.TryGetValue(key, out n);
                n++;
                failedAttempts[key] = n;

                int left = MaxResetAttempts - n;
                if (left <= 0)
                    throw new BusinessRuleException(LockedMessage);

                throw new BusinessRuleException("One or more answers are incorrect. Attempts left: " + left);
            }

            failedAttempts.Remove(key);
            repo.UpdatePasswordHash(user.UserId, PasswordHelper.Hash(newPassword));
        }
    }
}
