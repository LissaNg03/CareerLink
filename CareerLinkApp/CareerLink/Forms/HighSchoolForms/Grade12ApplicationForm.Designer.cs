
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CareerLink.Forms.HighSchoolForms
{
    partial class Grade12ApplicationsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Panel pnlFooter;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblHint;

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbStatus;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.DataGridView dgvApplications;

        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUniversity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new System.Windows.Forms.Panel();
            pnlFilters = new System.Windows.Forms.Panel();
            pnlFooter = new System.Windows.Forms.Panel();

            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblSearch = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            lblResults = new System.Windows.Forms.Label();
            lblHint = new System.Windows.Forms.Label();

            txtSearch = new System.Windows.Forms.TextBox();
            cmbStatus = new System.Windows.Forms.ComboBox();

            btnSearch = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();

            dgvApplications = new System.Windows.Forms.DataGridView();

            colApplicationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colUniversity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();

            pnlHeader.SuspendLayout();
            pnlFilters.SuspendLayout();
            pnlFooter.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)dgvApplications).BeginInit();

            SuspendLayout();

            // HEADER
            pnlHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Size = new System.Drawing.Size(1050, 115);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(25, 15);
            lblTitle.Text = "My Course Applications";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblSubtitle.Location = new System.Drawing.Point(30, 75);
            lblSubtitle.Text = "Track your university course applications.";

            // FILTER PANEL
            pnlFilters.BackColor = System.Drawing.Color.White;
            pnlFilters.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            pnlFilters.Location = new System.Drawing.Point(25, 135);
            pnlFilters.Size = new System.Drawing.Size(1000, 115);

            pnlFilters.Controls.Add(lblSearch);
            pnlFilters.Controls.Add(txtSearch);
            pnlFilters.Controls.Add(lblStatus);
            pnlFilters.Controls.Add(cmbStatus);
            pnlFilters.Controls.Add(btnSearch);
            pnlFilters.Controls.Add(btnRefresh);

            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblSearch.Location = new System.Drawing.Point(20, 12);
            lblSearch.Text = "Search University or Course";

            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSearch.Location = new System.Drawing.Point(20, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(340, 30);

            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblStatus.Location = new System.Drawing.Point(380, 12);
            lblStatus.Text = "Application Status";

            cmbStatus.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbStatus.Location = new System.Drawing.Point(380, 52);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new System.Drawing.Size(200, 31);
            cmbStatus.Items.AddRange(new object[]
            {
                "All Statuses",
                "Pending",
                "Accepted",
                "Rejected",
                "Under Review"
            });
            cmbStatus.SelectedIndex = 0;

            btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(610, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(160, 40);
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;

            btnRefresh.BackColor = System.Drawing.Color.MediumSeaGreen;
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.Location = new System.Drawing.Point(790, 48);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(180, 40);
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;

            // RESULTS
            lblResults.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblResults.ForeColor = System.Drawing.Color.DarkSlateGray;
            lblResults.Location = new System.Drawing.Point(25, 270);
            lblResults.Size = new System.Drawing.Size(900, 35);
            lblResults.Text = "My Applications (0)";

            // GRID
            dgvApplications.AllowUserToAddRows = false;
            dgvApplications.AllowUserToDeleteRows = false;
            dgvApplications.AutoGenerateColumns = false;
            dgvApplications.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvApplications.BackgroundColor = System.Drawing.Color.White;
            dgvApplications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvApplications.ColumnHeadersHeight = 42;
            dgvApplications.EnableHeadersVisualStyles = false;
            dgvApplications.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.DarkSlateGray;
            dgvApplications.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;
            dgvApplications.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.AliceBlue;
            dgvApplications.Location = new System.Drawing.Point(25, 315);
            dgvApplications.Name = "dgvApplications";
            dgvApplications.ReadOnly = true;
            dgvApplications.MultiSelect = false;
            dgvApplications.RowHeadersVisible = false;
            dgvApplications.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvApplications.Size = new System.Drawing.Size(1000, 355);

            dgvApplications.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    colApplicationId,
                    colUniversity,
                    colCourse,
                    colStatus,
                    colDate
                });

            colApplicationId.Name = "colApplicationId";
            colApplicationId.DataPropertyName = "ApplicationId";
            colApplicationId.HeaderText = "Application ID";
            colApplicationId.FillWeight = 85F;

            colUniversity.Name = "colUniversity";
            colUniversity.DataPropertyName = "UniversityName";
            colUniversity.HeaderText = "University";
            colUniversity.FillWeight = 170F;

            colCourse.Name = "colCourse";
            colCourse.DataPropertyName = "CourseName";
            colCourse.HeaderText = "Course";
            colCourse.FillWeight = 200F;

            colStatus.Name = "colStatus";
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.FillWeight = 100F;

            colDate.Name = "colDate";
            colDate.DataPropertyName = "ApplicationDate";
            colDate.HeaderText = "Date Applied";
            colDate.DefaultCellStyle.Format = "dd MMM yyyy";
            colDate.FillWeight = 110F;

            // HINT
            lblHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblHint.ForeColor = System.Drawing.Color.DimGray;
            lblHint.Location = new System.Drawing.Point(25, 685);
            lblHint.Size = new System.Drawing.Size(950, 35);
            lblHint.Text =
                "Application statuses are updated within CareerLink.";

            // FOOTER
            pnlFooter.BackColor = System.Drawing.Color.White;
            pnlFooter.Location = new System.Drawing.Point(25, 730);
            pnlFooter.Size = new System.Drawing.Size(1000, 70);
            pnlFooter.Controls.Add(btnBack);

            btnBack.BackColor = System.Drawing.Color.SlateGray;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.Location = new System.Drawing.Point(805, 14);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(170, 42);
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;

            // FORM
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            ClientSize = new System.Drawing.Size(1050, 825);
            Controls.Add(pnlHeader);
            Controls.Add(pnlFilters);
            Controls.Add(lblResults);
            Controls.Add(dgvApplications);
            Controls.Add(lblHint);
            Controls.Add(pnlFooter);

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Name = "Grade12ApplicationsForm";
            Text = "CareerLink - My Applications";

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvApplications).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
