using CareerLink.BusinessLogic;
using CareerLink.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
namespace CareerLink
{
    public partial class OpportunitiesForm : Form
    {
        private readonly OpportunityService opportunityService =
            new OpportunityService();

        private readonly StudentProfileService profileService =
            new StudentProfileService();

        private List<Opportunity> opportunities =
            new List<Opportunity>();

        private readonly string initialType;


        public OpportunitiesForm(string opportunityType = "All")
        {
            InitializeComponent();

            initialType = opportunityType;

            LoadTypes();
            SetPageTitle();
            LoadOpportunities();
        }


        private void LoadTypes()
        {
            cmbType.Items.Clear();

            cmbType.Items.Add("All");
            cmbType.Items.Add("Jobs");
            cmbType.Items.Add("Internship");
            cmbType.Items.Add("Part-Time Job");
            cmbType.Items.Add("Full-Time Job");
            cmbType.Items.Add("Bursary");
            cmbType.Items.Add("Learnership");
            cmbType.Items.Add("Hackathon");
            cmbType.Items.Add("Graduate Programme");
            cmbType.Items.Add("Volunteer");


            if (cmbType.Items.Contains(initialType))
            {
                cmbType.SelectedItem =
                    initialType;
            }
            else
            {
                cmbType.SelectedItem =
                    "All";
            }
        }

        private void SetPageTitle()
        {
            switch (initialType)
            {
                case "Internship":
                    lblTitle.Text = "Internships";
                    lblSubtitle.Text = "Internships recommended for your course.";
                    Text = "CareerLink - Internships";
                    break;

                case "Learnership":
                    lblTitle.Text = "Learnerships";
                    lblSubtitle.Text = "Learnerships recommended for your course.";
                    Text = "CareerLink - Learnerships";
                    break;

                case "Jobs":
                    lblTitle.Text = "Jobs";
                    lblSubtitle.Text = "Jobs recommended for your course.";
                    Text = "CareerLink - Jobs";
                    break;

                default:
                    lblTitle.Text = "Opportunities";
                    lblSubtitle.Text = "Opportunities recommended for your course.";
                    Text = "CareerLink - Opportunities";
                    break;
            }
        }
        private void LoadOpportunities()
        {
            if (Session.CurrentUser == null)
                return;

            StudentProfile? profile =
                profileService.GetProfile(
                    Session.CurrentUser.UserId);

            if (profile == null)
            {
                MessageBox.Show(
                    "Please complete your student profile first.");

                Close();
                return;
            }

            opportunities =
                opportunityService.GetRecommendedForCourse(
                    profile.CourseId);

            ApplyFilters();
        }


        private void ApplyFilters()
        {
            IEnumerable<Opportunity> filtered =
                opportunities;

            string selectedType =
                cmbType.SelectedItem?.ToString()
                ?? "All";

            string search =
                txtSearch.Text.Trim();


            // Jobs means both job types
            if (selectedType == "Jobs")
            {
                filtered = filtered.Where(o =>
                    o.OpportunityType == "Part-Time Job"
                    || o.OpportunityType == "Full-Time Job");
            }
            else if (selectedType != "All")
            {
                filtered = filtered.Where(o =>
                    o.OpportunityType == selectedType);
            }


            if (!string.IsNullOrWhiteSpace(search))
            {
                filtered = filtered.Where(o =>
                    o.Title.Contains(
                        search,
                        StringComparison.OrdinalIgnoreCase)

                    || o.Company.Contains(
                        search,
                        StringComparison.OrdinalIgnoreCase)

                    || (o.Location?.Contains(
                        search,
                        StringComparison.OrdinalIgnoreCase)
                        ?? false));
            }


            DisplayOpportunities(
                filtered.ToList());
        }

        private void dgvOpportunities_CellDoubleClick(
          object sender,
          DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            object? idValue =
                dgvOpportunities.Rows[e.RowIndex]
                    .Cells["colOpportunityId"].Value;

            if (idValue == null)
                return;

            int opportunityId =
                Convert.ToInt32(idValue);

            Opportunity? opportunity =
                opportunities.FirstOrDefault(o =>
                    o.OpportunityId == opportunityId);

            if (opportunity == null)
                return;

            using (var form =
                new OpportunityDetailsForm(opportunity))
            {
                form.ShowDialog(this);
            }
        }
        private void DisplayOpportunities(
            List<Opportunity> filtered)
        {
            dgvOpportunities.Rows.Clear();

            foreach (Opportunity opportunity in filtered)
            {
                string deadline =
                    opportunity.ClosingDate.HasValue
                        ? opportunity.ClosingDate.Value
                            .ToString("dd MMM yyyy")
                        : "No deadline";

                dgvOpportunities.Rows.Add(
                    opportunity.OpportunityId,
                    opportunity.Company,
                    opportunity.Title,
                    opportunity.OpportunityType,
                    opportunity.Location ?? "Not specified",
                    deadline);
            }

            lblSubtitle.Text =
                $"{filtered.Count} opportunities found for your course.";
        }

        private void cmbType_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            ApplyFilters();
        }

        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {                                                               
            ApplyFilters();
        }


        private void btnClose_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}