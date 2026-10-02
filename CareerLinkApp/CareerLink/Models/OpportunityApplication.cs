using System;

namespace CareerLink.Models
{
    public class OpportunityApplication
    {
        public int ApplicationId { get; set; }

        public int UserId { get; set; }

        public int OpportunityId { get; set; }

        public DateTime ApplicationDate { get; set; }

        public string Status { get; set; } = "Applied";

        // Opportunity details from JOIN
        public string OpportunityTitle { get; set; } = string.Empty;

        public string Company { get; set; } = string.Empty;

        public string OpportunityType { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public DateTime? ClosingDate { get; set; }
    }
}