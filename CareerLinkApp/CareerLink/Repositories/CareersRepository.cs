using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using CareerLink.Models;
using CareerLink.Data;

namespace CareerLink.Repositories
{
    
    public class CareersRepository
    {
      
        public List<Career> GetAllCareers()
        {
            return ReadCareers("", null, null);
        }

        public Career GetCareer(int careerid)
        {
            var list = ReadCareers("WHERE CareerId=@id", careerid, null);
            return list.Count > 0 ? list[0] : null;
        }

        
        public Career FindCareerByText(string typedText)
        {
            var list = ReadCareers("WHERE @text LIKE '%' + Keyword + '%'", null, typedText);
            return list.OrderByDescending(c => c.Keyword.Length).FirstOrDefault();
        }

        private List<Career> ReadCareers(string whereClause, int? id, string text)
        {
            var careers = new List<Career>();

            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();

                string sql = "SELECT CareerId, Keyword, CareerName FROM dbo.Careers " +
                             whereClause + " ORDER BY CareerName";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (id.HasValue)
                        command.Parameters.AddWithValue("@id", id.Value);
                    if (text != null)
                        command.Parameters.AddWithValue("@text", text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            careers.Add(new Career
                            {
                                CareerId = reader.GetInt32(0),
                                Keyword = reader.GetString(1),
                                CareerName = reader.GetString(2)
                            });
                        }
                    }
                }

                if (careers.Count > 0)
                {
                    var byId = careers.ToDictionary(c => c.CareerId);

                    using (SqlCommand command = new SqlCommand(
                        "SELECT CareerId, SubjectName FROM dbo.CareerSubjects", connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Career owner;
                            if (byId.TryGetValue(reader.GetInt32(0), out owner))
                                owner.Subjects.Add(reader.GetString(1));
                        }
                    }
                }
            }
            return careers;
        }

        public bool KeywordExists(string keyword, int excludeCareerId)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM dbo.Careers WHERE Keyword=@keyword AND CareerId<>@excludeId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@keyword", keyword);
                    command.Parameters.AddWithValue("@excludeId", excludeCareerId);
                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        
        public int CreateCareer(Career career)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    int newId;
                    string sql = "INSERT INTO dbo.Careers (Keyword, CareerName) " +
                                 "OUTPUT INSERTED.CareerId VALUES (@keyword, @careerName);";

                    using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@keyword", career.Keyword);
                        command.Parameters.AddWithValue("@careerName", career.CareerName);
                        newId = Convert.ToInt32(command.ExecuteScalar());
                    }

                    InsertSubjects(connection, transaction, newId, career.Subjects);
                    transaction.Commit();
                    return newId;
                }
            }
        }

       
        public void UpdateCareer(Career career)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    string sql = "UPDATE dbo.Careers SET Keyword=@keyword, CareerName=@careerName " +
                                 "WHERE CareerId=@careerid;";

                    using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@keyword", career.Keyword);
                        command.Parameters.AddWithValue("@careerName", career.CareerName);
                        command.Parameters.AddWithValue("@careerid", career.CareerId);
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(
                        "DELETE FROM dbo.CareerSubjects WHERE CareerId=@careerid;", connection, transaction))
                    {
                        command.Parameters.AddWithValue("@careerid", career.CareerId);
                        command.ExecuteNonQuery();
                    }

                    InsertSubjects(connection, transaction, career.CareerId, career.Subjects);
                    transaction.Commit();
                }
            }
        }

        private static void InsertSubjects(SqlConnection connection, SqlTransaction transaction,
                                           int careerid, List<string> subjects)
        {
            foreach (string subject in subjects)
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO dbo.CareerSubjects (CareerId, SubjectName) VALUES (@careerid, @subjectName);",
                    connection, transaction))
                {
                    command.Parameters.AddWithValue("@careerid", careerid);
                    command.Parameters.AddWithValue("@subjectName", subject);
                    command.ExecuteNonQuery();
                }
            }
        }

       
        public void DeleteCareer(int careerid)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM dbo.Careers WHERE CareerId=@careerid;", connection))
                {
                    command.Parameters.AddWithValue("@careerid", careerid);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
