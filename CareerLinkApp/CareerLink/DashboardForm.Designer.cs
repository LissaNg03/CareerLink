namespace CareerLink
{
    partial class DashboardForm
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
            lblWelcome = new System.Windows.Forms.Label();
            lblPath = new System.Windows.Forms.Label();
            btnCollege = new System.Windows.Forms.Button();
            btnHighSchool = new System.Windows.Forms.Button();
            lblAdmin = new System.Windows.Forms.Label();
            btnManageUsers = new System.Windows.Forms.Button();
            btnManageSubjects = new System.Windows.Forms.Button();
            btnManageStreams = new System.Windows.Forms.Button();
            btnManageCareers = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblWelcome.Location = new System.Drawing.Point(34, 33);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(148, 37);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "WELCOME";
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblPath.Location = new System.Drawing.Point(34, 120);
            lblPath.Name = "lblPath";
            lblPath.Size = new System.Drawing.Size(296, 28);
            lblPath.TabIndex = 1;
            lblPath.Text = "Which path do you want to take:";
            // 
            // btnCollege
            // 
            btnCollege.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnCollege.Location = new System.Drawing.Point(34, 173);
            btnCollege.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCollege.Name = "btnCollege";
            btnCollege.Size = new System.Drawing.Size(274, 93);
            btnCollege.TabIndex = 2;
            btnCollege.Text = "College";
            btnCollege.UseVisualStyleBackColor = true;
            btnCollege.Click += btnCollege_Click;
            // 
            // btnHighSchool
            // 
            btnHighSchool.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnHighSchool.Location = new System.Drawing.Point(331, 173);
            btnHighSchool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnHighSchool.Name = "btnHighSchool";
            btnHighSchool.Size = new System.Drawing.Size(274, 93);
            btnHighSchool.TabIndex = 3;
            btnHighSchool.Text = "High School";
            btnHighSchool.UseVisualStyleBackColor = true;
            btnHighSchool.Click += btnHighSchool_Click;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblAdmin.Location = new System.Drawing.Point(34, 300);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new System.Drawing.Size(151, 20);
            lblAdmin.TabIndex = 4;
            lblAdmin.Text = "Administrator tools:";
            lblAdmin.Visible = false;
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new System.Drawing.Point(34, 333);
            btnManageUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new System.Drawing.Size(137, 48);
            btnManageUsers.TabIndex = 5;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Visible = false;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnManageSubjects
            // 
            btnManageSubjects.Location = new System.Drawing.Point(185, 333);
            btnManageSubjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnManageSubjects.Name = "btnManageSubjects";
            btnManageSubjects.Size = new System.Drawing.Size(137, 48);
            btnManageSubjects.TabIndex = 6;
            btnManageSubjects.Text = "Manage Subjects";
            btnManageSubjects.UseVisualStyleBackColor = true;
            btnManageSubjects.Visible = false;
            btnManageSubjects.Click += btnManageSubjects_Click;
            // 
            // btnManageStreams
            // 
            btnManageStreams.Location = new System.Drawing.Point(336, 333);
            btnManageStreams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnManageStreams.Name = "btnManageStreams";
            btnManageStreams.Size = new System.Drawing.Size(137, 48);
            btnManageStreams.TabIndex = 7;
            btnManageStreams.Text = "Manage Streams";
            btnManageStreams.UseVisualStyleBackColor = true;
            btnManageStreams.Visible = false;
            btnManageStreams.Click += btnManageStreams_Click;
            // 
            // btnManageCareers
            // 
            btnManageCareers.Location = new System.Drawing.Point(487, 333);
            btnManageCareers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnManageCareers.Name = "btnManageCareers";
            btnManageCareers.Size = new System.Drawing.Size(137, 48);
            btnManageCareers.TabIndex = 8;
            btnManageCareers.Text = "Manage Careers";
            btnManageCareers.UseVisualStyleBackColor = true;
            btnManageCareers.Visible = false;
            btnManageCareers.Click += btnManageCareers_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(487, 400);
            btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(137, 48);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightYellow;
            ClientSize = new System.Drawing.Size(640, 467);
            Controls.Add(lblWelcome);
            Controls.Add(lblPath);
            Controls.Add(btnCollege);
            Controls.Add(btnHighSchool);
            Controls.Add(lblAdmin);
            Controls.Add(btnManageUsers);
            Controls.Add(btnManageSubjects);
            Controls.Add(btnManageStreams);
            Controls.Add(btnManageCareers);
            Controls.Add(btnLogout);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DashboardForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "CareerLink";
            Load += DashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnCollege;
        private System.Windows.Forms.Button btnHighSchool;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageSubjects;
        private System.Windows.Forms.Button btnManageStreams;
        private System.Windows.Forms.Button btnManageCareers;
        private System.Windows.Forms.Button btnLogout;
    }
}
