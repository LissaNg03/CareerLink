using CareerLink.Models;
using System;
using System.Windows.Forms;
using CareerLink.BusinessLogic;
using CareerLink.Models;
namespace CareerLink
{
    public partial class OpportunityDetailsForm : Form
    {
        private readonly Opportunity opportunity;

        private readonly OpportunityApplicationService applicationService =
            new OpportunityApplicationService();


        public OpportunityDetailsForm(
            Opportunity opportunity)
        {
            InitializeComponent();

            this.opportunity = opportunity;

            LoadOpportunity();

            CheckApplicationStatus();
        }

        private void LoadOpportunity()
        {
            lblTitle.Text = opportunity.Title;
            lblCompany.Text = opportunity.Company;

            lblTypeValue.Text =
                opportunity.OpportunityType;

            lblLocationValue.Text =
                opportunity.Location ?? "Not specified";

            lblDeadlineValue.Text =
                opportunity.ClosingDate.HasValue
                    ? opportunity.ClosingDate.Value
                        .ToString("dd MMM yyyy")
                    : "No deadline";

            txtDescription.Text =
                opportunity.Description
                ?? "No description available.";

            txtRequirements.Text =
                opportunity.Requirements
                ?? "No requirements specified.";
        }

        private void CheckApplicationStatus()
        {
            if (Session.CurrentUser == null)
                return;

            bool alreadyApplied =
                applicationService.HasApplied(
                    Session.CurrentUser.UserId,
                    opportunity.OpportunityId);

            if (alreadyApplied)
            {
                btnApply.Text = "Already Applied";
                btnApply.Enabled = false;
            }
        }

        private void btnApply_Click(
    object sender,
    EventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                MessageBox.Show(
                    "You must be logged in to apply.",
                    "CareerLink",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            DialogResult result =
                MessageBox.Show(
                    $"Are you sure you want to apply for:\n\n" +
                    $"{opportunity.Title}\n" +
                    $"{opportunity.Company}?",
                    "Confirm Application",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);


            if (result != DialogResult.Yes)
                return;


            try
            {
                applicationService.Apply(
                    Session.CurrentUser.UserId,
                    opportunity.OpportunityId);


                MessageBox.Show(
                    "Application submitted successfully!",
                    "CareerLink",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                btnApply.Text =
                    "Already Applied";

                btnApply.Enabled =
                    false;
            }
            catch (BusinessRuleException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "CareerLink",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not submit your application.\n\n" +
                    ex.Message,
                    "CareerLink",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}