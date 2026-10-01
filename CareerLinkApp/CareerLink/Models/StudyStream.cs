using System.Collections.Generic;

namespace CareerLink.Models
{
    public class StreamRequirement
    {
       
        public string SubjectName { get; set; }
        public int MinPercent { get; set; }
    }

    public class StudyStream
    {
        public int StreamId { get; set; }
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public string StreamName { get; set; }
        public List<StreamRequirement> Requirements { get; set; } = new List<StreamRequirement>();
    }
}
