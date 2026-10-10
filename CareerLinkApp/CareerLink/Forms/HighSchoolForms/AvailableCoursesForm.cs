
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CareerLink.Forms.HighSchoolForms
{
    public partial class AvailableCoursesForm : Form
    {
        private readonly string connectionString =
            @"Server=.\SQLEXPRESS;Database=CareerLink;Integrated Security=True;TrustServerCertificate=True;";

        // Null means display courses from all universities.
        private readonly int? selectedUniversityId;
        private readonly string selectedUniversityName;

        // Constructor used by the Grade 12 Dashboard.
        public AvailableCoursesForm()
        {
            InitializeComponent();

            selectedUniversityId = null;
            selectedUniversityName = "All Universities";

            SetupForm();
        }

        // Constructor used by UniversitiesForm.
        public AvailableCoursesForm(
            int universityId,
            string universityName)
        {
            InitializeComponent();

            selectedUniversityId = universityId;
            selectedUniversityName = universityName;

            SetupForm();
        }

        private void SetupForm()
        {
            lblUniversity.Text = selectedUniversityName;

            btnSearch.Click += btnSearch_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnApply.Click += btnApply_Click;
            btnBack.Click += btnBack_Click;

            txtSearch.KeyDown += txtSearch_KeyDown;

            cmbQualification.SelectedIndexChanged +=
                cmbQualification_SelectedIndexChanged;

            dgvCourses.CellDoubleClick +=
                dgvCourses_CellDoubleClick;

            Load += AvailableCoursesForm_Load;
        }

        private void AvailableCoursesForm_Load(
            object sender,
            EventArgs e)
        {
            LoadCourses();
        }

        // Load courses using optional search and qualification filters.
        private void LoadCourses()
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                string qualification =
                    cmbQualification.SelectedItem?.ToString()
                    ?? "All Qualifications";

                string query = @"
                    SELECT
                        c.UniversityCourseId,
                        c.CourseName,
                        u.UniversityName,
                        c.QualificationType,
                        c.MinimumAPS,
                        c.DurationYears,
                        CASE
                            WHEN c.IsOpen = 1 THEN 'Open'
                            ELSE 'Closed'
                        END AS Status
                    FROM dbo.UniversityCourses c
                    INNER JOIN dbo.Universities u
                        ON c.UniversityId = u.UniversityId
                    WHERE
                        (@UniversityId IS NULL
                         OR c.UniversityId = @UniversityId)
                        AND
                        (@Search = ''
                         OR c.CourseName LIKE '%' + @Search + '%')
                        AND
                        (@Qualification = 'All Qualifications'
                         OR c.QualificationType = @Qualification)
                    ORDER BY u.UniversityName, c.CourseName";

                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@UniversityId",
                        SqlDbType.Int).Value =
                        selectedUniversityId.HasValue
                            ? (object)selectedUniversityId.Value
                            : DBNull.Value;

                    command.Parameters.Add(
                        "@Search",
                        SqlDbType.NVarChar,
                        200).Value = searchText;

                    command.Parameters.Add(
                        "@Qualification",
                        SqlDbType.NVarChar,
                        100).Value = qualification;

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dgvCourses.AutoGenerateColumns = false;
                        dgvCourses.DataSource = table;

                        lblResults.Text =
                            $"Available Courses ({table.Rows.Count})";
                    }
                }

                dgvCourses.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load available courses.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Search button.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCourses();
        }

        // Search when Enter is pressed.
        private void txtSearch_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadCourses();
            }
        }

        // Filter by qualification.
        private void cmbQualification_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (IsHandleCreated)
            {
                LoadCourses();
            }
        }

        // Refresh all filters.
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbQualification.SelectedIndex = 0;

            LoadCourses();
        }

        // Apply button.
        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplyForSelectedCourse();
        }

        // Double-click a course.
        private void dgvCourses_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            ApplyForSelectedCourse();
        }

        private void ApplyForSelectedCourse()
        {
            if (dgvCourses.CurrentRow == null ||
                dgvCourses.CurrentRow.IsNewRow ||
                !dgvCourses.CurrentRow.Selected)
            {
                MessageBox.Show(
                    "Please select a course first.",
                    "No Course Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DataGridViewRow row = dgvCourses.CurrentRow;

            object courseIdValue =
                row.Cells["colCourseId"].Value;

            if (courseIdValue == null ||
                courseIdValue == DBNull.Value)
            {
                MessageBox.Show(
                    "The selected course has an invalid ID.",
                    "Invalid Course",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int courseId = Convert.ToInt32(courseIdValue);

            string courseName = Convert.ToString(
                row.Cells["colCourseName"].Value) ?? "";

            string universityName = Convert.ToString(
                row.Cells["colUniversity"].Value) ?? "";

            string status = Convert.ToString(
                row.Cells["colStatus"].Value) ?? "";

            if (!status.Equals(
                "Open",
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Applications for this course are currently closed.",
                    "Applications Closed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            using (CourseApplicationForm form =
                new CourseApplicationForm(courseId))
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
