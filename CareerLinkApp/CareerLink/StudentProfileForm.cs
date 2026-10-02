using System;
using System.Windows.Forms;
using CareerLink.BusinessLogic;
using CareerLink.Models;

namespace CareerLink
{
    public partial class StudentProfileForm : Form
    {
        private readonly CourseService courseService =
            new CourseService();

        private readonly StudentProfileService profileService =
            new StudentProfileService();

        public StudentProfileForm()
        {
            InitializeComponent();

            LoadCourses();
            LoadYears();
            LoadExistingProfile();
        }

        private void LoadCourses()
        {
            var courses = courseService.GetAllCourses();

            cmbCourse.DataSource = courses;
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseId";

            cmbCourse.SelectedIndex = -1;
        }

        private void LoadYears()
        {
            cmbYearOfStudy.Items.Clear();

            for (int year = 1; year <= 10; year++)
            {
                cmbYearOfStudy.Items.Add(year);
            }

            cmbYearOfStudy.SelectedIndex = -1;
        }

        private void LoadExistingProfile()
        {
            if (Session.CurrentUser == null)
                return;

            StudentProfile? profile =
                profileService.GetProfile(
                    Session.CurrentUser.UserId);

            if (profile == null)
                return;

            cmbCourse.SelectedValue = profile.CourseId;

            cmbYearOfStudy.SelectedItem =
                profile.YearOfStudy;

            lblInstitution.Text =
                $"Institution: {profile.Institution}";

            lblField.Text =
                $"Field: {profile.FieldName}";
        }

        private void cmbCourse_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cmbCourse.SelectedItem is Course course)
            {
                lblInstitution.Text =
                    $"Institution: {course.Institution}";

                lblField.Text =
                    $"Field: {course.FieldName}";
            }
            else
            {
                lblInstitution.Text =
                    "Institution: Not selected";

                lblField.Text =
                    "Field: Not selected";
            }
        }

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                MessageBox.Show(
                    "No user is currently logged in.");
                return;
            }

            if (cmbCourse.SelectedItem is not Course course)
            {
                MessageBox.Show(
                    "Please select your course.");
                return;
            }

            if (cmbYearOfStudy.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select your year of study.");
                return;
            }

            int yearOfStudy =
                (int)cmbYearOfStudy.SelectedItem;

            try
            {
                profileService.SaveProfile(
                    Session.CurrentUser.UserId,
                    course.CourseId,
                    yearOfStudy);

                MessageBox.Show(
                    "Student profile saved successfully.");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (BusinessRuleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}