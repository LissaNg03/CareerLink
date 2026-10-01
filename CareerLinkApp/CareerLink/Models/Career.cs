using System.Collections.Generic;

namespace CareerLink.Models
{
    public class Career
    {
        public int CareerId { get; set; }
        public string Keyword { get; set; }
        public string CareerName { get; set; }
        public List<string> Subjects { get; set; } = new List<string>();
    }
}
