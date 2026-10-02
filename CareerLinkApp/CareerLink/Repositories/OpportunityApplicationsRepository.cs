using CareerLink.Data;
using CareerLink.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CareerLink.Repositories
{
    public class OpportunityApplicationsRepository
    {
        public bool HasApplied(
            int userId,
            int opportunityId)
        {
            using (SqlConnection connection =
                Db.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT COUNT(*)
                    FROM OpportunityApplications
                    WHERE UserId = @UserId
                    AND OpportunityId = @OpportunityId";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@UserId",
                        userId);

                    command.Parameters.AddWithValue(
                        "@OpportunityId",
                        opportunityId);

                    int count =
                        Convert.ToInt32(
                            command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public List<OpportunityApplication> GetByUserId(
    int userId)
        {
            List<OpportunityApplication> applications =
                new List<OpportunityApplication>();

            using (SqlConnection connection =
                Db.GetConnection())
            {
                connection.Open();

                string query = @"
            SELECT
                oa.ApplicationId,
                oa.UserId,
                oa.OpportunityId,
                oa.ApplicationDate,
                oa.Status,

                o.Title,
                o.Company,
                o.OpportunityType,
                o.Location,
                o.ClosingDate

            FROM OpportunityApplications oa

            INNER JOIN Opportunities o
                ON oa.OpportunityId =
                   o.OpportunityId

            WHERE oa.UserId = @UserId

            ORDER BY oa.ApplicationDate DESC";


                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@UserId",
                        userId);


                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OpportunityApplication application =
                                new OpportunityApplication
                                {
                                    ApplicationId =
                                        reader.GetInt32(
                                            reader.GetOrdinal(
                                                "ApplicationId")),

                                    UserId =
                                        reader.GetInt32(
                                            reader.GetOrdinal(
                                                "UserId")),

                                    OpportunityId =
                                        reader.GetInt32(
                                            reader.GetOrdinal(
                                                "OpportunityId")),

                                    ApplicationDate =
                                        reader.GetDateTime(
                                            reader.GetOrdinal(
                                                "ApplicationDate")),

                                    Status =
                                        reader.GetString(
                                            reader.GetOrdinal(
                                                "Status")),

                                    OpportunityTitle =
                                        reader.GetString(
                                            reader.GetOrdinal(
                                                "Title")),

                                    Company =
                                        reader.GetString(
                                            reader.GetOrdinal(
                                                "Company")),

                                    OpportunityType =
                                        reader.GetString(
                                            reader.GetOrdinal(
                                                "OpportunityType")),

                                    Location =
                                        reader.IsDBNull(
                                            reader.GetOrdinal(
                                                "Location"))
                                            ? "Not specified"
                                            : reader.GetString(
                                                reader.GetOrdinal(
                                                    "Location")),

                                    ClosingDate =
                                        reader.IsDBNull(
                                            reader.GetOrdinal(
                                                "ClosingDate"))
                                            ? null
                                            : reader.GetDateTime(
                                                reader.GetOrdinal(
                                                    "ClosingDate"))
                                };

                            applications.Add(application);
                        }
                    }
                }
            }

            return applications;
        }


        public void Add(
            OpportunityApplication application)
        {
            using (SqlConnection connection =
                Db.GetConnection())
            {
                connection.Open();

                string query = @"
                    INSERT INTO OpportunityApplications
                    (
                        UserId,
                        OpportunityId,
                        Status
                    )
                    VALUES
                    (
                        @UserId,
                        @OpportunityId,
                        @Status
                    )";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@UserId",
                        application.UserId);

                    command.Parameters.AddWithValue(
                        "@OpportunityId",
                        application.OpportunityId);

                    command.Parameters.AddWithValue(
                        "@Status",
                        application.Status);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}