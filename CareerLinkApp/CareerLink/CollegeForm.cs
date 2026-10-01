using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CareerLink.BusinessLogic;
using CareerLink.Models;

namespace CareerLink
{
    public partial class CollegeForm : Form
    {
        private readonly StreamService streamService = new StreamService();
        private readonly SubjectService subjectService = new SubjectService();

        
        private readonly Dictionary<string, int> marks = new Dictionary<string, int>();

        public CollegeForm()
        {
            InitializeComponent();

           
            cmbField.DisplayMember = "FieldName";
            cmbField.ValueMember = "FieldId";
            cmbField.DataSource = streamService.GetFields();

          
            cmbSubject.Items.AddRange(subjectService.GetSubjectNames().ToArray());
            if (cmbSubject.Items.Count > 0) cmbSubject.SelectedIndex = 0;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
          
            int index = cmbSubject.FindStringExact(cmbSubject.Text);
            if (index < 0)
            {
                MessageBox.Show("Please choose a subject from the list.");
                return;
            }

            string subject = cmbSubject.Items[index].ToString();
            marks[subject] = (int)numPercent.Value;      
            RefreshSubjectList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSubjects.SelectedItem == null) return;

         
            string subject = lstSubjects.SelectedItem.ToString()
                .Split(new[] { " - " }, StringSplitOptions.None)[0];
            marks.Remove(subject);
            RefreshSubjectList();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();

            var field = cmbField.SelectedItem as Field;
            if (field == null)
            {
                MessageBox.Show("Please choose the studies you want.");
                return;
            }
            if (marks.Count == 0)
            {
                MessageBox.Show("Please add at least one subject and percentage.");
                return;
            }

         
            List<StudyStream> qualified = streamService.GetQualifiedStreams(field.FieldId, marks);

            if (qualified.Count == 0)
            {
                lstResults.Items.Add("You do not qualify for any stream in " + field.FieldName + " yet.");
            }
            else
            {
                foreach (StudyStream stream in qualified)
                    lstResults.Items.Add(stream.StreamName);
            }
        }

        private void RefreshSubjectList()
        {
            lstSubjects.Items.Clear();
            foreach (var kv in marks)
                lstSubjects.Items.Add(kv.Key + " - " + kv.Value + "%");
        }
    }
}
