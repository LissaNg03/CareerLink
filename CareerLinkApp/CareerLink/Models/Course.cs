namespace CareerLink.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; } = string.Empty;

        public string Institution { get; set; } = string.Empty;

        public int FieldId { get; set; }

        // Used when we JOIN Courses with Fields
        public string FieldName { get; set; } = string.Empty;

        // This controls what is displayed inside a ComboBox
        public override string ToString()
        {
            return $"{CourseName} - {Institution}";
        }
    }
}