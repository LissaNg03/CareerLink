namespace CareerLink
{
    partial class HighSchoolForm
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
            lblPrompt = new System.Windows.Forms.Label();
            txtCareer = new System.Windows.Forms.TextBox();
            btnShow = new System.Windows.Forms.Button();
            lblResult = new System.Windows.Forms.Label();
            lstSubjects = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new System.Drawing.Point(23, 20);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new System.Drawing.Size(366, 20);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Which career would you like to pursue after grade 12?";
            // 
            // txtCareer
            // 
            txtCareer.Location = new System.Drawing.Point(23, 60);
            txtCareer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCareer.Name = "txtCareer";
            txtCareer.Size = new System.Drawing.Size(342, 27);
            txtCareer.TabIndex = 0;
            // 
            // btnShow
            // 
            btnShow.Location = new System.Drawing.Point(377, 56);
            btnShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(149, 40);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show subjects";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new System.Drawing.Point(23, 127);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(503, 31);
            lblResult.TabIndex = 2;
            // 
            // lstSubjects
            // 
            lstSubjects.FormattingEnabled = true;
            lstSubjects.Location = new System.Drawing.Point(23, 167);
            lstSubjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lstSubjects.Name = "lstSubjects";
            lstSubjects.Size = new System.Drawing.Size(502, 304);
            lstSubjects.TabIndex = 2;
            // 
            // HighSchoolForm
            // 
            AcceptButton = btnShow;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightYellow;
            ClientSize = new System.Drawing.Size(549, 500);
            Controls.Add(lblPrompt);
            Controls.Add(txtCareer);
            Controls.Add(btnShow);
            Controls.Add(lblResult);
            Controls.Add(lstSubjects);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HighSchoolForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "High School";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtCareer;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox lstSubjects;
    }
}
