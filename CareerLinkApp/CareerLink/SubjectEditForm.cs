using System;
using System.Linq;
using System.Windows.Forms;
using CareerLink.BusinessLogic;
using CareerLink.Models;

namespace CareerLink
{
    public partial class SubjectEditForm : Form
    {
        private readonly SubjectService subjectService = new SubjectService();

        private int subjectId = 0;               // 0 = creating a new subject

        public SubjectEditForm()
        {
            InitializeComponent();

            cmbCategory.Items.AddRange(subjectService.GetCategories().ToArray());
            cmbGradeRange.Items.AddRange(SubjectService.GradeRanges);
            cmbGradeRange.Text = "Grades 10-12";           // most subjects
        }

        // fill the form with the subject's data for editing
        public void EditSubject(Subject subject)
        {
            this.Text = "Edit Subject";
            this.lblAdd.Text = "EDIT SUBJECT";

            this.txtSubjectName.Text = subject.SubjectName;
            this.cmbCategory.Text = subject.Category;
            this.cmbGradeRange.Text = subject.GradeRange;

            this.subjectId = subject.SubjectId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var subject = new Subject
            {
                SubjectId = this.subjectId,
                SubjectName = this.txtSubjectName.Text,
                Category = this.cmbCategory.Text,
                GradeRange = this.cmbGradeRange.Text
            };

            try
            {
                subjectService.Save(subject);            // creates when SubjectId is 0, otherwise updates
                this.DialogResult = DialogResult.OK;
            }
            catch (BusinessRuleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
