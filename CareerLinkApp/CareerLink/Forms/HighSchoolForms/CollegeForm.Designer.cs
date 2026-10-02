namespace CareerLink
{
    partial class CollegeForm
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
            lblField = new System.Windows.Forms.Label();
            cmbField = new System.Windows.Forms.ComboBox();
            lblSubject = new System.Windows.Forms.Label();
            cmbSubject = new System.Windows.Forms.ComboBox();
            lblPercent = new System.Windows.Forms.Label();
            numPercent = new System.Windows.Forms.NumericUpDown();
            btnAddSubject = new System.Windows.Forms.Button();
            lblYourSubjects = new System.Windows.Forms.Label();
            lstSubjects = new System.Windows.Forms.ListBox();
            btnRemove = new System.Windows.Forms.Button();
            btnCheck = new System.Windows.Forms.Button();
            lblResults = new System.Windows.Forms.Label();
            lstResults = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)numPercent).BeginInit();
            SuspendLayout();
            // 
            // lblField
            // 
            lblField.AutoSize = true;
            lblField.Location = new System.Drawing.Point(23, 20);
            lblField.Name = "lblField";
            lblField.Size = new System.Drawing.Size(193, 20);
            lblField.TabIndex = 0;
            lblField.Text = "Which studies do you want?";
            // 
            // cmbField
            // 
            cmbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbField.FormattingEnabled = true;
            cmbField.Location = new System.Drawing.Point(23, 53);
            cmbField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbField.Name = "cmbField";
            cmbField.Size = new System.Drawing.Size(525, 28);
            cmbField.TabIndex = 0;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new System.Drawing.Point(23, 113);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new System.Drawing.Size(61, 20);
            lblSubject.TabIndex = 1;
            lblSubject.Text = "Subject:";
            // 
            // cmbSubject
            // 
            cmbSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmbSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cmbSubject.DropDownWidth = 360;
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new System.Drawing.Point(23, 144);
            cmbSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbSubject.MaxDropDownItems = 20;
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new System.Drawing.Size(342, 28);
            cmbSubject.TabIndex = 1;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new System.Drawing.Point(389, 113);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new System.Drawing.Size(149, 20);
            lblPercent.TabIndex = 2;
            lblPercent.Text = "Percentage obtained:";
            // 
            // numPercent
            // 
            numPercent.Location = new System.Drawing.Point(389, 144);
            numPercent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numPercent.Name = "numPercent";
            numPercent.Size = new System.Drawing.Size(160, 27);
            numPercent.TabIndex = 2;
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new System.Drawing.Point(23, 197);
            btnAddSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new System.Drawing.Size(149, 43);
            btnAddSubject.TabIndex = 3;
            btnAddSubject.Text = "Add subject";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // lblYourSubjects
            // 
            lblYourSubjects.AutoSize = true;
            lblYourSubjects.Location = new System.Drawing.Point(23, 260);
            lblYourSubjects.Name = "lblYourSubjects";
            lblYourSubjects.Size = new System.Drawing.Size(98, 20);
            lblYourSubjects.TabIndex = 4;
            lblYourSubjects.Text = "Your subjects:";
            // 
            // lstSubjects
            // 
            lstSubjects.FormattingEnabled = true;
            lstSubjects.Location = new System.Drawing.Point(23, 291);
            lstSubjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lstSubjects.Name = "lstSubjects";
            lstSubjects.Size = new System.Drawing.Size(525, 164);
            lstSubjects.TabIndex = 4;
            // 
            // btnRemove
            // 
            btnRemove.Location = new System.Drawing.Point(23, 467);
            btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(171, 43);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove selected";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new System.Drawing.Point(377, 467);
            btnCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new System.Drawing.Size(171, 43);
            btnCheck.TabIndex = 6;
            btnCheck.Text = "Show my streams";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new System.Drawing.Point(23, 533);
            lblResults.Name = "lblResults";
            lblResults.Size = new System.Drawing.Size(165, 20);
            lblResults.TabIndex = 7;
            lblResults.Text = "Streams you qualify for:";
            // 
            // lstResults
            // 
            lstResults.FormattingEnabled = true;
            lstResults.Location = new System.Drawing.Point(23, 564);
            lstResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lstResults.Name = "lstResults";
            lstResults.Size = new System.Drawing.Size(525, 204);
            lstResults.TabIndex = 7;
            // 
            // CollegeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightYellow;
            ClientSize = new System.Drawing.Size(571, 793);
            Controls.Add(lblField);
            Controls.Add(cmbField);
            Controls.Add(lblSubject);
            Controls.Add(cmbSubject);
            Controls.Add(lblPercent);
            Controls.Add(numPercent);
            Controls.Add(btnAddSubject);
            Controls.Add(lblYourSubjects);
            Controls.Add(lstSubjects);
            Controls.Add(btnRemove);
            Controls.Add(btnCheck);
            Controls.Add(lblResults);
            Controls.Add(lstResults);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CollegeForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "College";
            ((System.ComponentModel.ISupportInitialize)numPercent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.NumericUpDown numPercent;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Label lblYourSubjects;
        private System.Windows.Forms.ListBox lstSubjects;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ListBox lstResults;
    }
}
