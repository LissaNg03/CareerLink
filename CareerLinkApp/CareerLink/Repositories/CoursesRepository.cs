using CareerLink.Data;
using CareerLink.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace CareerLink.Repositories
{
    public class CoursesRepository
    {
        public List<Course> GetAll()
        {
            List<Course> courses = new List<Course>();

            using (SqlConnection connection = Db.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT
                        c.CourseId,
                        c.CourseName,
                        c.Institution,
                        c.FieldId,
                        f.FieldName
                    FROM Courses c
                    INNER JOIN Fields f
                        ON c.FieldId = f.FieldId
                    ORDER BY c.CourseName";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Course course = new Course
                        {
                            CourseId = reader.GetInt32(
                                reader.GetOrdinal("CourseId")),

                            CourseName = reader.GetString(
                                reader.GetOrdinal("CourseName")),

                            Institution = reader.GetString(
                                reader.GetOrdinal("Institution")),

                            FieldId = reader.GetInt32(
                                reader.GetOrdinal("FieldId")),

                            FieldName = reader.GetString(
                                reader.GetOrdinal("FieldName"))
                        };

                        courses.Add(course);
                    }
                }
            }

            return courses;
        }
    }
}