namespace CareerLink
{
    partial class SubjectEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblAdd = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            txtSubjectName = new System.Windows.Forms.TextBox();
            lblCategory = new System.Windows.Forms.Label();
            cmbCategory = new System.Windows.Forms.ComboBox();
            lblGrades = new System.Windows.Forms.Label();
            cmbGradeRange = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblAdd.Location = new System.Drawing.Point(23, 20);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new System.Drawing.Size(172, 32);
            lblAdd.TabIndex = 0;
            lblAdd.Text = "ADD SUBJECT";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(23, 91);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(102, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Subject name:";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new System.Drawing.Point(194, 87);
            txtSubjectName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new System.Drawing.Size(319, 27);
            txtSubjectName.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new System.Drawing.Point(23, 144);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(72, 20);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(194, 140);
            cmbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(319, 28);
            cmbCategory.TabIndex = 4;
            // 
            // lblGrades
            // 
            lblGrades.AutoSize = true;
            lblGrades.Location = new System.Drawing.Point(23, 197);
            lblGrades.Name = "lblGrades";
            lblGrades.Size = new System.Drawing.Size(94, 20);
            lblGrades.TabIndex = 5;
            lblGrades.Text = "Grade range:";
            // 
            // cmbGradeRange
            // 
            cmbGradeRange.FormattingEnabled = true;
            cmbGradeRange.Location = new System.Drawing.Point(194, 193);
            cmbGradeRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbGradeRange.Name = "cmbGradeRange";
            cmbGradeRange.Size = new System.Drawing.Size(319, 28);
            cmbGradeRange.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.SeaGreen;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(194, 273);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(149, 48);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(366, 273);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(149, 48);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // SubjectEditForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightYellow;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(549, 353);
            Controls.Add(lblAdd);
            Controls.Add(lblName);
            Controls.Add(txtSubjectName);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(lblGrades);
            Controls.Add(cmbGradeRange);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SubjectEditForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Add Subject";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblGrades;
        private System.Windows.Forms.ComboBox cmbGradeRange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
