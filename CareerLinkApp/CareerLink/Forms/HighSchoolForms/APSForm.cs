
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CareerLink.Forms.HighSchoolForms
{
    public partial class APSForm : Form
    {
        private readonly string connectionString =
            @"Server=.\SQLEXPRESS;Database=CareerLink;Integrated Security=True;TrustServerCertificate=True;";

        private readonly ComboBox[] subjectBoxes = new ComboBox[7];
        private readonly TextBox[] markBoxes = new TextBox[7];

        public int CalculatedAPS { get; private set; }

        public APSForm()
        {
            InitializeComponent();

            SetupSubjectInputs();

            // Connect the EXISTING Designer button.
            btnCalculate.Click += CalculateAPS;

            LoadSubjects();
        }

        private void SetupSubjectInputs()
        {
            // Remove the old hardcoded subject controls.
            Control[] oldControls =
            {
                lblEnglish, txtEnglish,
                lblMaths, txtMaths,
                lblPhysicalScience, txtPhysicalScience,
                lblLifeScience, txtLifeScience,
                lblSubject5, txtSubject5,
                lblSubject6, txtSubject6,
                lblSubject7, txtSubject7
            };

            foreach (Control control in oldControls)
            {
                pnlCard.Controls.Remove(control);
                control.Dispose();
            }

            lblSubtitle.Text =
                "Choose your seven subjects and enter your marks (0-100).";

            for (int i = 0; i < 7; i++)
            {
                int y = 22 + (i * 44);

                Label numberLabel = new Label
                {
                    Text = $"{i + 1}.",
                    Location = new Point(15, y + 4),
                    Size = new Size(30, 26),
                    Font = new Font("Segoe UI", 10)
                };

                ComboBox subjectBox = new ComboBox
                {
                    Name = $"cmbSubject{i + 1}",
                    Location = new Point(45, y),
                    Size = new Size(280, 30),
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Font = new Font("Segoe UI", 10)
                };

                TextBox markBox = new TextBox
                {
                    Name = $"txtMark{i + 1}",
                    Location = new Point(340, y),
                    Size = new Size(105, 28),
                    MaxLength = 3,
                    TextAlign = HorizontalAlignment.Center,
                    Font = new Font("Segoe UI", 10)
                };

                markBox.KeyPress += (sender, e) =>
                {
                    if (!char.IsControl(e.KeyChar) &&
                        !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                };

                subjectBoxes[i] = subjectBox;
                markBoxes[i] = markBox;

                pnlCard.Controls.Add(numberLabel);
                pnlCard.Controls.Add(subjectBox);
                pnlCard.Controls.Add(markBox);
            }

            lblAPSResult.Text = "Your APS Score: -";
        }

        private void LoadSubjects()
        {
            try
            {
                List<SubjectOption> subjects =
                    new List<SubjectOption>();

                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    @"SELECT SubjectId, SubjectName
                      FROM dbo.Subjects
                      ORDER BY SubjectName",
                    connection))
                {
                    connection.Open();

                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjects.Add(new SubjectOption
                            {
                                SubjectId = reader.GetInt32(0),
                                SubjectName = reader.GetString(1)
                            });
                        }
                    }
                }

                if (subjects.Count < 7)
                {
                    btnCalculate.Enabled = false;

                    MessageBox.Show(
                        "Your database must contain at least 7 subjects.",
                        "CareerLink",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                foreach (ComboBox combo in subjectBoxes)
                {
                    combo.DataSource =
                        new List<SubjectOption>(subjects);

                    combo.DisplayMember = "SubjectName";
                    combo.ValueMember = "SubjectId";
                    combo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                btnCalculate.Enabled = false;

                MessageBox.Show(
                    "Could not load subjects:\n\n" + ex.Message,
                    "CareerLink",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int GetAPS(int mark)
        {
            if (mark >= 90) return 8;
            if (mark >= 80) return 7;
            if (mark >= 70) return 6;
            if (mark >= 60) return 5;
            if (mark >= 50) return 4;
            if (mark >= 40) return 3;
            if (mark >= 30) return 2;

            return 0;
        }

        private void CalculateAPS(object sender, EventArgs e)
        {
            int total = 0;

            HashSet<int> selectedSubjects =
                new HashSet<int>();

            for (int i = 0; i < 7; i++)
            {
                if (!(subjectBoxes[i].SelectedItem
                    is SubjectOption subject))
                {
                    MessageBox.Show(
                        $"Please choose subject {i + 1}.",
                        "Missing Subject",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    subjectBoxes[i].Focus();
                    return;
                }

                if (!selectedSubjects.Add(subject.SubjectId))
                {
                    MessageBox.Show(
                        "You cannot select the same subject twice.",
                        "Duplicate Subject",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    subjectBoxes[i].Focus();
                    return;
                }

                if (!int.TryParse(
                    markBoxes[i].Text.Trim(),
                    out int mark) ||
                    mark < 0 || mark > 100)
                {
                    MessageBox.Show(
                        $"Enter a valid mark between 0 and 100 for subject {i + 1}.",
                        "Invalid Mark",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    markBoxes[i].Focus();
                    return;
                }

                total += GetAPS(mark);
            }

            CalculatedAPS = total;

            lblAPSResult.Text =
                $"Your APS Score: {CalculatedAPS}";
        }

        private class SubjectOption
        {
            public int SubjectId { get; set; }

            public string SubjectName { get; set; } = "";

            public override string ToString()
            {
                return SubjectName;
            }
        }
    }
}
