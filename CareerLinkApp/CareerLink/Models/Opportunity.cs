using System;

namespace CareerLink.Models
{
    public class Opportunity
    {
        public int OpportunityId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Company { get; set; } = string.Empty;

        public string OpportunityType { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? Requirements { get; set; }

        public string? Location { get; set; }

        public DateTime? ClosingDate { get; set; }

        public string? ApplicationURL { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}