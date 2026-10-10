
namespace CareerLink.Grade12
{
    partial class UniversitiesForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlFooter;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblResults;

        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.DataGridView dgvUniversities;

        private System.Windows.Forms.DataGridViewTextBoxColumn colUniversityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUniversityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWebsite;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();

            this.txtSearch = new System.Windows.Forms.TextBox();

            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.dgvUniversities = new System.Windows.Forms.DataGridView();

            this.colUniversityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUniversityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlHeader.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlFooter.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvUniversities)).BeginInit();

            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor =
                System.Drawing.Color.DarkSlateGray;

            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);

            this.pnlHeader.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlHeader.Location =
                new System.Drawing.Point(0, 0);

            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size =
                new System.Drawing.Size(1050, 115);

            this.pnlHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    22F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor =
                System.Drawing.Color.White;

            this.lblTitle.Location =
                new System.Drawing.Point(30, 18);

            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Explore Universities";

            // lblSubtitle
            this.lblSubtitle.AutoSize = true;

            this.lblSubtitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.lblSubtitle.ForeColor =
                System.Drawing.Color.WhiteSmoke;

            this.lblSubtitle.Location =
                new System.Drawing.Point(35, 78);

            this.lblSubtitle.Name = "lblSubtitle";

            this.lblSubtitle.Text =
                "Discover South African universities and explore their available courses.";

            // pnlSearch
            this.pnlSearch.BackColor =
                System.Drawing.Color.White;

            this.pnlSearch.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.btnRefresh);

            this.pnlSearch.Location =
                new System.Drawing.Point(25, 140);

            this.pnlSearch.Name = "pnlSearch";

            this.pnlSearch.Size =
                new System.Drawing.Size(1000, 115);

            // lblSearch
            this.lblSearch.AutoSize = true;

            this.lblSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold);

            this.lblSearch.Location =
                new System.Drawing.Point(20, 15);

            this.lblSearch.Name = "lblSearch";

            this.lblSearch.Text =
                "Search Universities";

            // txtSearch
            this.txtSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F);

            this.txtSearch.Location =
                new System.Drawing.Point(20, 55);

            this.txtSearch.Name = "txtSearch";

            this.txtSearch.Size =
                new System.Drawing.Size(570, 32);

            this.txtSearch.TabIndex = 0;

            // btnSearch
            this.btnSearch.BackColor =
                System.Drawing.Color.DodgerBlue;

            this.btnSearch.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnSearch.FlatAppearance.BorderSize = 0;

            this.btnSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnSearch.ForeColor =
                System.Drawing.Color.White;

            this.btnSearch.Location =
                new System.Drawing.Point(615, 52);

            this.btnSearch.Name = "btnSearch";

            this.btnSearch.Size =
                new System.Drawing.Size(150, 40);

            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";

            this.btnSearch.UseVisualStyleBackColor = false;

            // btnRefresh
            this.btnRefresh.BackColor =
                System.Drawing.Color.MediumSeaGreen;

            this.btnRefresh.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnRefresh.FlatAppearance.BorderSize = 0;

            this.btnRefresh.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnRefresh.ForeColor =
                System.Drawing.Color.White;

            this.btnRefresh.Location =
                new System.Drawing.Point(785, 52);

            this.btnRefresh.Name = "btnRefresh";

            this.btnRefresh.Size =
                new System.Drawing.Size(175, 40);

            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";

            this.btnRefresh.UseVisualStyleBackColor = false;

            // lblResults
            this.lblResults.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.lblResults.ForeColor =
                System.Drawing.Color.DarkSlateGray;

            this.lblResults.Location =
                new System.Drawing.Point(25, 280);

            this.lblResults.Name = "lblResults";

            this.lblResults.Size =
                new System.Drawing.Size(800, 35);

            this.lblResults.Text =
                "Available Universities";

            // dgvUniversities
            this.dgvUniversities.AllowUserToAddRows = false;
            this.dgvUniversities.AllowUserToDeleteRows = false;
            this.dgvUniversities.AllowUserToResizeRows = false;

            this.dgvUniversities.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvUniversities.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvUniversities.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgvUniversities.ColumnHeadersHeight = 42;

            this.dgvUniversities.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvUniversities.EnableHeadersVisualStyles = false;

            this.dgvUniversities.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.DarkSlateGray;

            this.dgvUniversities.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;

            this.dgvUniversities.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.dgvUniversities.DefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.dgvUniversities.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.LightSteelBlue;

            this.dgvUniversities.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.Black;

            this.dgvUniversities.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.AliceBlue;

            this.dgvUniversities.RowTemplate.Height = 38;

            this.dgvUniversities.ReadOnly = true;
            this.dgvUniversities.MultiSelect = false;
            this.dgvUniversities.RowHeadersVisible = false;

            this.dgvUniversities.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvUniversities.Location =
                new System.Drawing.Point(25, 325);

            this.dgvUniversities.Name = "dgvUniversities";

            this.dgvUniversities.Size =
                new System.Drawing.Size(1000, 350);

            this.dgvUniversities.TabIndex = 3;

            this.dgvUniversities.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colUniversityId,
                    this.colUniversityName,
                    this.colProvince,
                    this.colCity,
                    this.colWebsite
                });

            // colUniversityId
            this.colUniversityId.Name = "colUniversityId";
            this.colUniversityId.HeaderText = "University ID";
            this.colUniversityId.DataPropertyName = "UniversityId";
            this.colUniversityId.Visible = false;

            // colUniversityName
            this.colUniversityName.Name = "colUniversityName";
            this.colUniversityName.HeaderText = "University Name";
            this.colUniversityName.DataPropertyName = "UniversityName";
            this.colUniversityName.FillWeight = 180F;

            // colProvince
            this.colProvince.Name = "colProvince";
            this.colProvince.HeaderText = "Province";
            this.colProvince.DataPropertyName = "Province";
            this.colProvince.FillWeight = 95F;

            // colCity
            this.colCity.Name = "colCity";
            this.colCity.HeaderText = "City";
            this.colCity.DataPropertyName = "City";
            this.colCity.FillWeight = 85F;

            // colWebsite
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.HeaderText = "Website";
            this.colWebsite.DataPropertyName = "Website";
            this.colWebsite.FillWeight = 145F;

            // pnlFooter
            this.pnlFooter.BackColor =
                System.Drawing.Color.White;

            this.pnlFooter.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlFooter.Controls.Add(this.btnViewCourses);
            this.pnlFooter.Controls.Add(this.btnBack);

            this.pnlFooter.Location =
                new System.Drawing.Point(25, 700);

            this.pnlFooter.Name = "pnlFooter";

            this.pnlFooter.Size =
                new System.Drawing.Size(1000, 85);

            // btnViewCourses
            this.btnViewCourses.BackColor =
                System.Drawing.Color.ForestGreen;

            this.btnViewCourses.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnViewCourses.FlatAppearance.BorderSize = 0;

            this.btnViewCourses.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnViewCourses.ForeColor =
                System.Drawing.Color.White;

            this.btnViewCourses.Location =
                new System.Drawing.Point(20, 20);

            this.btnViewCourses.Name = "btnViewCourses";

            this.btnViewCourses.Size =
                new System.Drawing.Size(250, 43);

            this.btnViewCourses.TabIndex = 4;

            this.btnViewCourses.Text =
                "View Selected University Courses";

            this.btnViewCourses.UseVisualStyleBackColor = false;

            // btnBack
            this.btnBack.BackColor =
                System.Drawing.Color.SlateGray;

            this.btnBack.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnBack.FlatAppearance.BorderSize = 0;

            this.btnBack.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnBack.ForeColor =
                System.Drawing.Color.White;

            this.btnBack.Location =
                new System.Drawing.Point(800, 20);

            this.btnBack.Name = "btnBack";

            this.btnBack.Size =
                new System.Drawing.Size(175, 43);

            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";

            this.btnBack.UseVisualStyleBackColor = false;

            // UniversitiesForm
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 20F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.ClientSize =
                new System.Drawing.Size(1050, 810);

            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.dgvUniversities);
            this.Controls.Add(this.pnlFooter);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Name = "UniversitiesForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text = "CareerLink - Explore Universities";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();

            this.pnlFooter.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvUniversities)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion
    }
}
