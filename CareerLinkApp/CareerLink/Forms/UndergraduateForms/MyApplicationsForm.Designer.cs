using System.Drawing;
using System.Windows.Forms;

namespace CareerLink
{
    partial class MyApplicationsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblCount;

        private DataGridView dgvApplications;

        private DataGridViewTextBoxColumn colOpportunity;
        private DataGridViewTextBoxColumn colCompany;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colStatus;

        private Button btnClose;


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
            lblCount = new Label();

            dgvApplications = new DataGridView();

            colOpportunity =
                new DataGridViewTextBoxColumn();

            colCompany =
                new DataGridViewTextBoxColumn();

            colType =
                new DataGridViewTextBoxColumn();

            colDate =
                new DataGridViewTextBoxColumn();

            colStatus =
                new DataGridViewTextBoxColumn();

            btnClose = new Button();


            ((System.ComponentModel.ISupportInitialize)
                dgvApplications).BeginInit();

            SuspendLayout();


            // =========================================
            // TITLE
            // =========================================

            lblTitle.AutoSize = true;

            lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    22F,
                    System.Drawing.FontStyle.Bold);

            lblTitle.Location =
                new Point(35, 25);

            lblTitle.Name =
                "lblTitle";

            lblTitle.Text =
                "My Applications";


            // =========================================
            // SUBTITLE
            // =========================================

            lblSubtitle.AutoSize = true;

            lblSubtitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            lblSubtitle.ForeColor =
                Color.DimGray;

            lblSubtitle.Location =
                new Point(38, 75);

            lblSubtitle.Name =
                "lblSubtitle";

            lblSubtitle.Text =
                "Track the opportunities you have applied for.";


            // =========================================
            // COUNT
            // =========================================

            lblCount.AutoSize = true;

            lblCount.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            lblCount.Location =
                new Point(38, 125);

            lblCount.Name =
                "lblCount";

            lblCount.Text =
                "0 application(s)";


            // =========================================
            // DATAGRIDVIEW
            // =========================================

            dgvApplications.AllowUserToAddRows =
                false;

            dgvApplications.AllowUserToDeleteRows =
                false;

            dgvApplications.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvApplications.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode
                    .AutoSize;

            dgvApplications.Columns.AddRange(
                new DataGridViewColumn[]
                {
                    colOpportunity,
                    colCompany,
                    colType,
                    colDate,
                    colStatus
                });

            dgvApplications.Location =
                new Point(38, 165);

            dgvApplications.MultiSelect =
                false;

            dgvApplications.Name =
                "dgvApplications";

            dgvApplications.ReadOnly =
                true;

            dgvApplications.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvApplications.Size =
                new Size(900, 400);


            // Opportunity
            colOpportunity.HeaderText =
                "Opportunity";

            colOpportunity.Name =
                "colOpportunity";

            colOpportunity.ReadOnly =
                true;


            // Company
            colCompany.HeaderText =
                "Company";

            colCompany.Name =
                "colCompany";

            colCompany.ReadOnly =
                true;


            // Type
            colType.HeaderText =
                "Type";

            colType.Name =
                "colType";

            colType.ReadOnly =
                true;


            // Application Date
            colDate.HeaderText =
                "Applied On";

            colDate.Name =
                "colDate";

            colDate.ReadOnly =
                true;


            // Status
            colStatus.HeaderText =
                "Status";

            colStatus.Name =
                "colStatus";

            colStatus.ReadOnly =
                true;


            // =========================================
            // CLOSE
            // =========================================

            btnClose.Location =
                new Point(813, 595);

            btnClose.Name =
                "btnClose";

            btnClose.Size =
                new Size(125, 40);

            btnClose.Text =
                "Close";

            btnClose.UseVisualStyleBackColor =
                true;

            btnClose.Click +=
                btnClose_Click;


            // =========================================
            // FORM
            // =========================================

            AutoScaleDimensions =
                new SizeF(7F, 15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(980, 670);

            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(lblCount);
            Controls.Add(dgvApplications);
            Controls.Add(btnClose);

            FormBorderStyle =
                FormBorderStyle.FixedSingle;

            MaximizeBox =
                false;

            Name =
                "MyApplicationsForm";

            StartPosition =
                FormStartPosition.CenterParent;

            Text =
                "CareerLink - My Applications";


            ((System.ComponentModel.ISupportInitialize)
                dgvApplications).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}