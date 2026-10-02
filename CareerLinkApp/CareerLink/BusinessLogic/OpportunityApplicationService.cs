using CareerLink.Models;
using CareerLink.Repositories;
using System.Collections.Generic;

namespace CareerLink.BusinessLogic
{
    public class OpportunityApplicationService
    {
        private readonly OpportunityApplicationsRepository repository =
            new OpportunityApplicationsRepository();


        public void Apply(
            int userId,
            int opportunityId)
        {
            if (userId <= 0)
            {
                throw new BusinessRuleException(
                    "Invalid user.");
            }

            if (opportunityId <= 0)
            {
                throw new BusinessRuleException(
                    "Invalid opportunity.");
            }


            bool alreadyApplied =
                repository.HasApplied(
                    userId,
                    opportunityId);

            if (alreadyApplied)
            {
                throw new BusinessRuleException(
                    "You have already applied for this opportunity.");
            }


            OpportunityApplication application =
                new OpportunityApplication
                {
                    UserId = userId,

                    OpportunityId =
                        opportunityId,

                    Status = "Applied"
                };


            repository.Add(application);
        }

        public List<OpportunityApplication> GetApplicationsForUser(
    int userId)
        {
            if (userId <= 0)
            {
                return new List<OpportunityApplication>();
            }

            return repository.GetByUserId(userId);
        }


        public bool HasApplied(
            int userId,
            int opportunityId)
        {
            return repository.HasApplied(
                userId,
                opportunityId);
        }
    }
}