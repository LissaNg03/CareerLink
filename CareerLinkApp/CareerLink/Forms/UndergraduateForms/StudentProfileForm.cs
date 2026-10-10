
using CareerLink.BusinessLogic;
using CareerLink.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CareerLink.Forms.UndergraduateForms
{
    public partial class StudentProfileForm : Form
    {
        private readonly StudentProfileService profileService =
            new StudentProfileService();

        private readonly string connectionString =
            @"Server=.\SQLEXPRESS;Database=CareerLink;Integrated Security=True;TrustServerCertificate=True;";

        public StudentProfileForm()
        {
            InitializeComponent();

            Load += StudentProfileForm_Load;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void StudentProfileForm_Load(
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

            LoadCourses();
            LoadExistingProfile();
        }

        private void LoadCourses()
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT CourseId, CourseName
                        FROM dbo.Courses
                        ORDER BY CourseName";

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        cmbCourse.DataSource = table;
                        cmbCourse.DisplayMember = "CourseName";
                        cmbCourse.ValueMember = "CourseId";
                        cmbCourse.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load courses.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadExistingProfile()
        {
            try
            {
                StudentProfile? profile =
                    profileService.GetProfile(
                        Session.CurrentUser.UserId);

                if (profile == null)
                    return;

                cmbCourse.SelectedValue = profile.CourseId;

                if (profile.YearOfStudy >= 1 &&
                    profile.YearOfStudy <= 10)
                {
                    numYear.Value = profile.YearOfStudy;
                }

                btnSave.Text = "Update Profile";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load your profile.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null)
                return;

            if (cmbCourse.SelectedValue == null ||
                cmbCourse.SelectedValue is DataRowView)
            {
                MessageBox.Show(
                    "Please select your course.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int courseId =
                    Convert.ToInt32(cmbCourse.SelectedValue);

                int yearOfStudy =
                    Convert.ToInt32(numYear.Value);

                profileService.SaveProfile(
                    Session.CurrentUser.UserId,
                    courseId,
                    yearOfStudy);

                MessageBox.Show(
                    "Your student profile has been saved!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (BusinessRuleException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save your profile.\n\n" +
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
