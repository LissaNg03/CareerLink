using CareerLink.Models;
using CareerLink.Repositories;
using System.Collections.Generic;

namespace CareerLink.BusinessLogic
{
    public class OpportunityService
    {
        private readonly OpportunitiesRepository repository =
            new OpportunitiesRepository();

        public List<Opportunity> GetAllActive()
        {
            return repository.GetAllActive();
        }


        public List<Opportunity> GetByType(
            string opportunityType)
        {
            if (string.IsNullOrWhiteSpace(opportunityType))
            {
                return new List<Opportunity>();
            }

            return repository.GetByType(opportunityType);
        }


        public List<Opportunity> GetRecommendedForCourse(
            int courseId)
        {
            if (courseId <= 0)
            {
                return new List<Opportunity>();
            }

            return repository.GetRecommendedForCourse(courseId);
        }
    }
}