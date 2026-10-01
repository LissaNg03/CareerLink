using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CareerLink.Models;

namespace CareerLink.Repositories
{
    
    public class SubjectsRepository
    {
        private static Subject ReadSubject(SqlDataReader reader)
        {
            return new Subject
            {
                SubjectId = reader.GetInt32(0),
                SubjectName = reader.GetString(1),
                Category = reader.GetString(2),
                GradeRange = reader.GetString(3)
            };
        }

        public List<Subject> GetAllSubjects()
        {
            var subjects = new List<Subject>();

            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT SubjectId, SubjectName, Category, GradeRange FROM dbo.Subjects ORDER BY SubjectName";

                using (SqlCommand command = new SqlCommand(sql, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        subjects.Add(ReadSubject(reader));
                }
            }
            return subjects;
        }

        public Subject GetSubject(int subjectid)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT SubjectId, SubjectName, Category, GradeRange FROM dbo.Subjects WHERE SubjectId=@subjectid";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@subjectid", subjectid);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                            return ReadSubject(reader);
                    }
                }
            }
            return null;
        }

        public bool NameExists(string subjectName, int excludeSubjectId)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM dbo.Subjects WHERE SubjectName=@subjectName AND SubjectId<>@excludeId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@subjectName", subjectName);
                    command.Parameters.AddWithValue("@excludeId", excludeSubjectId);
                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        public int CreateSubject(Subject subject)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                string sql = "INSERT INTO dbo.Subjects (SubjectName, Category, GradeRange) " +
                    "OUTPUT INSERTED.SubjectId VALUES (@subjectName, @category, @gradeRange);";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@subjectName", subject.SubjectName);
                    command.Parameters.AddWithValue("@category", subject.Category);
                    command.Parameters.AddWithValue("@gradeRange", subject.GradeRange);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public void UpdateSubject(Subject subject)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                string sql = "UPDATE dbo.Subjects SET SubjectName=@subjectName, Category=@category, GradeRange=@gradeRange " +
                    "WHERE SubjectId=@subjectid;";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@subjectName", subject.SubjectName);
                    command.Parameters.AddWithValue("@category", subject.Category);
                    command.Parameters.AddWithValue("@gradeRange", subject.GradeRange);
                    command.Parameters.AddWithValue("@subjectid", subject.SubjectId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSubject(int subjectid)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM dbo.Subjects WHERE SubjectId=@subjectid;", connection))
                {
                    command.Parameters.AddWithValue("@subjectid", subjectid);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
