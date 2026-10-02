namespace CareerLink.Models
{
    public class StudentProfile
    {
        public int StudentProfileId { get; set; }

        public int UserId { get; set; }

        public int CourseId { get; set; }

        public int YearOfStudy { get; set; }

        // These come from joining with Courses
        public string CourseName { get; set; } = string.Empty;

        public string Institution { get; set; } = string.Empty;

        public string FieldName { get; set; } = string.Empty;
    }
}