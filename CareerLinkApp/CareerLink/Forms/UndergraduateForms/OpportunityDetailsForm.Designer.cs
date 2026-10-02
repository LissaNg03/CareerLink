using System.Drawing;
using System.Windows.Forms;

namespace CareerLink
{
    partial class OpportunityDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblCompany;

        private Label lblType;
        private Label lblTypeValue;

        private Label lblLocation;
        private Label lblLocationValue;

        private Label lblDeadline;
        private Label lblDeadlineValue;

        private Label lblDescription;
        private TextBox txtDescription;

        private Label lblRequirements;
        private TextBox txtRequirements;

        private Button btnApply;
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
            lblCompany = new Label();

            lblType = new Label();
            lblTypeValue = new Label();

            lblLocation = new Label();
            lblLocationValue = new Label();

            lblDeadline = new Label();
            lblDeadlineValue = new Label();

            lblDescription = new Label();
            txtDescription = new TextBox();

            lblRequirements = new Label();
            txtRequirements = new TextBox();

            btnApply = new Button();
            btnClose = new Button();

            SuspendLayout();


            // ==========================================
            // TITLE
            // ==========================================

            lblTitle.AutoSize = true;

            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                22F,
                System.Drawing.FontStyle.Bold);

            lblTitle.Location =
                new Point(40, 30);

            lblTitle.MaximumSize =
                new Size(800, 0);

            lblTitle.Name = "lblTitle";

            lblTitle.Text =
                "Opportunity Title";


            // ==========================================
            // COMPANY
            // ==========================================

            lblCompany.AutoSize = true;

            lblCompany.Font = new System.Drawing.Font(
                "Segoe UI",
                13F);

            lblCompany.ForeColor =
                Color.DimGray;

            lblCompany.Location =
                new Point(43, 82);

            lblCompany.Name =
                "lblCompany";

            lblCompany.Text =
                "Company";


            // ==========================================
            // TYPE
            // ==========================================

            lblType.AutoSize = true;

            lblType.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold);

            lblType.Location =
                new Point(43, 135);

            lblType.Text =
                "Type:";


            lblTypeValue.AutoSize = true;

            lblTypeValue.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            lblTypeValue.Location =
                new Point(150, 135);

            lblTypeValue.Name =
                "lblTypeValue";

            lblTypeValue.Text =
                "Internship";


            // ==========================================
            // LOCATION
            // ==========================================

            lblLocation.AutoSize = true;

            lblLocation.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            lblLocation.Location =
                new Point(43, 170);

            lblLocation.Text =
                "Location:";


            lblLocationValue.AutoSize = true;

            lblLocationValue.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            lblLocationValue.Location =
                new Point(150, 170);

            lblLocationValue.Name =
                "lblLocationValue";

            lblLocationValue.Text =
                "Gqeberha";


            // ==========================================
            // DEADLINE
            // ==========================================

            lblDeadline.AutoSize = true;

            lblDeadline.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            lblDeadline.Location =
                new Point(43, 205);

            lblDeadline.Text =
                "Deadline:";


            lblDeadlineValue.AutoSize = true;

            lblDeadlineValue.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            lblDeadlineValue.Location =
                new Point(150, 205);

            lblDeadlineValue.Name =
                "lblDeadlineValue";

            lblDeadlineValue.Text =
                "No deadline";


            // ==========================================
            // DESCRIPTION
            // ==========================================

            lblDescription.AutoSize = true;

            lblDescription.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold);

            lblDescription.Location =
                new Point(43, 260);

            lblDescription.Text =
                "Description";


            txtDescription.Location =
                new Point(43, 290);

            txtDescription.Multiline =
                true;

            txtDescription.Name =
                "txtDescription";

            txtDescription.ReadOnly =
                true;

            txtDescription.ScrollBars =
                ScrollBars.Vertical;

            txtDescription.Size =
                new Size(800, 120);


            // ==========================================
            // REQUIREMENTS
            // ==========================================

            lblRequirements.AutoSize = true;

            lblRequirements.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold);

            lblRequirements.Location =
                new Point(43, 440);

            lblRequirements.Text =
                "Requirements";


            txtRequirements.Location =
                new Point(43, 470);

            txtRequirements.Multiline =
                true;

            txtRequirements.Name =
                "txtRequirements";

            txtRequirements.ReadOnly =
                true;

            txtRequirements.ScrollBars =
                ScrollBars.Vertical;

            txtRequirements.Size =
                new Size(800, 120);


            // ==========================================
            // APPLY
            // ==========================================

            btnApply.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            btnApply.Location =
                new Point(663, 625);

            btnApply.Name =
                "btnApply";

            btnApply.Size =
                new Size(180, 45);

            btnApply.Text =
                "Apply Now";

            btnApply.UseVisualStyleBackColor =
                true;

            btnApply.Click +=
                btnApply_Click;


            // ==========================================
            // CLOSE
            // ==========================================

            btnClose.Location =
                new Point(523, 625);

            btnClose.Name =
                "btnClose";

            btnClose.Size =
                new Size(120, 45);

            btnClose.Text =
                "Close";

            btnClose.UseVisualStyleBackColor =
                true;

            btnClose.Click +=
                btnClose_Click;


            // ==========================================
            // FORM
            // ==========================================

            AutoScaleDimensions =
                new SizeF(7F, 15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(890, 710);

            Controls.Add(lblTitle);
            Controls.Add(lblCompany);

            Controls.Add(lblType);
            Controls.Add(lblTypeValue);

            Controls.Add(lblLocation);
            Controls.Add(lblLocationValue);

            Controls.Add(lblDeadline);
            Controls.Add(lblDeadlineValue);

            Controls.Add(lblDescription);
            Controls.Add(txtDescription);

            Controls.Add(lblRequirements);
            Controls.Add(txtRequirements);

            Controls.Add(btnApply);
            Controls.Add(btnClose);

            FormBorderStyle =
                FormBorderStyle.FixedSingle;

            MaximizeBox = false;

            Name =
                "OpportunityDetailsForm";

            StartPosition =
                FormStartPosition.CenterParent;

            Text =
                "CareerLink - Opportunity Details";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}