using System;
using System.Data;
using System.Windows.Forms;
using CareerLink.BusinessLogic;
using CareerLink.Models;

namespace CareerLink
{
    public partial class CareersForm : Form
    {
        private readonly CareerService careerService = new CareerService();

        public CareersForm()
        {
            InitializeComponent();
            ReadCareers();
        }

        private void ReadCareers()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Career ID", typeof(int));
            dataTable.Columns.Add("Keyword", typeof(string));
            dataTable.Columns.Add("Career", typeof(string));
            dataTable.Columns.Add("Subjects", typeof(string));

            foreach (Career career in careerService.GetAllCareers())
                dataTable.Rows.Add(career.CareerId, career.Keyword, career.CareerName,
                                   string.Join(", ", career.Subjects));

            this.careersTable.DataSource = dataTable;
        }

        private int? SelectedCareerId()
        {
            if (careersTable.SelectedRows.Count == 0) return null;
            return Convert.ToInt32(careersTable.SelectedRows[0].Cells[0].Value);
        }

        private void btnAddCareer_Click(object sender, EventArgs e)
        {
            using (var form = new CareerEditForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    ReadCareers();
            }
        }

        private void btnEditCareer_Click(object sender, EventArgs e)
        {
            int? careerId = SelectedCareerId();
            if (careerId == null)
            {
                MessageBox.Show("Please select a career first.");
                return;
            }

            Career career = careerService.GetCareer(careerId.Value);
            if (career == null) { ReadCareers(); return; }

            using (var form = new CareerEditForm())
            {
                form.EditCareer(career);
                if (form.ShowDialog(this) == DialogResult.OK)
                    ReadCareers();
            }
        }

        private void btnDeleteCareer_Click(object sender, EventArgs e)
        {
            int? careerId = SelectedCareerId();
            if (careerId == null)
            {
                MessageBox.Show("Please select a career first.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this career?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No) return;

            careerService.DeleteCareer(careerId.Value);
            ReadCareers();
        }
    }
}
