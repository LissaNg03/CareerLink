using System.Drawing;
using System.Windows.Forms;

namespace CareerLink
{
    partial class StudentProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblCourse;
        private ComboBox cmbCourse;
        private Label lblYearOfStudy;
        private ComboBox cmbYearOfStudy;
        private Label lblInstitution;
        private Label lblField;
        private Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblCourse = new Label();
            cmbCourse = new ComboBox();
            lblYearOfStudy = new Label();
            cmbYearOfStudy = new ComboBox();
            lblInstitution = new Label();
            lblField = new Label();
            btnSave = new Button();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.Location = new Point(40, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(216, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Profile";

            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(43, 77);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(349, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Tell us what you're studying to personalize opportunities.";

            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCourse.Location = new Point(43, 125);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(55, 19);
            lblCourse.TabIndex = 2;
            lblCourse.Text = "Course";

            // 
            // cmbCourse
            // 
            cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCourse.Font = new Font("Segoe UI", 10F);
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(43, 151);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(544, 25);
            cmbCourse.TabIndex = 3;
            cmbCourse.SelectedIndexChanged += cmbCourse_SelectedIndexChanged;

            // 
            // lblYearOfStudy
            // 
            lblYearOfStudy.AutoSize = true;
            lblYearOfStudy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblYearOfStudy.Location = new Point(43, 205);
            lblYearOfStudy.Name = "lblYearOfStudy";
            lblYearOfStudy.Size = new Size(98, 19);
            lblYearOfStudy.TabIndex = 4;
            lblYearOfStudy.Text = "Year of Study";

            // 
            // cmbYearOfStudy
            // 
            cmbYearOfStudy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYearOfStudy.Font = new Font("Segoe UI", 10F);
            cmbYearOfStudy.FormattingEnabled = true;
            cmbYearOfStudy.Location = new Point(43, 231);
            cmbYearOfStudy.Name = "cmbYearOfStudy";
            cmbYearOfStudy.Size = new Size(544, 25);
            cmbYearOfStudy.TabIndex = 5;

            // 
            // lblInstitution
            // 
            lblInstitution.AutoSize = true;
            lblInstitution.Font = new Font("Segoe UI", 10F);
            lblInstitution.Location = new Point(43, 295);
            lblInstitution.Name = "lblInstitution";
            lblInstitution.Size = new Size(154, 19);
            lblInstitution.TabIndex = 6;
            lblInstitution.Text = "Institution: Not selected";

            // 
            // lblField
            // 
            lblField.AutoSize = true;
            lblField.Font = new Font("Segoe UI", 10F);
            lblField.Location = new Point(43, 330);
            lblField.Name = "lblField";
            lblField.Size = new Size(119, 19);
            lblField.TabIndex = 7;
            lblField.Text = "Field: Not selected";

            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(43, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(544, 45);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save Profile";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;

            // 
            // StudentProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 480);
            Controls.Add(btnSave);
            Controls.Add(lblField);
            Controls.Add(lblInstitution);
            Controls.Add(cmbYearOfStudy);
            Controls.Add(lblYearOfStudy);
            Controls.Add(cmbCourse);
            Controls.Add(lblCourse);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StudentProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerLink - Student Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}