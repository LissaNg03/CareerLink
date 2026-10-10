
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace CareerLink.Forms.HighSchoolForms
{
    public  class CareerRecommendationsForm : Form
    {
        private readonly string connectionString =
            @"Server=.\SQLEXPRESS;Database=CareerLink;Integrated Security=True;TrustServerCertificate=True;";

        private readonly ComboBox[] subjectBoxes = new ComboBox[7];
        private readonly NumericUpDown[] markBoxes = new NumericUpDown[7];

        private readonly DataGridView dgvRecommendations =
            new DataGridView();

        private readonly Label lblResults = new Label();

        public CareerRecommendationsForm()
        {
            BuildInterface();
            LoadSubjects();
        }

        private void BuildInterface()
        {
            Controls.Clear();

            Text = "CareerLink - Career Recommendations";
            ClientSize = new Size(960, 730);
            MinimumSize = new Size(850, 650);
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.FromArgb(241, 245, 249);

            var header = new Label
            {
                Text = "Career Recommendations",
                Dock = DockStyle.Top,
                Height = 70,
                BackColor = Color.FromArgb(15, 23, 42),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Controls.Add(header);

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20),
                ColumnCount = 1,
                RowCount = 4
            };

            layout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 40));
            layout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 330));
            layout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 45));
            layout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100));

            Controls.Add(layout);
            layout.BringToFront();
            header.BringToFront();

            var instructions = new Label
            {
                Text = "Select your 7 subjects and enter your marks.",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.FromArgb(51, 65, 85),
                TextAlign = ContentAlignment.MiddleLeft
            };

            layout.Controls.Add(instructions, 0, 0);

            var inputs = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(15),
                ColumnCount = 3,
                RowCount = 8
            };

            inputs.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 80));
            inputs.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100));
            inputs.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 120));

            for (int i = 0; i < 8; i++)
                inputs.RowStyles.Add(
                    new RowStyle(SizeType.Percent, 12.5f));

            inputs.Controls.Add(
                new Label { Text = "No.", AutoSize = true }, 0, 0);
            inputs.Controls.Add(
                new Label { Text = "Subject", AutoSize = true }, 1, 0);
            inputs.Controls.Add(
                new Label { Text = "Mark (%)", AutoSize = true }, 2, 0);

            for (int i = 0; i < 7; i++)
            {
                var label = new Label
                {
                    Text = (i + 1).ToString(),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                var subject = new ComboBox
                {
                    Dock = DockStyle.Fill,
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Font = new Font("Segoe UI", 10)
                };

                var mark = new NumericUpDown
                {
                    Dock = DockStyle.Fill,
                    Minimum = 0,
                    Maximum = 100,
                    Value = 0,
                    Font = new Font("Segoe UI", 10)
                };

                subjectBoxes[i] = subject;
                markBoxes[i] = mark;

                inputs.Controls.Add(label, 0, i + 1);
                inputs.Controls.Add(subject, 1, i + 1);
                inputs.Controls.Add(mark, 2, i + 1);
            }

            layout.Controls.Add(inputs, 0, 1);

            var btnRecommend = new Button
            {
                Text = "Find Recommended Careers",
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(37, 99, 235),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11, FontStyle.Bold)
            };

            btnRecommend.Click += BtnRecommend_Click;
            layout.Controls.Add(btnRecommend, 0, 2);

            var resultsPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(10)
            };

            lblResults.Text = "Your career matches will appear here.";
            lblResults.Dock = DockStyle.Top;
            lblResults.Height = 32;
            lblResults.Font = new Font(
                "Segoe UI", 10, FontStyle.Bold);

            dgvRecommendations.Dock = DockStyle.Fill;
            dgvRecommendations.ReadOnly = true;
            dgvRecommendations.AllowUserToAddRows = false;
            dgvRecommendations.AllowUserToDeleteRows = false;
            dgvRecommendations.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecommendations.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvRecommendations.MultiSelect = false;
            dgvRecommendations.RowHeadersVisible = false;
            dgvRecommendations.BackgroundColor = Color.White;
            dgvRecommendations.AutoGenerateColumns = true;

            resultsPanel.Controls.Add(dgvRecommendations);
            resultsPanel.Controls.Add(lblResults);
            layout.Controls.Add(resultsPanel, 0, 3);
        }

        private void LoadSubjects()
        {
            try
            {
                var subjects = new List<SubjectOption>();

                using (var connection =
                    new SqlConnection(connectionString))
                using (var command = new SqlCommand(
                    @"SELECT SubjectId, SubjectName
                      FROM dbo.Subjects
                      ORDER BY SubjectName", connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjects.Add(new SubjectOption
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                        }
                    }
                }

                if (subjects.Count < 7)
                {
                    MessageBox.Show(
                        "At least 7 subjects are required in the database.");
                    return;
                }

                foreach (var combo in subjectBoxes)
                {
                    combo.DataSource =
                        new List<SubjectOption>(subjects);
                    combo.DisplayMember = "Name";
                    combo.ValueMember = "Id";
                    combo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load subjects:\n" + ex.Message);
            }
        }

        private void BtnRecommend_Click(object sender, EventArgs e)
        {
            var selected = new Dictionary<string, int>(
                StringComparer.OrdinalIgnoreCase);

            var selectedIds = new HashSet<int>();

            for (int i = 0; i < 7; i++)
            {
                if (subjectBoxes[i].SelectedItem
                    is not SubjectOption subject)
                {
                    MessageBox.Show(
                        $"Please choose subject {i + 1}.");
                    return;
                }

                if (!selectedIds.Add(subject.Id))
                {
                    MessageBox.Show(
                        "Please choose 7 different subjects.");
                    return;
                }

                selected[subject.Name.Trim()] =
                    (int)markBoxes[i].Value;
            }

            FindRecommendations(selected);
        }

        private void FindRecommendations(
            Dictionary<string, int> marks)
        {
            try
            {
                var careers = new Dictionary<int, CareerOption>();

                using (var connection =
                    new SqlConnection(connectionString))
                using (var command = new SqlCommand(
                    @"SELECT c.CareerId,
                             c.CareerName,
                             cs.SubjectName
                      FROM dbo.Careers c
                      LEFT JOIN dbo.CareerSubjects cs
                          ON c.CareerId = cs.CareerId
                      ORDER BY c.CareerName",
                    connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);

                            if (!careers.TryGetValue(
                                id, out CareerOption career))
                            {
                                career = new CareerOption
                                {
                                    Id = id,
                                    Name = reader.GetString(1)
                                };

                                careers.Add(id, career);
                            }

                            if (!reader.IsDBNull(2))
                            {
                                career.Subjects.Add(
                                    reader.GetString(2).Trim());
                            }
                        }
                    }
                }

                var results = new List<RecommendationResult>();

                foreach (var career in careers.Values)
                {
                    if (career.Subjects.Count == 0)
                        continue;

                    var matches = career.Subjects
                        .Where(s => marks.ContainsKey(s))
                        .Distinct(StringComparer.OrdinalIgnoreCase)
                        .ToList();

                    if (matches.Count == 0)
                        continue;

                    double coverage =
                        (double)matches.Count /
                        career.Subjects.Distinct(
                            StringComparer.OrdinalIgnoreCase).Count();

                    double averageMark =
                        matches.Average(s => marks[s]);

                    // Demonstration ranking formula:
                    // 70% subject coverage + 30% marks.
                    double score =
                        coverage * 70 + averageMark * 0.30;

                    results.Add(new RecommendationResult
                    {
                        Career = career.Name,
                        MatchScore = Math.Round(score, 1),
                        MatchingSubjects =
                            string.Join(", ", matches),
                        MatchedRequirements =
                            $"{matches.Count}/{career.Subjects.Count}"
                    });
                }

                var ranked = results
                    .OrderByDescending(r => r.MatchScore)
                    .ThenBy(r => r.Career)
                    .ToList();

                dgvRecommendations.DataSource = null;
                dgvRecommendations.DataSource = ranked;

                if (ranked.Count == 0)
                {
                    lblResults.Text =
                        "No matching careers found. Check career subject mappings.";
                }
                else
                {
                    lblResults.Text =
                        $"{ranked.Count} career matches found - ranked by match score.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not generate recommendations:\n\n" +
                    ex.Message,
                    "CareerLink",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private class SubjectOption
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
        }

        private class CareerOption
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
            public List<string> Subjects { get; set; } =
                new List<string>();
        }

        private class RecommendationResult
        {
            public string Career { get; set; } = "";
            public double MatchScore { get; set; }
            public string MatchedRequirements { get; set; } = "";
            public string MatchingSubjects { get; set; } = "";
        }
    }
}
