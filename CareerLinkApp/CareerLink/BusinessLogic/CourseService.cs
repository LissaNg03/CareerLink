using CareerLink.Models;
using CareerLink.Repositories;
using System.Collections.Generic;

namespace CareerLink.BusinessLogic
{
    public class CourseService
    {
        private readonly CoursesRepository coursesRepository =
            new CoursesRepository();

        public List<Course> GetAllCourses()
        {
            return coursesRepository.GetAll();
        }
    }
}