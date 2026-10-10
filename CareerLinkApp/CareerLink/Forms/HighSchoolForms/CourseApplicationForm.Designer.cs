
namespace CareerLink.Forms.HighSchoolForms
{
    partial class CourseApplicationForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlFooter;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUniversityTitle;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblQualificationTitle;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Label lblAPSTitle;
        private System.Windows.Forms.Label lblAPS;
        private System.Windows.Forms.Label lblDurationTitle;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblNotice;

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;

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
            pnlDetails = new System.Windows.Forms.Panel();
            pnlFooter = new System.Windows.Forms.Panel();

            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblUniversityTitle = new System.Windows.Forms.Label();
            lblUniversity = new System.Windows.Forms.Label();
            lblCourseTitle = new System.Windows.Forms.Label();
            lblCourse = new System.Windows.Forms.Label();
            lblQualificationTitle = new System.Windows.Forms.Label();
            lblQualification = new System.Windows.Forms.Label();
            lblAPSTitle = new System.Windows.Forms.Label();
            lblAPS = new System.Windows.Forms.Label();
            lblDurationTitle = new System.Windows.Forms.Label();
            lblDuration = new System.Windows.Forms.Label();
            lblNotice = new System.Windows.Forms.Label();

            btnSubmit = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();

            pnlHeader.SuspendLayout();
            pnlDetails.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();

            // HEADER
            pnlHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(760, 125);

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(28, 18);
            lblTitle.Text = "Course Application";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblSubtitle.Location = new System.Drawing.Point(32, 78);
            lblSubtitle.Text = "Review the course details before submitting.";

            // DETAILS PANEL
            pnlDetails.BackColor = System.Drawing.Color.White;
            pnlDetails.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            pnlDetails.Location = new System.Drawing.Point(25, 150);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new System.Drawing.Size(710, 365);

            pnlDetails.Controls.Add(lblUniversityTitle);
            pnlDetails.Controls.Add(lblUniversity);
            pnlDetails.Controls.Add(lblCourseTitle);
            pnlDetails.Controls.Add(lblCourse);
            pnlDetails.Controls.Add(lblQualificationTitle);
            pnlDetails.Controls.Add(lblQualification);
            pnlDetails.Controls.Add(lblAPSTitle);
            pnlDetails.Controls.Add(lblAPS);
            pnlDetails.Controls.Add(lblDurationTitle);
            pnlDetails.Controls.Add(lblDuration);

            // UNIVERSITY
            lblUniversityTitle.AutoSize = true;
            lblUniversityTitle.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblUniversityTitle.Location = new System.Drawing.Point(20, 20);
            lblUniversityTitle.Text = "University";

            lblUniversity.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblUniversity.ForeColor = System.Drawing.Color.DarkSlateGray;
            lblUniversity.Location = new System.Drawing.Point(20, 52);
            lblUniversity.Size = new System.Drawing.Size(650, 30);
            lblUniversity.Text = "--";

            // COURSE
            lblCourseTitle.AutoSize = true;
            lblCourseTitle.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblCourseTitle.Location = new System.Drawing.Point(20, 95);
            lblCourseTitle.Text = "Course";

            lblCourse.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblCourse.ForeColor = System.Drawing.Color.DarkSlateGray;
            lblCourse.Location = new System.Drawing.Point(20, 125);
            lblCourse.Size = new System.Drawing.Size(650, 45);
            lblCourse.Text = "--";

            // QUALIFICATION
            lblQualificationTitle.AutoSize = true;
            lblQualificationTitle.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblQualificationTitle.Location =
                new System.Drawing.Point(20, 185);
            lblQualificationTitle.Text = "Qualification";

            lblQualification.Font =
                new System.Drawing.Font("Segoe UI", 11F);
            lblQualification.Location =
                new System.Drawing.Point(20, 215);
            lblQualification.Size =
                new System.Drawing.Size(650, 30);
            lblQualification.Text = "--";

            // APS
            lblAPSTitle.AutoSize = true;
            lblAPSTitle.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblAPSTitle.Location = new System.Drawing.Point(20, 265);
            lblAPSTitle.Text = "Minimum APS";

            lblAPS.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblAPS.Location = new System.Drawing.Point(20, 295);
            lblAPS.Size = new System.Drawing.Size(180, 30);
            lblAPS.Text = "--";

            // DURATION
            lblDurationTitle.AutoSize = true;
            lblDurationTitle.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblDurationTitle.Location =
                new System.Drawing.Point(330, 265);
            lblDurationTitle.Text = "Duration";

            lblDuration.Font =
                new System.Drawing.Font("Segoe UI", 11F);
            lblDuration.Location =
                new System.Drawing.Point(330, 295);
            lblDuration.Size =
                new System.Drawing.Size(250, 30);
            lblDuration.Text = "--";

            // NOTICE
            lblNotice.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblNotice.ForeColor = System.Drawing.Color.DimGray;
            lblNotice.Location = new System.Drawing.Point(28, 530);
            lblNotice.Size = new System.Drawing.Size(700, 55);
            lblNotice.Text =
                "Submitting records your course application in CareerLink. " +
                "It does not submit an official application to the university.";

            // FOOTER
            pnlFooter.BackColor = System.Drawing.Color.White;
            pnlFooter.Location = new System.Drawing.Point(25, 595);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new System.Drawing.Size(710, 80);
            pnlFooter.Controls.Add(btnSubmit);
            pnlFooter.Controls.Add(btnCancel);

            // SUBMIT
            btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            btnSubmit.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.ForeColor = System.Drawing.Color.White;
            btnSubmit.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSubmit.Location = new System.Drawing.Point(20, 17);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(320, 45);
            btnSubmit.Text = "Submit Application";
            btnSubmit.UseVisualStyleBackColor = false;

            // CANCEL
            btnCancel.BackColor = System.Drawing.Color.SlateGray;
            btnCancel.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCancel.Location = new System.Drawing.Point(370, 17);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(320, 45);
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;

            // FORM
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            ClientSize = new System.Drawing.Size(760, 700);

            Controls.Add(pnlHeader);
            Controls.Add(pnlDetails);
            Controls.Add(lblNotice);
            Controls.Add(pnlFooter);

            FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            Name = "CourseApplicationForm";
            Text = "CareerLink - Course Application";

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
