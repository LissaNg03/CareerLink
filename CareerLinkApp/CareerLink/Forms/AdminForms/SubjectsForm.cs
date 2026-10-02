using System;
using System.Data;
using System.Windows.Forms;
using CareerLink.BusinessLogic;
using CareerLink.Models;

namespace CareerLink
{
    public partial class SubjectsForm : Form
    {
        private readonly SubjectService subjectService = new SubjectService();

        public SubjectsForm()
        {
            InitializeComponent();
            ReadSubjects();
        }

        private void ReadSubjects()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Subject ID", typeof(int));
            dataTable.Columns.Add("Subject Name", typeof(string));
            dataTable.Columns.Add("Category", typeof(string));
            dataTable.Columns.Add("Grade Range", typeof(string));

            foreach (Subject subject in subjectService.GetAllSubjects())
                dataTable.Rows.Add(subject.SubjectId, subject.SubjectName, subject.Category, subject.GradeRange);

            this.subjectsTable.DataSource = dataTable;
            ApplySearch();                       // keep the search filter after a refresh
        }

        // filters the grid by what is typed in the search box
        private void ApplySearch()
        {
            DataTable table = subjectsTable.DataSource as DataTable;
            if (table == null) return;

            string text = txtSearch.Text.Trim();
            if (text == "")
            {
                table.DefaultView.RowFilter = "";
                return;
            }

            // escape characters that have a special meaning in a DataView filter
            string safe = text.Replace("[", "[[]").Replace("'", "''").Replace("%", "[%]").Replace("*", "[*]");
            table.DefaultView.RowFilter =
                "[Subject Name] LIKE '%" + safe + "%' OR [Category] LIKE '%" + safe + "%'";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplySearch();
        }

        private int? SelectedSubjectId()
        {
            if (subjectsTable.SelectedRows.Count == 0) return null;
            return Convert.ToInt32(subjectsTable.SelectedRows[0].Cells[0].Value);
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            using (var form = new SubjectEditForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    ReadSubjects();
            }
        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            int? subjectId = SelectedSubjectId();
            if (subjectId == null)
            {
                MessageBox.Show("Please select a subject first.");
                return;
            }

            Subject subject = subjectService.GetSubject(subjectId.Value);
            if (subject == null) { ReadSubjects(); return; }

            using (var form = new SubjectEditForm())
            {
                form.EditSubject(subject);
                if (form.ShowDialog(this) == DialogResult.OK)
                    ReadSubjects();
            }
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            int? subjectId = SelectedSubjectId();
            if (subjectId == null)
            {
                MessageBox.Show("Please select a subject first.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this subject?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No) return;

            subjectService.DeleteSubject(subjectId.Value);
            ReadSubjects();
        }
    }
}
