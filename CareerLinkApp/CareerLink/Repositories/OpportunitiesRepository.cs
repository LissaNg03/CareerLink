using CareerLink.Data;
using CareerLink.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CareerLink.Repositories
{
    public class OpportunitiesRepository
    {
        public List<Opportunity> GetAllActive()
        {
            List<Opportunity> opportunities =
                new List<Opportunity>();

            using (SqlConnection connection = Db.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT
                        OpportunityId,
                        Title,
                        Company,
                        OpportunityType,
                        Description,
                        Requirements,
                        Location,
                        ClosingDate,
                        ApplicationURL,
                        IsActive,
                        CreatedAt
                    FROM Opportunities
                    WHERE IsActive = 1
                    AND (
                        ClosingDate IS NULL
                        OR ClosingDate >= CAST(GETDATE() AS DATE)
                    )
                    ORDER BY CreatedAt DESC;";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            opportunities.Add(
                                MapOpportunity(reader));
                        }
                    }
                }
            }

            return opportunities;
        }


        public List<Opportunity> GetByType(
            string opportunityType)
        {
            List<Opportunity> opportunities =
                new List<Opportunity>();

            using (SqlConnection connection = Db.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT
                        OpportunityId,
                        Title,
                        Company,
                        OpportunityType,
                        Description,
                        Requirements,
                        Location,
                        ClosingDate,
                        ApplicationURL,
                        IsActive,
                        CreatedAt
                    FROM Opportunities
                    WHERE IsActive = 1
                    AND OpportunityType = @OpportunityType
                    AND (
                        ClosingDate IS NULL
                        OR ClosingDate >= CAST(GETDATE() AS DATE)
                    )
                    ORDER BY ClosingDate ASC;";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@OpportunityType",
                        opportunityType);

                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            opportunities.Add(
                                MapOpportunity(reader));
                        }
                    }
                }
            }

            return opportunities;
        }


        public List<Opportunity> GetRecommendedForCourse(
            int courseId)
        {
            List<Opportunity> opportunities =
                new List<Opportunity>();

            using (SqlConnection connection = Db.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT
                        o.OpportunityId,
                        o.Title,
                        o.Company,
                        o.OpportunityType,
                        o.Description,
                        o.Requirements,
                        o.Location,
                        o.ClosingDate,
                        o.ApplicationURL,
                        o.IsActive,
                        o.CreatedAt
                    FROM Opportunities o
                    INNER JOIN OpportunityCourses oc
                        ON o.OpportunityId = oc.OpportunityId
                    WHERE oc.CourseId = @CourseId
                    AND o.IsActive = 1
                    AND (
                        o.ClosingDate IS NULL
                        OR o.ClosingDate >= CAST(GETDATE() AS DATE)
                    )
                    ORDER BY o.ClosingDate ASC;";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@CourseId",
                        courseId);

                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            opportunities.Add(
                                MapOpportunity(reader));
                        }
                    }
                }
            }

            return opportunities;
        }


        private Opportunity MapOpportunity(
            SqlDataReader reader)
        {
            return new Opportunity
            {
                OpportunityId =
                    reader.GetInt32(
                        reader.GetOrdinal("OpportunityId")),

                Title =
                    reader.GetString(
                        reader.GetOrdinal("Title")),

                Company =
                    reader.GetString(
                        reader.GetOrdinal("Company")),

                OpportunityType =
                    reader.GetString(
                        reader.GetOrdinal("OpportunityType")),

                Description =
                    reader["Description"] == DBNull.Value
                        ? null
                        : reader["Description"].ToString(),

                Requirements =
                    reader["Requirements"] == DBNull.Value
                        ? null
                        : reader["Requirements"].ToString(),

                Location =
                    reader["Location"] == DBNull.Value
                        ? null
                        : reader["Location"].ToString(),

                ClosingDate =
                    reader["ClosingDate"] == DBNull.Value
                        ? null
                        : Convert.ToDateTime(
                            reader["ClosingDate"]),

                ApplicationURL =
                    reader["ApplicationURL"] == DBNull.Value
                        ? null
                        : reader["ApplicationURL"].ToString(),

                IsActive =
                    reader.GetBoolean(
                        reader.GetOrdinal("IsActive")),

                CreatedAt =
                    reader.GetDateTime(
                        reader.GetOrdinal("CreatedAt"))
            };
        }
    }
}