namespace CareerLink
{
    partial class CareerEditForm
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
            lblKeyword = new System.Windows.Forms.Label();
            txtKeyword = new System.Windows.Forms.TextBox();
            lblCareerName = new System.Windows.Forms.Label();
            txtCareerName = new System.Windows.Forms.TextBox();
            lblSubjects = new System.Windows.Forms.Label();
            txtSubjects = new System.Windows.Forms.TextBox();
            lblHint = new System.Windows.Forms.Label();
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
            lblAdd.Size = new System.Drawing.Size(164, 32);
            lblAdd.TabIndex = 0;
            lblAdd.Text = "ADD CAREER";
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new System.Drawing.Point(23, 91);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new System.Drawing.Size(70, 20);
            lblKeyword.TabIndex = 1;
            lblKeyword.Text = "Keyword:";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new System.Drawing.Point(194, 87);
            txtKeyword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new System.Drawing.Size(342, 27);
            txtKeyword.TabIndex = 2;
            // 
            // lblCareerName
            // 
            lblCareerName.AutoSize = true;
            lblCareerName.Location = new System.Drawing.Point(23, 144);
            lblCareerName.Name = "lblCareerName";
            lblCareerName.Size = new System.Drawing.Size(96, 20);
            lblCareerName.TabIndex = 3;
            lblCareerName.Text = "Career name:";
            // 
            // txtCareerName
            // 
            txtCareerName.Location = new System.Drawing.Point(194, 140);
            txtCareerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCareerName.Name = "txtCareerName";
            txtCareerName.Size = new System.Drawing.Size(342, 27);
            txtCareerName.TabIndex = 4;
            // 
            // lblSubjects
            // 
            lblSubjects.AutoSize = true;
            lblSubjects.Location = new System.Drawing.Point(23, 197);
            lblSubjects.Name = "lblSubjects";
            lblSubjects.Size = new System.Drawing.Size(121, 20);
            lblSubjects.TabIndex = 5;
            lblSubjects.Text = "Subjects needed:";
            // 
            // txtSubjects
            // 
            txtSubjects.AcceptsReturn = true;
            txtSubjects.Location = new System.Drawing.Point(194, 193);
            txtSubjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSubjects.Multiline = true;
            txtSubjects.Name = "txtSubjects";
            txtSubjects.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtSubjects.Size = new System.Drawing.Size(342, 199);
            txtSubjects.TabIndex = 6;
            // 
            // lblHint
            // 
            lblHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblHint.ForeColor = System.Drawing.Color.DimGray;
            lblHint.Location = new System.Drawing.Point(194, 400);
            lblHint.Name = "lblHint";
            lblHint.Size = new System.Drawing.Size(343, 64);
            lblHint.TabIndex = 7;
            lblHint.Text = "One subject per line. The keyword is matched inside what the learner types (\"engineer\" matches \"civil engineer\").";
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.SeaGreen;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(194, 493);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(149, 48);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(389, 493);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(149, 48);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // CareerEditForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightYellow;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(571, 567);
            Controls.Add(lblAdd);
            Controls.Add(lblKeyword);
            Controls.Add(txtKeyword);
            Controls.Add(lblCareerName);
            Controls.Add(txtCareerName);
            Controls.Add(lblSubjects);
            Controls.Add(txtSubjects);
            Controls.Add(lblHint);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CareerEditForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Add Career";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblCareerName;
        private System.Windows.Forms.TextBox txtCareerName;
        private System.Windows.Forms.Label lblSubjects;
        private System.Windows.Forms.TextBox txtSubjects;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
