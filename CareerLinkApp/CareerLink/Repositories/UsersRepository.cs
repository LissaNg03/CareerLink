using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CareerLink.Models;

namespace CareerLink.Repositories
{
    
    public class UsersRepository
    {
        private const string Columns =
            "UserId, FirstName, Surname, Email, UserType, PasswordHash, Question1, Answer1Hash, Question2, Answer2Hash";

        private static User ReadUser(SqlDataReader reader)
        {
            return new User
            {
                UserId = reader.GetInt32(0),
                FirstName = reader.GetString(1),
                Surname = reader.GetString(2),
                Email = reader.GetString(3),
                UserType = reader.GetString(4),
                PasswordHash = reader.GetString(5),
                Question1 = reader.IsDBNull(6) ? null : reader.GetString(6),
                Answer1Hash = reader.IsDBNull(7) ? null : reader.GetString(7),
                Question2 = reader.IsDBNull(8) ? null : reader.GetString(8),
                Answer2Hash = reader.IsDBNull(9) ? null : reader.GetString(9)
            };
        }

        
        public List<User> GetAllUsers()
        {
            var users = new List<User>();

            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT " + Columns + " FROM dbo.Users ORDER BY Surname, FirstName";

                using (SqlCommand command = new SqlCommand(sql, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        users.Add(ReadUser(reader));
                }
            }
            return users;
        }

        public User GetUser(int userid)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT " + Columns + " FROM dbo.Users WHERE UserId=@userid";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@userid", userid);   
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                            return ReadUser(reader);
                    }
                }
            }
            return null;
        }

        public User GetUserByEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT " + Columns + " FROM dbo.Users WHERE Email=@email";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                            return ReadUser(reader);
                    }
                }
            }
            return null;
        }

        public int CountUsers()
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM dbo.Users", connection))
                    return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        
        public bool EmailExists(string email, int excludeUserId)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM dbo.Users WHERE Email=@email AND UserId<>@excludeUserId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@excludeUserId", excludeUserId);
                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        
        public int CreateUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                string sql = "INSERT INTO dbo.Users " +
                    "(FirstName, Surname, Email, PasswordHash, UserType, Question1, Answer1Hash, Question2, Answer2Hash) " +
                    "OUTPUT INSERTED.UserId " +
                    "VALUES (@firstName, @surname, @email, @passwordHash, @userType, @question1, @answer1Hash, @question2, @answer2Hash);";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@firstName", user.FirstName);
                    command.Parameters.AddWithValue("@surname", user.Surname);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@passwordHash", user.PasswordHash);
                    command.Parameters.AddWithValue("@userType", user.UserType);
                    command.Parameters.AddWithValue("@question1", Db.OrNull(user.Question1));
                    command.Parameters.AddWithValue("@answer1Hash", Db.OrNull(user.Answer1Hash));
                    command.Parameters.AddWithValue("@question2", Db.OrNull(user.Question2));
                    command.Parameters.AddWithValue("@answer2Hash", Db.OrNull(user.Answer2Hash));
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        
        public void UpdateUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                string sql = "UPDATE dbo.Users " +
                    "SET FirstName=@firstName, Surname=@surname, Email=@email, UserType=@userType " +
                    "WHERE UserId=@userid;";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@firstName", user.FirstName);
                    command.Parameters.AddWithValue("@surname", user.Surname);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@userType", user.UserType);
                    command.Parameters.AddWithValue("@userid", user.UserId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdatePasswordHash(int userid, string passwordHash)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                string sql = "UPDATE dbo.Users SET PasswordHash=@passwordHash WHERE UserId=@userid;";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@passwordHash", passwordHash);
                    command.Parameters.AddWithValue("@userid", userid);
                    command.ExecuteNonQuery();
                }
            }
        }

        
        public void DeleteUser(int userid)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM dbo.Users WHERE UserId=@userid;", connection))
                {
                    command.Parameters.AddWithValue("@userid", userid);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
