
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CareerLink
{
    partial class Grade12Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Panel pnlUniversities;
        private System.Windows.Forms.Panel pnlCourses;
        private System.Windows.Forms.Panel pnlApplications;
        private System.Windows.Forms.Panel pnlQuickActions;
        private System.Windows.Forms.Panel pnlStats;

        private System.Windows.Forms.Label lblPortalTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblGrade;

        private System.Windows.Forms.Label lblUniversitiesTitle;
        private System.Windows.Forms.Label lblUniversitiesDesc;
        private System.Windows.Forms.Label lblCoursesTitle;
        private System.Windows.Forms.Label lblCoursesDesc;
        private System.Windows.Forms.Label lblApplicationsTitle;
        private System.Windows.Forms.Label lblApplicationsDesc;

        private System.Windows.Forms.Label lblQuickActions;
        private System.Windows.Forms.Label lblStatsTitle;
        private System.Windows.Forms.Label lblUniversityCount;
        private System.Windows.Forms.Label lblCourseCount;
        private System.Windows.Forms.Label lblApplicationCount;
        private System.Windows.Forms.Label lblRecentApplications;

        private System.Windows.Forms.Button btnUniversities;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnApplications;
        private System.Windows.Forms.Button btnAPS;
        private System.Windows.Forms.Button btnCareers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.DataGridView dgvApplications;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblPortalTitle = new Label();
            btnLogout = new Button();
            pnlWelcome = new Panel();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            lblGrade = new Label();
            pnlUniversities = new Panel();
            lblUniversitiesTitle = new Label();
            lblUniversitiesDesc = new Label();
            btnUniversities = new Button();
            pnlCourses = new Panel();
            lblCoursesTitle = new Label();
            lblCoursesDesc = new Label();
            btnCourses = new Button();
            pnlApplications = new Panel();
            lblApplicationsTitle = new Label();
            lblApplicationsDesc = new Label();
            btnApplications = new Button();
            pnlQuickActions = new Panel();
            lblQuickActions = new Label();
            btnAPS = new Button();
            btnCareers = new Button();
            pnlStats = new Panel();
            lblStatsTitle = new Label();
            lblUniversityCount = new Label();
            lblCourseCount = new Label();
            lblApplicationCount = new Label();
            lblRecentApplications = new Label();
            btnRefresh = new Button();
            dgvApplications = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlWelcome.SuspendLayout();
            pnlUniversities.SuspendLayout();
            pnlCourses.SuspendLayout();
            pnlApplications.SuspendLayout();
            pnlQuickActions.SuspendLayout();
            pnlStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            pnlHeader.Controls.Add(lblPortalTitle);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(1020, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblPortalTitle
            // 
            lblPortalTitle.AutoSize = true;
            lblPortalTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblPortalTitle.ForeColor = System.Drawing.Color.White;
            lblPortalTitle.Location = new System.Drawing.Point(25, 19);
            lblPortalTitle.Name = "lblPortalTitle";
            lblPortalTitle.Size = new System.Drawing.Size(345, 35);
            lblPortalTitle.TabIndex = 0;
            lblPortalTitle.Text = "CareerLink | Grade 12 Portal";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.Salmon;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new System.Drawing.Point(895, 17);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(105, 35);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnlWelcome
            // 
            pnlWelcome.BackColor = System.Drawing.Color.FromArgb(27, 70, 105);
            pnlWelcome.Controls.Add(lblWelcome);
            pnlWelcome.Controls.Add(lblSubtitle);
            pnlWelcome.Controls.Add(lblGrade);
            pnlWelcome.Location = new System.Drawing.Point(20, 90);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new System.Drawing.Size(980, 150);
            pnlWelcome.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblWelcome.ForeColor = System.Drawing.Color.White;
            lblWelcome.Location = new System.Drawing.Point(25, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(700, 55);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Student!";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblSubtitle.Location = new System.Drawing.Point(28, 80);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(750, 30);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Explore universities, find courses and plan your future.";
            // 
            // lblGrade
            // 
            lblGrade.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblGrade.ForeColor = System.Drawing.Color.LightGreen;
            lblGrade.Location = new System.Drawing.Point(28, 115);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new System.Drawing.Size(300, 25);
            lblGrade.TabIndex = 2;
            lblGrade.Text = "Grade 12 Learner";
            // 
            // pnlUniversities
            // 
            pnlUniversities.BackColor = System.Drawing.Color.AliceBlue;
            pnlUniversities.BorderStyle = BorderStyle.FixedSingle;
            pnlUniversities.Controls.Add(lblUniversitiesTitle);
            pnlUniversities.Controls.Add(lblUniversitiesDesc);
            pnlUniversities.Controls.Add(btnUniversities);
            pnlUniversities.Location = new System.Drawing.Point(20, 260);
            pnlUniversities.Name = "pnlUniversities";
            pnlUniversities.Size = new System.Drawing.Size(310, 185);
            pnlUniversities.TabIndex = 2;
            // 
            // lblUniversitiesTitle
            // 
            lblUniversitiesTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblUniversitiesTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            lblUniversitiesTitle.Location = new System.Drawing.Point(20, 20);
            lblUniversitiesTitle.Name = "lblUniversitiesTitle";
            lblUniversitiesTitle.Size = new System.Drawing.Size(270, 40);
            lblUniversitiesTitle.TabIndex = 0;
            lblUniversitiesTitle.Text = "Universities";
            // 
            // lblUniversitiesDesc
            // 
            lblUniversitiesDesc.Location = new System.Drawing.Point(20, 68);
            lblUniversitiesDesc.Name = "lblUniversitiesDesc";
            lblUniversitiesDesc.Size = new System.Drawing.Size(270, 45);
            lblUniversitiesDesc.TabIndex = 1;
            lblUniversitiesDesc.Text = "Explore South African universities and their study options.";
            // 
            // btnUniversities
            // 
            btnUniversities.BackColor = System.Drawing.Color.DodgerBlue;
            btnUniversities.FlatStyle = FlatStyle.Flat;
            btnUniversities.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnUniversities.ForeColor = System.Drawing.Color.White;
            btnUniversities.Location = new System.Drawing.Point(20, 128);
            btnUniversities.Name = "btnUniversities";
            btnUniversities.Size = new System.Drawing.Size(260, 38);
            btnUniversities.TabIndex = 2;
            btnUniversities.Text = "View Universities";
            btnUniversities.UseVisualStyleBackColor = false;
            // 
            // pnlCourses
            // 
            pnlCourses.BackColor = System.Drawing.Color.Honeydew;
            pnlCourses.BorderStyle = BorderStyle.FixedSingle;
            pnlCourses.Controls.Add(lblCoursesTitle);
            pnlCourses.Controls.Add(lblCoursesDesc);
            pnlCourses.Controls.Add(btnCourses);
            pnlCourses.Location = new System.Drawing.Point(350, 260);
            pnlCourses.Name = "pnlCourses";
            pnlCourses.Size = new System.Drawing.Size(310, 185);
            pnlCourses.TabIndex = 3;
            // 
            // lblCoursesTitle
            // 
            lblCoursesTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblCoursesTitle.ForeColor = System.Drawing.Color.ForestGreen;
            lblCoursesTitle.Location = new System.Drawing.Point(20, 20);
            lblCoursesTitle.Name = "lblCoursesTitle";
            lblCoursesTitle.Size = new System.Drawing.Size(270, 40);
            lblCoursesTitle.TabIndex = 0;
            lblCoursesTitle.Text = "Available Courses";
            // 
            // lblCoursesDesc
            // 
            lblCoursesDesc.Location = new System.Drawing.Point(20, 68);
            lblCoursesDesc.Name = "lblCoursesDesc";
            lblCoursesDesc.Size = new System.Drawing.Size(270, 45);
            lblCoursesDesc.TabIndex = 1;
            lblCoursesDesc.Text = "Search university courses and review admission requirements.";
            // 
            // btnCourses
            // 
            btnCourses.BackColor = System.Drawing.Color.ForestGreen;
            btnCourses.FlatStyle = FlatStyle.Flat;
            btnCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnCourses.ForeColor = System.Drawing.Color.White;
            btnCourses.Location = new System.Drawing.Point(20, 128);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new System.Drawing.Size(260, 38);
            btnCourses.TabIndex = 2;
            btnCourses.Text = "Browse & Apply";
            btnCourses.UseVisualStyleBackColor = false;
            // 
            // pnlApplications
            // 
            pnlApplications.BackColor = System.Drawing.Color.LavenderBlush;
            pnlApplications.BorderStyle = BorderStyle.FixedSingle;
            pnlApplications.Controls.Add(lblApplicationsTitle);
            pnlApplications.Controls.Add(lblApplicationsDesc);
            pnlApplications.Controls.Add(btnApplications);
            pnlApplications.Location = new System.Drawing.Point(680, 260);
            pnlApplications.Name = "pnlApplications";
            pnlApplications.Size = new System.Drawing.Size(320, 185);
            pnlApplications.TabIndex = 4;
            // 
            // lblApplicationsTitle
            // 
            lblApplicationsTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblApplicationsTitle.ForeColor = System.Drawing.Color.Purple;
            lblApplicationsTitle.Location = new System.Drawing.Point(20, 20);
            lblApplicationsTitle.Name = "lblApplicationsTitle";
            lblApplicationsTitle.Size = new System.Drawing.Size(280, 40);
            lblApplicationsTitle.TabIndex = 0;
            lblApplicationsTitle.Text = "My Applications";
            // 
            // lblApplicationsDesc
            // 
            lblApplicationsDesc.Location = new System.Drawing.Point(20, 68);
            lblApplicationsDesc.Name = "lblApplicationsDesc";
            lblApplicationsDesc.Size = new System.Drawing.Size(280, 45);
            lblApplicationsDesc.TabIndex = 1;
            lblApplicationsDesc.Text = "Review your saved course applications and their statuses.";
            // 
            // btnApplications
            // 
            btnApplications.BackColor = System.Drawing.Color.Purple;
            btnApplications.FlatStyle = FlatStyle.Flat;
            btnApplications.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnApplications.ForeColor = System.Drawing.Color.White;
            btnApplications.Location = new System.Drawing.Point(20, 128);
            btnApplications.Name = "btnApplications";
            btnApplications.Size = new System.Drawing.Size(270, 38);
            btnApplications.TabIndex = 2;
            btnApplications.Text = "Track Applications";
            btnApplications.UseVisualStyleBackColor = false;
            btnApplications.Click += btnApplications_Click_1;
            // 
            // pnlQuickActions
            // 
            pnlQuickActions.BackColor = System.Drawing.Color.White;
            pnlQuickActions.Controls.Add(lblQuickActions);
            pnlQuickActions.Controls.Add(btnAPS);
            pnlQuickActions.Controls.Add(btnCareers);
            pnlQuickActions.Location = new System.Drawing.Point(20, 465);
            pnlQuickActions.Name = "pnlQuickActions";
            pnlQuickActions.Size = new System.Drawing.Size(980, 90);
            pnlQuickActions.TabIndex = 5;
            // 
            // lblQuickActions
            // 
            lblQuickActions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblQuickActions.Location = new System.Drawing.Point(15, 10);
            lblQuickActions.Name = "lblQuickActions";
            lblQuickActions.Size = new System.Drawing.Size(180, 30);
            lblQuickActions.TabIndex = 0;
            lblQuickActions.Text = "Quick Actions";
            // 
            // btnAPS
            // 
            btnAPS.BackColor = System.Drawing.Color.Teal;
            btnAPS.FlatStyle = FlatStyle.Flat;
            btnAPS.ForeColor = System.Drawing.Color.White;
            btnAPS.Location = new System.Drawing.Point(200, 20);
            btnAPS.Name = "btnAPS";
            btnAPS.Size = new System.Drawing.Size(260, 45);
            btnAPS.TabIndex = 1;
            btnAPS.Text = "APS Calculator";
            btnAPS.UseVisualStyleBackColor = false;
            // 
            // btnCareers
            // 
            btnCareers.BackColor = System.Drawing.Color.DarkOrange;
            btnCareers.FlatStyle = FlatStyle.Flat;
            btnCareers.ForeColor = System.Drawing.Color.White;
            btnCareers.Location = new System.Drawing.Point(490, 20);
            btnCareers.Name = "btnCareers";
            btnCareers.Size = new System.Drawing.Size(260, 45);
            btnCareers.TabIndex = 2;
            btnCareers.Text = "Career Recommendations";
            btnCareers.UseVisualStyleBackColor = false;
            // 
            // pnlStats
            // 
            pnlStats.BackColor = System.Drawing.Color.AliceBlue;
            pnlStats.Controls.Add(lblStatsTitle);
            pnlStats.Controls.Add(lblUniversityCount);
            pnlStats.Controls.Add(lblCourseCount);
            pnlStats.Controls.Add(lblApplicationCount);
            pnlStats.Location = new System.Drawing.Point(20, 570);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new System.Drawing.Size(980, 75);
            pnlStats.TabIndex = 6;
            // 
            // lblStatsTitle
            // 
            lblStatsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblStatsTitle.Location = new System.Drawing.Point(15, 10);
            lblStatsTitle.Name = "lblStatsTitle";
            lblStatsTitle.Size = new System.Drawing.Size(150, 30);
            lblStatsTitle.TabIndex = 0;
            lblStatsTitle.Text = "Quick Stats";
            // 
            // lblUniversityCount
            // 
            lblUniversityCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblUniversityCount.Location = new System.Drawing.Point(180, 22);
            lblUniversityCount.Name = "lblUniversityCount";
            lblUniversityCount.Size = new System.Drawing.Size(230, 30);
            lblUniversityCount.TabIndex = 1;
            lblUniversityCount.Text = "Universities: --";
            // 
            // lblCourseCount
            // 
            lblCourseCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblCourseCount.Location = new System.Drawing.Point(440, 22);
            lblCourseCount.Name = "lblCourseCount";
            lblCourseCount.Size = new System.Drawing.Size(220, 30);
            lblCourseCount.TabIndex = 2;
            lblCourseCount.Text = "Courses: --";
            // 
            // lblApplicationCount
            // 
            lblApplicationCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblApplicationCount.Location = new System.Drawing.Point(690, 22);
            lblApplicationCount.Name = "lblApplicationCount";
            lblApplicationCount.Size = new System.Drawing.Size(250, 30);
            lblApplicationCount.TabIndex = 3;
            lblApplicationCount.Text = "My Applications: --";
            // 
            // lblRecentApplications
            // 
            lblRecentApplications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblRecentApplications.ForeColor = System.Drawing.Color.DarkSlateGray;
            lblRecentApplications.Location = new System.Drawing.Point(20, 665);
            lblRecentApplications.Name = "lblRecentApplications";
            lblRecentApplications.Size = new System.Drawing.Size(400, 35);
            lblRecentApplications.TabIndex = 7;
            lblRecentApplications.Text = "Recent Course Applications";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = System.Drawing.Color.MediumSeaGreen;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new System.Drawing.Point(880, 665);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(120, 35);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvApplications
            // 
            dgvApplications.AllowUserToAddRows = false;
            dgvApplications.AllowUserToDeleteRows = false;
            dgvApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApplications.BackgroundColor = System.Drawing.Color.White;
            dgvApplications.BorderStyle = BorderStyle.None;
            dgvApplications.ColumnHeadersHeight = 35;
            dgvApplications.Location = new System.Drawing.Point(20, 710);
            dgvApplications.MultiSelect = false;
            dgvApplications.Name = "dgvApplications";
            dgvApplications.ReadOnly = true;
            dgvApplications.RowHeadersVisible = false;
            dgvApplications.RowHeadersWidth = 51;
            dgvApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplications.Size = new System.Drawing.Size(980, 155);
            dgvApplications.TabIndex = 9;
            // 
            // Grade12Dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            ClientSize = new System.Drawing.Size(1020, 900);
            Controls.Add(pnlHeader);
            Controls.Add(pnlWelcome);
            Controls.Add(pnlUniversities);
            Controls.Add(pnlCourses);
            Controls.Add(pnlApplications);
            Controls.Add(pnlQuickActions);
            Controls.Add(pnlStats);
            Controls.Add(lblRecentApplications);
            Controls.Add(btnRefresh);
            Controls.Add(dgvApplications);
            Name = "Grade12Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CareerLink - Grade 12 Dashboard";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlWelcome.ResumeLayout(false);
            pnlUniversities.ResumeLayout(false);
            pnlCourses.ResumeLayout(false);
            pnlApplications.ResumeLayout(false);
            pnlQuickActions.ResumeLayout(false);
            pnlStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvApplications).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
