using System;
using System.Windows.Forms;
using CareerLink.BusinessLogic;
using CareerLink.Models;

namespace CareerLink
{
    public partial class HighSchoolForm : Form
    {
        private readonly CareerService careerService = new CareerService();

        public HighSchoolForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstSubjects.Items.Clear();

            try
            {
                Career career = careerService.FindCareer(txtCareer.Text);

                if (career == null)
                {
                    lblResult.Text = "Sorry, we don't have \"" + txtCareer.Text.Trim() + "\" yet.";
                    return;
                }

                lblResult.Text = "Subjects you need for " + txtCareer.Text.Trim() + ":";
                foreach (string subject in career.Subjects)
                    lstSubjects.Items.Add(subject);
            }
            catch (BusinessRuleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
