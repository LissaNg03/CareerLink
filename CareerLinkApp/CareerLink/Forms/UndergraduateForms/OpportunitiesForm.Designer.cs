using System.Drawing;
using System.Windows.Forms;

namespace CareerLink
{
    partial class OpportunitiesForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblSubtitle;
        private TextBox txtSearch;
        private Label lblSearch;
        private ComboBox cmbType;
        private Label lblType;
        private DataGridView dgvOpportunities;
        private Button btnClose;

        private DataGridViewTextBoxColumn colOpportunityId;
        private DataGridViewTextBoxColumn colCompany;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colDeadline;


        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            cmbType = new ComboBox();
            lblType = new Label();
            dgvOpportunities = new DataGridView();
            btnClose = new Button();

            colOpportunityId = new DataGridViewTextBoxColumn();
            colCompany = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colDeadline = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)dgvOpportunities)
                .BeginInit();

            SuspendLayout();


            // =====================================================
            // lblTitle
            // =====================================================

            lblTitle.AutoSize = true;

            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                22F,
                System.Drawing.FontStyle.Bold);

            lblTitle.Location = new Point(35, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(217, 41);
            lblTitle.Text = "Opportunities";


            // =====================================================
            // lblSubtitle
            // =====================================================

            lblSubtitle.AutoSize = true;

            lblSubtitle.Font = new System.Drawing.Font(
                "Segoe UI",
                10F);

            lblSubtitle.ForeColor = Color.DimGray;

            lblSubtitle.Location = new Point(38, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(350, 19);

            lblSubtitle.Text =
                "Opportunities recommended for your course.";


            // =====================================================
            // lblSearch
            // =====================================================

            lblSearch.AutoSize = true;

            lblSearch.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold);

            lblSearch.Location = new Point(38, 120);
            lblSearch.Name = "lblSearch";
            lblSearch.Text = "Search";


            // =====================================================
            // txtSearch
            // =====================================================

            txtSearch.Font = new System.Drawing.Font(
                "Segoe UI",
                10F);

            txtSearch.Location = new Point(38, 145);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(390, 25);

            txtSearch.TextChanged +=
                txtSearch_TextChanged;


            // =====================================================
            // lblType
            // =====================================================

            lblType.AutoSize = true;

            lblType.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold);

            lblType.Location = new Point(455, 120);
            lblType.Name = "lblType";
            lblType.Text = "Opportunity Type";


            // =====================================================
            // cmbType
            // =====================================================

            cmbType.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbType.Font = new System.Drawing.Font(
                "Segoe UI",
                10F);

            cmbType.Location = new Point(455, 145);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(250, 25);

            cmbType.SelectedIndexChanged +=
                cmbType_SelectedIndexChanged;


            // =====================================================
            // dgvOpportunities
            // =====================================================

            dgvOpportunities.AllowUserToAddRows = false;
            dgvOpportunities.AllowUserToDeleteRows = false;

            dgvOpportunities.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvOpportunities.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvOpportunities.Columns.AddRange(
                new DataGridViewColumn[]
                {
                    colOpportunityId,
                    colCompany,
                    colTitle,
                    colType,
                    colLocation,
                    colDeadline
                });

            dgvOpportunities.Location =
                new Point(38, 205);

            dgvOpportunities.MultiSelect = false;
            dgvOpportunities.Name = "dgvOpportunities";

            dgvOpportunities.ReadOnly = true;

            dgvOpportunities.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvOpportunities.Size =
                new Size(900, 390);

            dgvOpportunities.CellDoubleClick +=
                dgvOpportunities_CellDoubleClick;


            // =====================================================
            // colOpportunityId
            // =====================================================

            colOpportunityId.HeaderText = "ID";
            colOpportunityId.Name = "colOpportunityId";
            colOpportunityId.ReadOnly = true;

            // We need the ID internally,
            // but the user should not see it.
            colOpportunityId.Visible = false;


            // =====================================================
            // colCompany
            // =====================================================

            colCompany.HeaderText = "Company";
            colCompany.Name = "colCompany";
            colCompany.ReadOnly = true;


            // =====================================================
            // colTitle
            // =====================================================

            colTitle.HeaderText = "Opportunity";
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;


            // =====================================================
            // colType
            // =====================================================

            colType.HeaderText = "Type";
            colType.Name = "colType";
            colType.ReadOnly = true;


            // =====================================================
            // colLocation
            // =====================================================

            colLocation.HeaderText = "Location";
            colLocation.Name = "colLocation";
            colLocation.ReadOnly = true;


            // =====================================================
            // colDeadline
            // =====================================================

            colDeadline.HeaderText = "Deadline";
            colDeadline.Name = "colDeadline";
            colDeadline.ReadOnly = true;


            // =====================================================
            // btnClose
            // =====================================================

            btnClose.Location =
                new Point(813, 620);

            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 40);
            btnClose.Text = "Close";

            btnClose.UseVisualStyleBackColor = true;

            btnClose.Click +=
                btnClose_Click;


            // =====================================================
            // OpportunitiesForm
            // =====================================================

            AutoScaleDimensions =
                new SizeF(7F, 15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(980, 690);

            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblType);
            Controls.Add(cmbType);
            Controls.Add(dgvOpportunities);
            Controls.Add(btnClose);

            Name = "OpportunitiesForm";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "CareerLink - Opportunities";

            ((System.ComponentModel.ISupportInitialize)dgvOpportunities)
                .EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}