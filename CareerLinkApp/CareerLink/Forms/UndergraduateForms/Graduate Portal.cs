using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CareerLink.BusinessLogic;
using CareerLink.Models;
namespace CareerLink
{
    public partial class Graduate_Portal : Form
    {

        private readonly StudentProfileService profileService =
            new StudentProfileService();

        private List<Opportunity> recommendedOpportunities =
    new List<Opportunity>();

        private readonly OpportunityService opportunityService =
            new OpportunityService();

        private readonly OpportunityApplicationService applicationService =
    new OpportunityApplicationService();

        public bool LogoutRequested { get; private set; } = false;


        public Graduate_Portal()
        {
            InitializeComponent();

        }

        private void Graduate_Portal_Load(
            object sender,
            EventArgs e)
        {
            LoadStudentInfo();

            LoadRecommendedOpportunities();
            LoadOpportunityCounts();
            LoadApplicationPreview();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnJobs_Click(object sender, EventArgs e)
        {

        }

        private void btnBursaries_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInternship_Click(object sender, EventArgs e)
        {
            using (var form =
                 new OpportunitiesForm("Internship"))
            {
                form.ShowDialog(this);
            }
            LoadApplicationPreview();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnLearneship_Click(
                    object sender,
                    EventArgs e)
        {
            using (var form =
                new OpportunitiesForm("Learnership"))
            {
                form.ShowDialog(this);
            }
            LoadApplicationPreview();
        }


        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void LoadStudentInfo()
        {
            if (Session.CurrentUser == null)
                return;

            StudentProfile? profile =
                profileService.GetProfile(
                    Session.CurrentUser.UserId);

            if (profile == null)
                return;

            lblWelcome.Text =
                $"Welcome, {Session.CurrentUser.FirstName}";

            lblCourse.Text =
                profile.CourseName;
        }

        private void LoadApplicationPreview()
        {
            panel4.Controls.Clear();

            if (Session.CurrentUser == null)
                return;

            List<OpportunityApplication> applications =
                applicationService.GetApplicationsForUser(
                    Session.CurrentUser.UserId);


            if (applications.Count == 0)
            {
                Label lblEmpty = new Label();

                lblEmpty.Text =
                    "You haven't applied for any opportunities yet.";

                lblEmpty.AutoSize = false;

                lblEmpty.Size =
                    new Size(220, 60);

                lblEmpty.Location =
                    new Point(15, 20);

                lblEmpty.Font =
                    new System.Drawing.Font(
                        "Segoe UI",
                        9F);

                lblEmpty.ForeColor =
                    Color.DimGray;

                panel4.Controls.Add(lblEmpty);

                return;
            }


            OpportunityApplication latest =
                applications.First();


            Label lblOpportunity =
                new Label();

            lblOpportunity.Text =
                latest.OpportunityTitle;

            lblOpportunity.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            lblOpportunity.AutoSize = false;

            lblOpportunity.Size =
                new Size(220, 35);

            lblOpportunity.Location =
                new Point(10, 8);


            Label lblCompany =
                new Label();

            lblCompany.Text =
                latest.Company;

            lblCompany.AutoSize = false;

            lblCompany.Size =
                new Size(220, 25);

            lblCompany.Location =
                new Point(10, 43);

            lblCompany.ForeColor =
                Color.DimGray;


            Label lblStatus =
                new Label();

            lblStatus.Text =
                $"Status: {latest.Status}";

            lblStatus.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            lblStatus.AutoSize = false;

            lblStatus.Size =
                new Size(220, 25);

            lblStatus.Location =
                new Point(10, 72);


            Label lblDate =
                new Label();

            lblDate.Text =
                $"Applied: {latest.ApplicationDate:dd MMM yyyy}";

            lblDate.AutoSize = false;

            lblDate.Size =
                new Size(220, 25);

            lblDate.Location =
                new Point(10, 97);

            lblDate.ForeColor =
                Color.DimGray;


            panel4.Controls.Add(lblOpportunity);
            panel4.Controls.Add(lblCompany);
            panel4.Controls.Add(lblStatus);
            panel4.Controls.Add(lblDate);
        }

        private void LoadOpportunityCounts()
        {
            if (Session.CurrentUser == null)
                return;

            StudentProfile? profile =
                profileService.GetProfile(
                    Session.CurrentUser.UserId);

            if (profile == null)
                return;

            List<Opportunity> opportunities =
                opportunityService.GetRecommendedForCourse(
                    profile.CourseId);

            int internshipCount =
                opportunities.Count(o =>
                    o.OpportunityType == "Internship");

            int jobCount =
                opportunities.Count(o =>
                    o.OpportunityType == "Part-Time Job" ||
                    o.OpportunityType == "Full-Time Job");

            int learnershipCount =
                opportunities.Count(o =>
                    o.OpportunityType == "Learnership");

            label10.Text = internshipCount.ToString();
            label9.Text = jobCount.ToString();
            label22.Text = learnershipCount.ToString();
            // Main cards
            label10.Text = internshipCount.ToString();
            label9.Text = jobCount.ToString();
            label22.Text = learnershipCount.ToString();

            // Quick Stats
            label14.Text = internshipCount.ToString();
            label16.Text = jobCount.ToString();
            label24.Text = learnershipCount.ToString();
        }

        private void LoadRecommendedOpportunities()
        {
            dgvJobs.Rows.Clear();

            dgvJobs.AllowUserToAddRows = false;
            dgvJobs.ReadOnly = true;
            dgvJobs.MultiSelect = false;

            dgvJobs.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;


            if (Session.CurrentUser == null)
                return;


            StudentProfile? profile =
                profileService.GetProfile(
                    Session.CurrentUser.UserId);


            if (profile == null)
            {
                MessageBox.Show(
                    "Please complete your student profile first.");

                using (StudentProfileForm form =
                    new StudentProfileForm())
                {
                    form.ShowDialog(this);
                }


                profile =
                    profileService.GetProfile(
                        Session.CurrentUser.UserId);


                if (profile == null)
                    return;
            }


            recommendedOpportunities =
                opportunityService.GetRecommendedForCourse(
                    profile.CourseId);


            foreach (Opportunity opportunity in
                recommendedOpportunities.Take(3))
            {
                string deadline =
                    opportunity.ClosingDate.HasValue
                        ? opportunity.ClosingDate.Value
                            .ToString("dd MMM yyyy")
                        : "No deadline";


                int rowIndex =
                    dgvJobs.Rows.Add(
                        opportunity.Company,
                        opportunity.Title,
                        opportunity.OpportunityType,
                        deadline);


                // Store the OpportunityId inside the row.
                // The user doesn't see this.
                dgvJobs.Rows[rowIndex].Tag =
                    opportunity.OpportunityId;
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogoutRequested = true;
                Close();
            }
        }

        private void btnJobs_Click_1(
     object sender,
     EventArgs e)
        {
            using (var form =
                new OpportunitiesForm("Jobs"))
            {
                form.ShowDialog(this);
            }

            LoadApplicationPreview();
        }

        private void btnViewApplications_Click(object sender, EventArgs e)
        {
            using (var form =
        new MyApplicationsForm())
            {
                form.ShowDialog(this);
            }

            // Refresh after returning
            LoadApplicationPreview();
        }

        private void btnViewAllOpportunities_Click(object sender, EventArgs e)
        {
            using (var form =
        new OpportunitiesForm())
            {
                form.ShowDialog(this);
            }
            LoadApplicationPreview();
        }

        private void dgvJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvJobs_CellClick(
     object sender,
     DataGridViewCellEventArgs e)
        {
            // Header clicked
            if (e.RowIndex < 0)
                return;


            // Only respond when the last "View" column is clicked
            if (e.ColumnIndex !=
                dgvJobs.Columns["Apply"].Index)
            {
                return;
            }


            DataGridViewRow row =
                dgvJobs.Rows[e.RowIndex];


            if (row.Tag == null)
                return;


            int opportunityId =
                Convert.ToInt32(row.Tag);


            Opportunity? opportunity =
                recommendedOpportunities.FirstOrDefault(o =>
                    o.OpportunityId == opportunityId);


            if (opportunity == null)
                return;


            using (var form =
                new OpportunityDetailsForm(opportunity))
            {
                form.ShowDialog(this);
            }


            // Student might have applied while
            // OpportunityDetailsForm was open.
            LoadApplicationPreview();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            using (StudentProfileForm form = new StudentProfileForm())
            {
                form.ShowDialog(this);
            }

            // Refresh dashboard because course/year may have changed
            LoadStudentInfo();
            LoadRecommendedOpportunities();
            LoadOpportunityCounts();
            LoadApplicationPreview();
        }
    }
}

