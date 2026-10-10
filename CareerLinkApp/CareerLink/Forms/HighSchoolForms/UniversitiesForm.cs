
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CareerLink.Forms.HighSchoolForms;
namespace CareerLink.Grade12
{
    public partial class UniversitiesForm : Form
    {
        // Use the same database as your Grade12Dashboard.
        private readonly string connectionString =
            @"Server=.\SQLEXPRESS;Database=CareerLink;Integrated Security=True;TrustServerCertificate=True;";

        public UniversitiesForm()
        {
            InitializeComponent();

            // Connect the buttons to their event handlers.
            btnSearch.Click += btnSearch_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnViewCourses.Click += btnViewCourses_Click;
            btnBack.Click += btnBack_Click;

            // Allow pressing Enter to search.
            txtSearch.KeyDown += txtSearch_KeyDown;

            // Open courses when a university is double-clicked.
            dgvUniversities.CellDoubleClick +=
                dgvUniversities_CellDoubleClick;

            Load += UniversitiesForm_Load;
        }

        private void UniversitiesForm_Load(object sender, EventArgs e)
        {
            LoadUniversities();
        }

        // Load universities from the database.
        private void LoadUniversities(string searchText = "")
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT
                            UniversityId,
                            UniversityName,
                            Province,
                            City,
                            Website
                        FROM dbo.Universities
                        WHERE
                            (@Search = '' OR
                             UniversityName LIKE '%' + @Search + '%' OR
                             Province LIKE '%' + @Search + '%' OR
                             City LIKE '%' + @Search + '%')
                        ORDER BY UniversityName";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(
                            "@Search",
                            SqlDbType.NVarChar,
                            150).Value = searchText.Trim();

                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            dgvUniversities.AutoGenerateColumns = false;
                            dgvUniversities.DataSource = table;

                            lblResults.Text =
                                $"Available Universities ({table.Rows.Count})";
                        }
                    }
                }

                dgvUniversities.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load universities.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Search button.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUniversities(txtSearch.Text);
        }

        // Press Enter to search.
        private void txtSearch_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                LoadUniversities(txtSearch.Text);
            }
        }

        // Refresh button.
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            LoadUniversities();
        }

        // View selected university courses.
        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            OpenSelectedUniversityCourses();
        }

        // Double-click university to view its courses.
        private void dgvUniversities_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            OpenSelectedUniversityCourses();
        }

        private void OpenSelectedUniversityCourses()
        {
            if (dgvUniversities.CurrentRow == null ||
                dgvUniversities.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Please select a university first.",
                    "No University Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            object idValue =
                dgvUniversities.CurrentRow
                    .Cells["colUniversityId"].Value;

            if (idValue == null || idValue == DBNull.Value)
            {
                MessageBox.Show(
                    "The selected university has no valid ID.",
                    "Invalid Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int universityId = Convert.ToInt32(idValue);

            string universityName = Convert.ToString(
                dgvUniversities.CurrentRow
                    .Cells["colUniversityName"].Value) ?? "";

            // AvailableCoursesForm will be created next.
            // It will receive the selected university ID and name.
            using (AvailableCoursesForm form =
                new AvailableCoursesForm(universityId, universityName))
            {
                form.ShowDialog(this);
            }
        }

        // Back button.
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
