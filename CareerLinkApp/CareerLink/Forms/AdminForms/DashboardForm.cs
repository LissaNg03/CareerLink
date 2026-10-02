using System;
using System.Windows.Forms;
using CareerLink.Models;

namespace CareerLink
{
    
    public partial class DashboardForm : Form
    {
        
        public bool LogoutRequested { get; private set; }

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "WELCOME " + Session.CurrentUser.FirstName;

           
            bool isAdmin = Session.CurrentUser.UserType == UserTypes.Admin;
            lblAdmin.Visible = isAdmin;
            btnManageUsers.Visible = isAdmin;
            btnManageSubjects.Visible = isAdmin;
            btnManageStreams.Visible = isAdmin;
            btnManageCareers.Visible = isAdmin;
        }

        private void btnCollege_Click(object sender, EventArgs e)
        {
            using (var form = new CollegeForm())
                form.ShowDialog(this);
        }

        private void btnHighSchool_Click(object sender, EventArgs e)
        {
            using (var form = new HighSchoolForm())
                form.ShowDialog(this);
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            using (var form = new UsersForm())
                form.ShowDialog(this);
        }

        private void btnManageSubjects_Click(object sender, EventArgs e)
        {
            using (var form = new SubjectsForm())
                form.ShowDialog(this);
        }

        private void btnManageStreams_Click(object sender, EventArgs e)
        {
            using (var form = new StreamsForm())
                form.ShowDialog(this);
        }

        private void btnManageCareers_Click(object sender, EventArgs e)
        {
            using (var form = new CareersForm())
                form.ShowDialog(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutRequested = true;
            Close();
        }
    }
}
