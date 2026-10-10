
using CareerLink.Models;
using CareerLink.Grade12;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CareerLink.Forms.HighSchoolForms;
namespace CareerLink
{
    public partial class Grade12Dashboard : Form
    {
        private readonly string connectionString =
            @"Server=.\SQLEXPRESS;Database=CareerLink;Integrated Security=True;TrustServerCertificate=True;";

        public bool LogoutRequested { get; private set; } = false;

        public Grade12Dashboard()
        {
            InitializeComponent();

            // Avoid duplicate click handlers from the Designer.
            btnCourses.Click -= btnCourses_Click_1;

            btnUniversities.Click += btnUniversities_Click;
            btnCourses.Click += btnCourses_Click;
            btnApplications.Click += btnApplications_Click;
            btnAPS.Click += btnAPS_Click;
            btnCareers.Click += btnCareers_Click;
            btnLogout.Click += btnLogout_Click;
            btnRefresh.Click += btnRefresh_Click;

            Load += Grade12Dashboard_Load;
            Activated += Grade12Dashboard_Activated;

            dgvApplications.AutoGenerateColumns = true;
        }

        private void Grade12Dashboard_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                MessageBox.Show(
                    "Please log in to access the Grade 12 dashboard.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();
                return;
            }

            lblWelcome.Text =
                $"Welcome, {Session.CurrentUser.FirstName}!";

            lblGrade.Text = "Grade 12 Learner";

            RefreshDashboard();
        }

        private void Grade12Dashboard_Activated(object sender, EventArgs e)
        {
            // Do not reload here: modal forms are refreshed
            // explicitly after they close.
        }

        private void RefreshDashboard()
        {
            if (Session.CurrentUser == null)
                return;

            LoadQuickStats();
            LoadRecentApplications();
        }

        private void LoadQuickStats()
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    lblUniversityCount.Text =
                        "Universities: " +
                        ExecuteCount(
                            connection,
                            "SELECT COUNT(*) FROM dbo.Universities");

                    lblCourseCount.Text =
                        "Courses: " +
                        ExecuteCount(
                            connection,
                            @"SELECT COUNT(*)
                              FROM dbo.UniversityCourses
                              WHERE IsOpen = 1");

                    using (SqlCommand command = new SqlCommand(
                        @"SELECT COUNT(*)
                          FROM dbo.CourseApplications
                          WHERE UserId = @UserId",
                        connection))
                    {
                        command.Parameters.Add(
                            "@UserId", SqlDbType.Int).Value =
                            Session.CurrentUser.UserId;

                        int count = Convert.ToInt32(
                            command.ExecuteScalar());

                        lblApplicationCount.Text =
                            $"My Applications: {count}";
                    }
                }
            }
            catch (Exception ex)
            {
                lblUniversityCount.Text = "Universities: --";
                lblCourseCount.Text = "Courses: --";
                lblApplicationCount.Text = "My Applications: --";

                MessageBox.Show(
                    "Unable to load dashboard statistics.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int ExecuteCount(
            SqlConnection connection,
            string query)
        {
            using (SqlCommand command =
                new SqlCommand(query, connection))
            {
                return Convert.ToInt32(
                    command.ExecuteScalar());
            }
        }

        private void LoadRecentApplications()
        {
            dgvApplications.DataSource = null;

            if (Session.CurrentUser == null)
                return;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT TOP (5)
                            u.UniversityName AS University,
                            c.CourseName AS Course,
                            a.Status,
                            a.ApplicationDate AS [Date Applied]
                        FROM dbo.CourseApplications a
                        INNER JOIN dbo.UniversityCourses c
                            ON a.UniversityCourseId =
                               c.UniversityCourseId
                        INNER JOIN dbo.Universities u
                            ON c.UniversityId = u.UniversityId
                        WHERE a.UserId = @UserId
                        ORDER BY a.ApplicationDate DESC";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(
                            "@UserId", SqlDbType.Int).Value =
                            Session.CurrentUser.UserId;

                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            dgvApplications.DataSource = table;
                        }
                    }
                }

                if (dgvApplications.Columns.Contains("Date Applied"))
                {
                    dgvApplications.Columns["Date Applied"]
                        .DefaultCellStyle.Format = "dd MMM yyyy";
                }

                dgvApplications.EnableHeadersVisualStyles = false;

                dgvApplications.ColumnHeadersDefaultCellStyle.BackColor =
                    Color.DarkSlateGray;

                dgvApplications.ColumnHeadersDefaultCellStyle.ForeColor =
                    Color.White;

                dgvApplications.AlternatingRowsDefaultCellStyle.BackColor =
                    Color.AliceBlue;

                dgvApplications.ClearSelection();

                lblRecentApplications.Text =
                    $"Recent Course Applications ({dgvApplications.Rows.Count})";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load recent applications.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // UNIVERSITIES
        private void btnUniversities_Click(object sender, EventArgs e)
        {
            using (UniversitiesForm form = new UniversitiesForm())
            {
                form.ShowDialog(this);
            }

            RefreshDashboard();
        }

        // AVAILABLE COURSES
        private void btnCourses_Click(object sender, EventArgs e)
        {
            using (AvailableCoursesForm form =
                new AvailableCoursesForm())
            {
                form.ShowDialog(this);
            }

            RefreshDashboard();
        }

        // APPLICATIONS
        private void btnApplications_Click(object sender, EventArgs e)
        {
            // Until Grade12ApplicationsForm is created,
            // display this learner's applications here.
            ShowAllApplications();
        }

        private void ShowAllApplications()
        {
            if (Session.CurrentUser == null)
                return;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT
                            u.UniversityName AS University,
                            c.CourseName AS Course,
                            a.Status,
                            a.ApplicationDate AS [Date Applied]
                        FROM dbo.CourseApplications a
                        INNER JOIN dbo.UniversityCourses c
                            ON a.UniversityCourseId =
                               c.UniversityCourseId
                        INNER JOIN dbo.Universities u
                            ON c.UniversityId = u.UniversityId
                        WHERE a.UserId = @UserId
                        ORDER BY a.ApplicationDate DESC";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(
                            "@UserId", SqlDbType.Int).Value =
                            Session.CurrentUser.UserId;

                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            dgvApplications.DataSource = table;

                            lblRecentApplications.Text =
                                $"My Course Applications ({table.Rows.Count})";
                        }
                    }
                }

                if (dgvApplications.Columns.Contains("Date Applied"))
                {
                    dgvApplications.Columns["Date Applied"]
                        .DefaultCellStyle.Format = "dd MMM yyyy";
                }

                dgvApplications.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load applications.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // APS CALCULATOR
        private void btnAPS_Click(object sender, EventArgs e)
        {
            using (CareerLink.Forms.HighSchoolForms.APSForm form =
                new CareerLink.Forms.HighSchoolForms.APSForm())
            {
                form.ShowDialog(this);
            }
        }



        // CAREER RECOMMENDATIONS
        private void btnCareers_Click(object sender, EventArgs e)
        {
            using (var form = new CareerRecommendationsForm())
            {
                form.ShowDialog(this);
            }
        }

        // REFRESH
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDashboard();
        }

        // LOGOUT
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "CareerLink - Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                LogoutRequested = true;
                Close();
            }
        }

        // Kept because the current Designer references it.
        private void btnCourses_Click_1(object sender, EventArgs e)
        {
        }

        private void btnApplications_Click_1(object sender, EventArgs e)
        {
            using (Grade12ApplicationsForm form =
                new Grade12ApplicationsForm())
            {
                form.ShowDialog(this);
            }

            RefreshDashboard();
        }
    }
}
