using CareerLink.Data;
using CareerLink.Models;
using Microsoft.Data.SqlClient;

namespace CareerLink.Repositories
{
    public class StudentProfilesRepository
    {
        public StudentProfile? GetByUserId(int userId)
        {
            using (SqlConnection connection = Db.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT
                        sp.StudentProfileId,
                        sp.UserId,
                        sp.CourseId,
                        sp.YearOfStudy,
                        c.CourseName,
                        c.Institution,
                        f.FieldName
                    FROM StudentProfiles sp
                    INNER JOIN Courses c
                        ON sp.CourseId = c.CourseId
                    INNER JOIN Fields f
                        ON c.FieldId = f.FieldId
                    WHERE sp.UserId = @UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new StudentProfile
                            {
                                StudentProfileId =
                                    reader.GetInt32(
                                        reader.GetOrdinal("StudentProfileId")),

                                UserId =
                                    reader.GetInt32(
                                        reader.GetOrdinal("UserId")),

                                CourseId =
                                    reader.GetInt32(
                                        reader.GetOrdinal("CourseId")),

                                YearOfStudy =
                                    reader.GetInt32(
                                        reader.GetOrdinal("YearOfStudy")),

                                CourseName =
                                    reader.GetString(
                                        reader.GetOrdinal("CourseName")),

                                Institution =
                                    reader.GetString(
                                        reader.GetOrdinal("Institution")),

                                FieldName =
                                    reader.GetString(
                                        reader.GetOrdinal("FieldName"))
                            };
                        }
                    }
                }
            }

            return null;
        }

        public void Add(StudentProfile profile)
        {
            using (SqlConnection connection = Db.GetConnection())
            {
                connection.Open();

                string query = @"
                    INSERT INTO StudentProfiles
                        (UserId, CourseId, YearOfStudy)
                    VALUES
                        (@UserId, @CourseId, @YearOfStudy)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@UserId", profile.UserId);

                    command.Parameters.AddWithValue(
                        "@CourseId", profile.CourseId);

                    command.Parameters.AddWithValue(
                        "@YearOfStudy", profile.YearOfStudy);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(StudentProfile profile)
        {
            using (SqlConnection connection = Db.GetConnection())
            {
                connection.Open();

                string query = @"
                    UPDATE StudentProfiles
                    SET
                        CourseId = @CourseId,
                        YearOfStudy = @YearOfStudy
                    WHERE UserId = @UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@CourseId", profile.CourseId);

                    command.Parameters.AddWithValue(
                        "@YearOfStudy", profile.YearOfStudy);

                    command.Parameters.AddWithValue(
                        "@UserId", profile.UserId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}