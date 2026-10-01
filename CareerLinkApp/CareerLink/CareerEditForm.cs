using System;
using System.Windows.Forms;
using CareerLink.BusinessLogic;
using CareerLink.Models;

namespace CareerLink
{
    public partial class CareerEditForm : Form
    {
        private readonly CareerService careerService = new CareerService();

        private int careerId = 0;               

        public CareerEditForm()
        {
            InitializeComponent();
        }

       
        public void EditCareer(Career career)
        {
            this.Text = "Edit Career";
            this.lblAdd.Text = "EDIT CAREER";

            this.txtKeyword.Text = career.Keyword;
            this.txtCareerName.Text = career.CareerName;
            this.txtSubjects.Text = CareerService.SubjectsToText(career.Subjects);

            this.careerId = career.CareerId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var career = new Career
            {
                CareerId = this.careerId,
                Keyword = this.txtKeyword.Text,
                CareerName = this.txtCareerName.Text,
                Subjects = CareerService.ParseSubjects(this.txtSubjects.Text)
            };

            try
            {
                careerService.Save(career);              
                this.DialogResult = DialogResult.OK;
            }
            catch (BusinessRuleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
