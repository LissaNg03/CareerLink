
using CareerLink.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CareerLink.Forms.HighSchoolForms
{
    public partial class Grade12ApplicationsForm : Form
    {
        private readonly string connectionString =
            @"Server=.\SQLEXPRESS;Database=CareerLink;Integrated Security=True;TrustServerCertificate=True;";

        public Grade12ApplicationsForm()
        {
            InitializeComponent();

            Load += Grade12ApplicationsForm_Load;
            btnSearch.Click += btnSearch_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnBack.Click += btnBack_Click;
            txtSearch.KeyDown += txtSearch_KeyDown;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
        }

        private void Grade12ApplicationsForm_Load(
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

            LoadApplications();
        }

        private void LoadApplications()
        {
            if (Session.CurrentUser == null)
                return;

            try
            {
                string search = txtSearch.Text.Trim();
                string status =
                    cmbStatus.SelectedItem?.ToString() ?? "All Statuses";

                string query = @"
                    SELECT
                        a.ApplicationId,
                        u.UniversityName,
                        c.CourseName,
                        a.Status,
                        a.ApplicationDate
                    FROM dbo.CourseApplications a
                    INNER JOIN dbo.UniversityCourses c
                        ON a.UniversityCourseId = c.UniversityCourseId
                    INNER JOIN dbo.Universities u
                        ON c.UniversityId = u.UniversityId
                    WHERE a.UserId = @UserId
                      AND (
                          @Search = ''
                          OR u.UniversityName LIKE '%' + @Search + '%'
                          OR c.CourseName LIKE '%' + @Search + '%'
                      )
                      AND (
                          @Status = 'All Statuses'
                          OR a.Status = @Status
                      )
                    ORDER BY a.ApplicationDate DESC";

                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@UserId", SqlDbType.Int).Value =
                        Session.CurrentUser.UserId;

                    command.Parameters.Add(
                        "@Search", SqlDbType.NVarChar, 200).Value =
                        search;

                    command.Parameters.Add(
                        "@Status", SqlDbType.NVarChar, 50).Value =
                        status;

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvApplications.DataSource = table;

                        lblResults.Text =
                            $"My Applications ({table.Rows.Count})";
                    }
                }

                dgvApplications.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load your applications.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadApplications();
        }

        private void txtSearch_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadApplications();
            }
        }

        private void cmbStatus_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (IsHandleCreated)
                LoadApplications();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbStatus.SelectedIndex = 0;
            LoadApplications();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
