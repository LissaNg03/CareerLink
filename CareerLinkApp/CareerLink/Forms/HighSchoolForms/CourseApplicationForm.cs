
using CareerLink.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CareerLink.Forms.HighSchoolForms
{
    public partial class CourseApplicationForm : Form
    {
        private readonly int universityCourseId;

        private readonly string connectionString =
            @"Server=.\SQLEXPRESS;Database=CareerLink;Integrated Security=True;TrustServerCertificate=True;";

        private bool courseIsOpen = false;

        public CourseApplicationForm(int courseId)
        {
            InitializeComponent();

            universityCourseId = courseId;

            Load += CourseApplicationForm_Load;
            btnSubmit.Click += btnSubmit_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void CourseApplicationForm_Load(
            object sender, EventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                MessageBox.Show(
                    "Please log in first.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();
                return;
            }

            LoadCourseDetails();
        }

        private void LoadCourseDetails()
        {
            btnSubmit.Enabled = false;
            courseIsOpen = false;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    @"SELECT
                          c.CourseName,
                          c.QualificationType,
                          c.MinimumAPS,
                          c.DurationYears,
                          c.IsOpen,
                          u.UniversityName
                      FROM dbo.UniversityCourses c
                      INNER JOIN dbo.Universities u
                          ON c.UniversityId = u.UniversityId
                      WHERE c.UniversityCourseId = @CourseId",
                    connection))
                {
                    command.Parameters.Add(
                        "@CourseId", SqlDbType.Int).Value =
                        universityCourseId;

                    connection.Open();

                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show(
                                "The selected course was not found.",
                                "Course Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }

                        lblUniversity.Text =
                            Convert.ToString(reader["UniversityName"]) ?? "";

                        lblCourse.Text =
                            Convert.ToString(reader["CourseName"]) ?? "";

                        lblQualification.Text =
                            Convert.ToString(reader["QualificationType"]) ?? "";

                        lblAPS.Text =
                            Convert.ToString(reader["MinimumAPS"]) ?? "--";

                        lblDuration.Text =
                            Convert.ToString(reader["DurationYears"]) +
                            " years";

                        courseIsOpen =
                            Convert.ToBoolean(reader["IsOpen"]);
                    }
                }

                btnSubmit.Enabled = courseIsOpen;

                if (!courseIsOpen)
                {
                    MessageBox.Show(
                        "Applications for this course are closed.",
                        "Applications Closed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load course details.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null || !courseIsOpen)
                return;

            DialogResult confirmation = MessageBox.Show(
                $"Submit your application for:\n\n" +
                $"{lblCourse.Text}\n" +
                $"{lblUniversity.Text}?",
                "Confirm Application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlTransaction transaction =
                        connection.BeginTransaction())
                    {
                        try
                        {
                            // Check for existing application.
                            using (SqlCommand checkCommand =
                                new SqlCommand(
                                    @"SELECT COUNT(*)
                                      FROM dbo.CourseApplications
                                           WITH (UPDLOCK, HOLDLOCK)
                                      WHERE UserId = @UserId
                                        AND UniversityCourseId = @CourseId",
                                    connection,
                                    transaction))
                            {
                                checkCommand.Parameters.Add(
                                    "@UserId", SqlDbType.Int).Value =
                                    Session.CurrentUser.UserId;

                                checkCommand.Parameters.Add(
                                    "@CourseId", SqlDbType.Int).Value =
                                    universityCourseId;

                                int existingCount = Convert.ToInt32(
                                    checkCommand.ExecuteScalar());

                                if (existingCount > 0)
                                {
                                    transaction.Rollback();

                                    MessageBox.Show(
                                        "You have already applied for this course.",
                                        "Duplicate Application",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                    return;
                                }
                            }

                            // Verify the course is still open.
                            using (SqlCommand statusCommand =
                                new SqlCommand(
                                    @"SELECT IsOpen
                                      FROM dbo.UniversityCourses
                                      WHERE UniversityCourseId = @CourseId",
                                    connection,
                                    transaction))
                            {
                                statusCommand.Parameters.Add(
                                    "@CourseId", SqlDbType.Int).Value =
                                    universityCourseId;

                                object result =
                                    statusCommand.ExecuteScalar();

                                if (result == null ||
                                    result == DBNull.Value ||
                                    !Convert.ToBoolean(result))
                                {
                                    transaction.Rollback();

                                    MessageBox.Show(
                                        "This course is no longer open for applications.",
                                        "Applications Closed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                    return;
                                }
                            }

                            // Save application.
                            using (SqlCommand insertCommand =
                                new SqlCommand(
                                    @"INSERT INTO dbo.CourseApplications
                                          (UserId,
                                           UniversityCourseId,
                                           Status,
                                           ApplicationDate)
                                      VALUES
                                          (@UserId,
                                           @CourseId,
                                           @Status,
                                           GETDATE())",
                                    connection,
                                    transaction))
                            {
                                insertCommand.Parameters.Add(
                                    "@UserId", SqlDbType.Int).Value =
                                    Session.CurrentUser.UserId;

                                insertCommand.Parameters.Add(
                                    "@CourseId", SqlDbType.Int).Value =
                                    universityCourseId;

                                insertCommand.Parameters.Add(
                                    "@Status", SqlDbType.NVarChar, 50).Value =
                                    "Pending";

                                insertCommand.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            try
                            {
                                transaction.Rollback();
                            }
                            catch
                            {
                                // Transaction may already be completed.
                            }

                            throw;
                        }
                    }
                }

                MessageBox.Show(
                    "Your course application has been saved successfully!",
                    "Application Submitted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show(
                        "You have already applied for this course.",
                        "Duplicate Application",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Unable to submit application.\n\n" +
                        ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to submit application.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
