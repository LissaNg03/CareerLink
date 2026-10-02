using System;
using Microsoft.Data.SqlClient;

namespace CareerLink.Data
{
   
    public static class Db
    {
       
        public const string ConnectionString =
            "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CareerLink;Integrated Security=True;Encrypt=False";

        public static bool TryConnect(out string error)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                }
                error = null;
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }


        public static object OrNull(string value)
        {
            return value == null ? (object)DBNull.Value : value;
        }
    }
}
