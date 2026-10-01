using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using CareerLink.Models;

namespace CareerLink.Repositories
{
    
    public class StreamsRepository
    {
        
        public List<StudyStream> GetAllStreams()
        {
            return ReadStreams("", null);
        }

        public List<StudyStream> GetStreamsForField(int fieldid)
        {
            return ReadStreams("WHERE s.FieldId=@id", fieldid);
        }

        public StudyStream GetStream(int streamid)
        {
            var list = ReadStreams("WHERE s.StreamId=@id", streamid);
            return list.Count > 0 ? list[0] : null;
        }

        private List<StudyStream> ReadStreams(string whereClause, int? id)
        {
            var streams = new List<StudyStream>();

            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();

                string sql = "SELECT s.StreamId, s.FieldId, f.FieldName, s.StreamName " +
                             "FROM dbo.Streams s JOIN dbo.Fields f ON f.FieldId = s.FieldId " +
                             whereClause + " ORDER BY f.FieldName, s.StreamName";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (id.HasValue)
                        command.Parameters.AddWithValue("@id", id.Value);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            streams.Add(new StudyStream
                            {
                                StreamId = reader.GetInt32(0),
                                FieldId = reader.GetInt32(1),
                                FieldName = reader.GetString(2),
                                StreamName = reader.GetString(3)
                            });
                        }
                    }
                }

                
                if (streams.Count > 0)
                {
                    var byId = streams.ToDictionary(s => s.StreamId);

                    string reqSql = "SELECT StreamId, SubjectName, MinPercent FROM dbo.StreamRequirements " +
                                    "ORDER BY SubjectName";

                    using (SqlCommand command = new SqlCommand(reqSql, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StudyStream owner;
                            if (byId.TryGetValue(reader.GetInt32(0), out owner))
                            {
                                owner.Requirements.Add(new StreamRequirement
                                {
                                    SubjectName = reader.GetString(1),
                                    MinPercent = reader.GetInt32(2)
                                });
                            }
                        }
                    }
                }
            }
            return streams;
        }

        public bool StreamExists(int fieldid, string streamName, int excludeStreamId)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM dbo.Streams " +
                             "WHERE FieldId=@fieldid AND StreamName=@streamName AND StreamId<>@excludeId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@fieldid", fieldid);
                    command.Parameters.AddWithValue("@streamName", streamName);
                    command.Parameters.AddWithValue("@excludeId", excludeStreamId);
                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        
        
        public int CreateStream(StudyStream stream)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    int newId;
                    string sql = "INSERT INTO dbo.Streams (FieldId, StreamName) " +
                                 "OUTPUT INSERTED.StreamId VALUES (@fieldid, @streamName);";

                    using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@fieldid", stream.FieldId);
                        command.Parameters.AddWithValue("@streamName", stream.StreamName);
                        newId = Convert.ToInt32(command.ExecuteScalar());
                    }

                    InsertRequirements(connection, transaction, newId, stream.Requirements);
                    transaction.Commit();
                    return newId;
                }
            }
        }

        
        public void UpdateStream(StudyStream stream)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    string sql = "UPDATE dbo.Streams SET FieldId=@fieldid, StreamName=@streamName " +
                                 "WHERE StreamId=@streamid;";

                    using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@fieldid", stream.FieldId);
                        command.Parameters.AddWithValue("@streamName", stream.StreamName);
                        command.Parameters.AddWithValue("@streamid", stream.StreamId);
                        command.ExecuteNonQuery();
                    }

                    
                    using (SqlCommand command = new SqlCommand(
                        "DELETE FROM dbo.StreamRequirements WHERE StreamId=@streamid;", connection, transaction))
                    {
                        command.Parameters.AddWithValue("@streamid", stream.StreamId);
                        command.ExecuteNonQuery();
                    }

                    InsertRequirements(connection, transaction, stream.StreamId, stream.Requirements);
                    transaction.Commit();
                }
            }
        }

        private static void InsertRequirements(SqlConnection connection, SqlTransaction transaction,
                                               int streamid, List<StreamRequirement> requirements)
        {
            foreach (StreamRequirement req in requirements)
            {
                string sql = "INSERT INTO dbo.StreamRequirements (StreamId, SubjectName, MinPercent) " +
                             "VALUES (@streamid, @subjectName, @minPercent);";

                using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                {
                    command.Parameters.AddWithValue("@streamid", streamid);
                    command.Parameters.AddWithValue("@subjectName", req.SubjectName);
                    command.Parameters.AddWithValue("@minPercent", req.MinPercent);
                    command.ExecuteNonQuery();
                }
            }
        }

        
        public void DeleteStream(int streamid)
        {
            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM dbo.Streams WHERE StreamId=@streamid;", connection))
                {
                    command.Parameters.AddWithValue("@streamid", streamid);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
