using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CareerLink.Models;
using CareerLink.Data;

namespace CareerLink.Repositories
{
    
    public class FieldsRepository
    {
        public List<Field> GetAllFields()
        {
            var fields = new List<Field>();

            using (SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT FieldId, FieldName FROM dbo.Fields ORDER BY FieldName";

                using (SqlCommand command = new SqlCommand(sql, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fields.Add(new Field
                        {
                            FieldId = reader.GetInt32(0),
                            FieldName = reader.GetString(1)
                        });
                    }
                }
            }
            return fields;
        }
    }
}
