namespace CareerLink.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }

       
        public string PasswordHash { get; set; }
        public string Question1 { get; set; }
        public string Answer1Hash { get; set; }
        public string Question2 { get; set; }
        public string Answer2Hash { get; set; }
    }

    public static class UserTypes
    {
        public const string Learner = "High School Learner (Grade 9-11)";
        public const string Matriculant = "Matriculant (Grade 12)";
        public const string Undergraduate = "Undergraduate";
        public const string Postgraduate = "Postgraduate";
        public const string Admin = "Admin";

        
        public static readonly string[] SignUp =
            { Learner, Matriculant, Undergraduate, Postgraduate };

       
        public static readonly string[] All =
            { Learner, Matriculant, Undergraduate, Postgraduate, Admin };
    }

    public static class SecurityQuestions
    {
        public static readonly string[] All =
        {
            "What was the name of your first pet?",
            "What is your mother's maiden name?",
            "What primary school did you attend?",
            "In which town or city were you born?",
            "What was your childhood nickname?",
            "What is the name of your best childhood friend?",
            "What is the surname of your favourite teacher?",
            "What was the first car or bakkie your family owned?",
            "What is your favourite food?"
        };
    }
}
