
namespace CareerLink.Forms.HighSchoolForms
{
    partial class AvailableCoursesForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Panel pnlFooter;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblHint;

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbQualification;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.DataGridView dgvCourses;

        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUniversity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinimumAPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing && components != null)
                components.Dispose();

            base.Dispose(isDisposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUniversity = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblQualification = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();

            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbQualification = new System.Windows.Forms.ComboBox();

            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.dgvCourses = new System.Windows.Forms.DataGridView();

            this.colCourseId =
                new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseName =
                new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUniversity =
                new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQualification =
                new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinimumAPS =
                new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration =
                new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlHeader.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlFooter.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                this.dgvCourses).BeginInit();

            this.SuspendLayout();

            // HEADER PANEL
            this.pnlHeader.BackColor =
                System.Drawing.Color.DarkSlateGray;
            this.pnlHeader.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location =
                new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size =
                new System.Drawing.Size(1100, 125);

            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblUniversity);

            // TITLE
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 23F,
                System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor =
                System.Drawing.Color.White;
            this.lblTitle.Location =
                new System.Drawing.Point(30, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Available Courses";

            // UNIVERSITY LABEL
            this.lblUniversity.Font =
                new System.Drawing.Font("Segoe UI", 11F);
            this.lblUniversity.ForeColor =
                System.Drawing.Color.LightGreen;
            this.lblUniversity.Location =
                new System.Drawing.Point(35, 83);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size =
                new System.Drawing.Size(1000, 28);
            this.lblUniversity.Text = "All Universities";

            // FILTER PANEL
            this.pnlFilters.BackColor =
                System.Drawing.Color.White;
            this.pnlFilters.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Location =
                new System.Drawing.Point(25, 145);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size =
                new System.Drawing.Size(1050, 125);

            this.pnlFilters.Controls.Add(this.lblSearch);
            this.pnlFilters.Controls.Add(this.txtSearch);
            this.pnlFilters.Controls.Add(this.lblQualification);
            this.pnlFilters.Controls.Add(this.cmbQualification);
            this.pnlFilters.Controls.Add(this.btnSearch);
            this.pnlFilters.Controls.Add(this.btnRefresh);

            // SEARCH LABEL
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font(
                "Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            this.lblSearch.Location =
                new System.Drawing.Point(20, 16);
            this.lblSearch.Text = "Search Course";

            // SEARCH TEXTBOX
            this.txtSearch.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location =
                new System.Drawing.Point(20, 59);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size =
                new System.Drawing.Size(360, 30);
            this.txtSearch.TabIndex = 0;

            // QUALIFICATION LABEL
            this.lblQualification.AutoSize = true;
            this.lblQualification.Font =
                new System.Drawing.Font(
                    "Segoe UI", 10F,
                    System.Drawing.FontStyle.Bold);
            this.lblQualification.Location =
                new System.Drawing.Point(400, 16);
            this.lblQualification.Text = "Qualification Type";

            // QUALIFICATION COMBOBOX
            this.cmbQualification.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQualification.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.cmbQualification.Location =
                new System.Drawing.Point(400, 59);
            this.cmbQualification.Name = "cmbQualification";
            this.cmbQualification.Size =
                new System.Drawing.Size(230, 31);
            this.cmbQualification.TabIndex = 1;

            this.cmbQualification.Items.AddRange(
                new object[]
                {
                    "All Qualifications",
                    "Bachelor's Degree",
                    "Diploma",
                    "Higher Certificate"
                });

            this.cmbQualification.SelectedIndex = 0;

            // SEARCH BUTTON
            this.btnSearch.BackColor =
                System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI", 10F,
                    System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor =
                System.Drawing.Color.White;
            this.btnSearch.Location =
                new System.Drawing.Point(660, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size =
                new System.Drawing.Size(160, 42);
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;

            // REFRESH BUTTON
            this.btnRefresh.BackColor =
                System.Drawing.Color.MediumSeaGreen;
            this.btnRefresh.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font =
                new System.Drawing.Font(
                    "Segoe UI", 10F,
                    System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor =
                System.Drawing.Color.White;
            this.btnRefresh.Location =
                new System.Drawing.Point(840, 54);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size =
                new System.Drawing.Size(175, 42);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;

            // RESULTS LABEL
            this.lblResults.Font =
                new System.Drawing.Font(
                    "Segoe UI", 12F,
                    System.Drawing.FontStyle.Bold);
            this.lblResults.ForeColor =
                System.Drawing.Color.DarkSlateGray;
            this.lblResults.Location =
                new System.Drawing.Point(25, 290);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size =
                new System.Drawing.Size(850, 35);
            this.lblResults.Text = "Available Courses";

            // COURSES DATAGRIDVIEW
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AllowUserToResizeRows = false;
            this.dgvCourses.AutoGenerateColumns = false;
            this.dgvCourses.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.BackgroundColor =
                System.Drawing.Color.White;
            this.dgvCourses.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.dgvCourses.ColumnHeadersHeight = 42;
            this.dgvCourses.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCourses.EnableHeadersVisualStyles = false;

            this.dgvCourses.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.DarkSlateGray;
            this.dgvCourses.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;
            this.dgvCourses.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI", 10F,
                    System.Drawing.FontStyle.Bold);

            this.dgvCourses.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.dgvCourses.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.LightSteelBlue;
            this.dgvCourses.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.Black;

            this.dgvCourses.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.AliceBlue;

            this.dgvCourses.RowTemplate.Height = 38;
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Location =
                new System.Drawing.Point(25, 335);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.Size =
                new System.Drawing.Size(1050, 345);
            this.dgvCourses.TabIndex = 2;

            this.dgvCourses.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colCourseId,
                    this.colCourseName,
                    this.colUniversity,
                    this.colQualification,
                    this.colMinimumAPS,
                    this.colDuration,
                    this.colStatus
                });

            // COURSE ID
            this.colCourseId.Name = "colCourseId";
            this.colCourseId.HeaderText = "Course ID";
            this.colCourseId.DataPropertyName = "UniversityCourseId";
            this.colCourseId.Visible = false;

            // COURSE NAME
            this.colCourseName.Name = "colCourseName";
            this.colCourseName.HeaderText = "Course";
            this.colCourseName.DataPropertyName = "CourseName";
            this.colCourseName.FillWeight = 200F;

            // UNIVERSITY
            this.colUniversity.Name = "colUniversity";
            this.colUniversity.HeaderText = "University";
            this.colUniversity.DataPropertyName = "UniversityName";
            this.colUniversity.FillWeight = 170F;

            // QUALIFICATION
            this.colQualification.Name = "colQualification";
            this.colQualification.HeaderText = "Qualification";
            this.colQualification.DataPropertyName = "QualificationType";
            this.colQualification.FillWeight = 125F;

            // MINIMUM APS
            this.colMinimumAPS.Name = "colMinimumAPS";
            this.colMinimumAPS.HeaderText = "Min APS";
            this.colMinimumAPS.DataPropertyName = "MinimumAPS";
            this.colMinimumAPS.FillWeight = 70F;

            // DURATION
            this.colDuration.Name = "colDuration";
            this.colDuration.HeaderText = "Duration";
            this.colDuration.DataPropertyName = "DurationYears";
            this.colDuration.FillWeight = 75F;

            // STATUS
            this.colStatus.Name = "colStatus";
            this.colStatus.HeaderText = "Status";
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.FillWeight = 85F;

            // HINT
            this.lblHint.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            this.lblHint.ForeColor =
                System.Drawing.Color.DimGray;
            this.lblHint.Location =
                new System.Drawing.Point(25, 690);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size =
                new System.Drawing.Size(1000, 30);
            this.lblHint.Text =
                "Select a course and click Apply. APS requirements may vary by university.";

            // FOOTER PANEL
            this.pnlFooter.BackColor =
                System.Drawing.Color.White;
            this.pnlFooter.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Location =
                new System.Drawing.Point(25, 730);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size =
                new System.Drawing.Size(1050, 85);

            this.pnlFooter.Controls.Add(this.btnApply);
            this.pnlFooter.Controls.Add(this.btnBack);

            // APPLY BUTTON
            this.btnApply.BackColor =
                System.Drawing.Color.ForestGreen;
            this.btnApply.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.Font =
                new System.Drawing.Font(
                    "Segoe UI", 10F,
                    System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor =
                System.Drawing.Color.White;
            this.btnApply.Location =
                new System.Drawing.Point(20, 20);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size =
                new System.Drawing.Size(260, 43);
            this.btnApply.Text = "Apply for Selected Course";
            this.btnApply.UseVisualStyleBackColor = false;

            // BACK BUTTON
            this.btnBack.BackColor =
                System.Drawing.Color.SlateGray;
            this.btnBack.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font =
                new System.Drawing.Font(
                    "Segoe UI", 10F,
                    System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor =
                System.Drawing.Color.White;
            this.btnBack.Location =
                new System.Drawing.Point(850, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size =
                new System.Drawing.Size(175, 43);
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;

            // FORM
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize =
                new System.Drawing.Size(1100, 840);

            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.pnlFooter);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AvailableCoursesForm";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CareerLink - Available Courses";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlFooter.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                this.dgvCourses).EndInit();

            this.ResumeLayout(false);
        }

        #endregion
    }
}
