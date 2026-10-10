
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CareerLink.Forms.UndergraduateForms
{
    partial class StudentProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblInfo;

        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.NumericUpDown numYear;

        private System.Windows.Forms.Button btnSave;
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
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblCourse = new System.Windows.Forms.Label();
            lblYear = new System.Windows.Forms.Label();
            lblInfo = new System.Windows.Forms.Label();
            cmbCourse = new System.Windows.Forms.ComboBox();
            numYear = new System.Windows.Forms.NumericUpDown();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();

            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            SuspendLayout();

            // Header
            pnlHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Size = new System.Drawing.Size(650, 125);

            // Title
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(25, 20);
            lblTitle.Text = "Student Profile";

            // Subtitle
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblSubtitle.Location = new System.Drawing.Point(29, 77);
            lblSubtitle.Text = "Complete your academic information";

            // Course label
            lblCourse.AutoSize = true;
            lblCourse.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblCourse.Location = new System.Drawing.Point(35, 160);
            lblCourse.Text = "Select Your Course";

            // Course dropdown
            cmbCourse.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCourse.Font = new System.Drawing.Font("Segoe UI", 11F);
            cmbCourse.Location = new System.Drawing.Point(35, 200);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new System.Drawing.Size(575, 33);

            // Year label
            lblYear.AutoSize = true;
            lblYear.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblYear.Location = new System.Drawing.Point(35, 265);
            lblYear.Text = "Year of Study";

            // Year selector
            numYear.Font = new System.Drawing.Font("Segoe UI", 11F);
            numYear.Location = new System.Drawing.Point(35, 305);
            numYear.Minimum = 1;
            numYear.Maximum = 10;
            numYear.Value = 1;
            numYear.Name = "numYear";
            numYear.Size = new System.Drawing.Size(200, 32);

            // Information label
            lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblInfo.ForeColor = System.Drawing.Color.DimGray;
            lblInfo.Location = new System.Drawing.Point(35, 365);
            lblInfo.Size = new System.Drawing.Size(570, 50);
            lblInfo.Text =
                "Your course and year of study help CareerLink " +
                "recommend relevant opportunities.";

            // Save button
            btnSave.BackColor = System.Drawing.Color.ForestGreen;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSave.Location = new System.Drawing.Point(35, 445);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(270, 45);
            btnSave.Text = "Save Profile";
            btnSave.UseVisualStyleBackColor = false;

            // Cancel button
            btnCancel.BackColor = System.Drawing.Color.SlateGray;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCancel.Location = new System.Drawing.Point(335, 445);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(275, 45);
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;

            // Form
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(650, 530);
            Controls.Add(pnlHeader);
            Controls.Add(lblCourse);
            Controls.Add(cmbCourse);
            Controls.Add(lblYear);
            Controls.Add(numYear);
            Controls.Add(lblInfo);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);

            FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            Name = "StudentProfileForm";
            Text = "CareerLink - Student Profile";

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
