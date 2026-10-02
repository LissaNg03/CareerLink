using CareerLink.Models;
using CareerLink.Repositories;

namespace CareerLink.BusinessLogic
{
    public class StudentProfileService
    {
        private readonly StudentProfilesRepository repository =
            new StudentProfilesRepository();

        public StudentProfile? GetProfile(int userId)
        {
            return repository.GetByUserId(userId);
        }

        public void SaveProfile(
            int userId,
            int courseId,
            int yearOfStudy)
        {
            if (courseId <= 0)
            {
                throw new BusinessRuleException(
                    "Please select your course.");
            }

            if (yearOfStudy < 1 || yearOfStudy > 10)
            {
                throw new BusinessRuleException(
                    "Please select a valid year of study.");
            }

            StudentProfile? existing =
                repository.GetByUserId(userId);

            StudentProfile profile = new StudentProfile
            {
                UserId = userId,
                CourseId = courseId,
                YearOfStudy = yearOfStudy
            };

            if (existing == null)
            {
                repository.Add(profile);
            }
            else
            {
                repository.Update(profile);
            }
        }
    }
}