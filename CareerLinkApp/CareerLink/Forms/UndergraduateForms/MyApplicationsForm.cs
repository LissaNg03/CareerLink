using CareerLink.BusinessLogic;
using CareerLink.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CareerLink
{
    public partial class MyApplicationsForm : Form
    {
        private readonly OpportunityApplicationService applicationService =
            new OpportunityApplicationService();


        public MyApplicationsForm()
        {
            InitializeComponent();

            LoadApplications();
        }


        private void LoadApplications()
        {
            dgvApplications.Rows.Clear();

            if (Session.CurrentUser == null)
                return;


            List<OpportunityApplication> applications =
                applicationService.GetApplicationsForUser(
                    Session.CurrentUser.UserId);


            foreach (OpportunityApplication application
                in applications)
            {
                dgvApplications.Rows.Add(
                    application.OpportunityTitle,
                    application.Company,
                    application.OpportunityType,
                    application.ApplicationDate
                        .ToString("dd MMM yyyy"),
                    application.Status);
            }


            lblCount.Text =
                $"{applications.Count} application(s)";
        }


        private void btnClose_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}