namespace CareerLink.Forms.HighSchoolForms
{
    partial class APSForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.lblMaths = new System.Windows.Forms.Label();
            this.txtMaths = new System.Windows.Forms.TextBox();
            this.lblPhysicalScience = new System.Windows.Forms.Label();
            this.txtPhysicalScience = new System.Windows.Forms.TextBox();
            this.lblLifeScience = new System.Windows.Forms.Label();
            this.txtLifeScience = new System.Windows.Forms.TextBox();
            this.lblSubject5 = new System.Windows.Forms.Label();
            this.txtSubject5 = new System.Windows.Forms.TextBox();
            this.lblSubject6 = new System.Windows.Forms.Label();
            this.txtSubject6 = new System.Windows.Forms.TextBox();
            this.lblSubject7 = new System.Windows.Forms.Label();
            this.txtSubject7 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAPSResult = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // pnlCard
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.lblEnglish);
            this.pnlCard.Controls.Add(this.txtEnglish);
            this.pnlCard.Controls.Add(this.lblMaths);
            this.pnlCard.Controls.Add(this.txtMaths);
            this.pnlCard.Controls.Add(this.lblPhysicalScience);
            this.pnlCard.Controls.Add(this.txtPhysicalScience);
            this.pnlCard.Controls.Add(this.lblLifeScience);
            this.pnlCard.Controls.Add(this.txtLifeScience);
            this.pnlCard.Controls.Add(this.lblSubject5);
            this.pnlCard.Controls.Add(this.txtSubject5);
            this.pnlCard.Controls.Add(this.lblSubject6);
            this.pnlCard.Controls.Add(this.txtSubject6);
            this.pnlCard.Controls.Add(this.lblSubject7);
            this.pnlCard.Controls.Add(this.txtSubject7);
            this.pnlCard.Controls.Add(this.btnCalculate);
            this.pnlCard.Controls.Add(this.lblAPSResult);
            this.pnlCard.Location = new System.Drawing.Point(24, 120);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(474, 474);
            this.pnlCard.TabIndex = 0;
            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(520, 96);
            this.pnlHeader.TabIndex = 1;
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "APS Calculator";
            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSubtitle.Location = new System.Drawing.Point(27, 58);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(100, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Enter your final marks for each subject (0 - 100)";
            // lblEnglish
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblEnglish.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblEnglish.Location = new System.Drawing.Point(24, 26);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(100, 19);
            this.lblEnglish.TabIndex = 0;
            this.lblEnglish.Text = "English";
            // txtEnglish
            this.txtEnglish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnglish.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtEnglish.Location = new System.Drawing.Point(300, 22);
            this.txtEnglish.MaxLength = 3;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(148, 26);
            this.txtEnglish.TabIndex = 1;
            this.txtEnglish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // lblMaths
            this.lblMaths.AutoSize = true;
            this.lblMaths.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblMaths.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMaths.Location = new System.Drawing.Point(24, 70);
            this.lblMaths.Name = "lblMaths";
            this.lblMaths.Size = new System.Drawing.Size(100, 19);
            this.lblMaths.TabIndex = 2;
            this.lblMaths.Text = "Mathematics";
            // txtMaths
            this.txtMaths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaths.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtMaths.Location = new System.Drawing.Point(300, 66);
            this.txtMaths.MaxLength = 3;
            this.txtMaths.Name = "txtMaths";
            this.txtMaths.Size = new System.Drawing.Size(148, 26);
            this.txtMaths.TabIndex = 3;
            this.txtMaths.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // lblPhysicalScience
            this.lblPhysicalScience.AutoSize = true;
            this.lblPhysicalScience.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblPhysicalScience.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPhysicalScience.Location = new System.Drawing.Point(24, 114);
            this.lblPhysicalScience.Name = "lblPhysicalScience";
            this.lblPhysicalScience.Size = new System.Drawing.Size(100, 19);
            this.lblPhysicalScience.TabIndex = 4;
            this.lblPhysicalScience.Text = "Physical Sciences";
            // txtPhysicalScience
            this.txtPhysicalScience.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhysicalScience.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPhysicalScience.Location = new System.Drawing.Point(300, 110);
            this.txtPhysicalScience.MaxLength = 3;
            this.txtPhysicalScience.Name = "txtPhysicalScience";
            this.txtPhysicalScience.Size = new System.Drawing.Size(148, 26);
            this.txtPhysicalScience.TabIndex = 5;
            this.txtPhysicalScience.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // lblLifeScience
            this.lblLifeScience.AutoSize = true;
            this.lblLifeScience.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblLifeScience.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblLifeScience.Location = new System.Drawing.Point(24, 158);
            this.lblLifeScience.Name = "lblLifeScience";
            this.lblLifeScience.Size = new System.Drawing.Size(100, 19);
            this.lblLifeScience.TabIndex = 6;
            this.lblLifeScience.Text = "Life Sciences";
            // txtLifeScience
            this.txtLifeScience.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLifeScience.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtLifeScience.Location = new System.Drawing.Point(300, 154);
            this.txtLifeScience.MaxLength = 3;
            this.txtLifeScience.Name = "txtLifeScience";
            this.txtLifeScience.Size = new System.Drawing.Size(148, 26);
            this.txtLifeScience.TabIndex = 7;
            this.txtLifeScience.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // lblSubject5
            this.lblSubject5.AutoSize = true;
            this.lblSubject5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblSubject5.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblSubject5.Location = new System.Drawing.Point(24, 202);
            this.lblSubject5.Name = "lblSubject5";
            this.lblSubject5.Size = new System.Drawing.Size(100, 19);
            this.lblSubject5.TabIndex = 8;
            this.lblSubject5.Text = "Subject 5";
            // txtSubject5
            this.txtSubject5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubject5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSubject5.Location = new System.Drawing.Point(300, 198);
            this.txtSubject5.MaxLength = 3;
            this.txtSubject5.Name = "txtSubject5";
            this.txtSubject5.Size = new System.Drawing.Size(148, 26);
            this.txtSubject5.TabIndex = 9;
            this.txtSubject5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // lblSubject6
            this.lblSubject6.AutoSize = true;
            this.lblSubject6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblSubject6.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblSubject6.Location = new System.Drawing.Point(24, 246);
            this.lblSubject6.Name = "lblSubject6";
            this.lblSubject6.Size = new System.Drawing.Size(100, 19);
            this.lblSubject6.TabIndex = 10;
            this.lblSubject6.Text = "Subject 6";
            // txtSubject6
            this.txtSubject6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubject6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSubject6.Location = new System.Drawing.Point(300, 242);
            this.txtSubject6.MaxLength = 3;
            this.txtSubject6.Name = "txtSubject6";
            this.txtSubject6.Size = new System.Drawing.Size(148, 26);
            this.txtSubject6.TabIndex = 11;
            this.txtSubject6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // lblSubject7
            this.lblSubject7.AutoSize = true;
            this.lblSubject7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblSubject7.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblSubject7.Location = new System.Drawing.Point(24, 290);
            this.lblSubject7.Name = "lblSubject7";
            this.lblSubject7.Size = new System.Drawing.Size(100, 19);
            this.lblSubject7.TabIndex = 12;
            this.lblSubject7.Text = "Subject 7";
            // txtSubject7
            this.txtSubject7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubject7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSubject7.Location = new System.Drawing.Point(300, 286);
            this.txtSubject7.MaxLength = 3;
            this.txtSubject7.Name = "txtSubject7";
            this.txtSubject7.Size = new System.Drawing.Size(148, 26);
            this.txtSubject7.TabIndex = 13;
            this.txtSubject7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // btnCalculate
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(24, 350);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(424, 48);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate APS";
            this.btnCalculate.UseVisualStyleBackColor = false;
            // lblAPSResult
            this.lblAPSResult.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            this.lblAPSResult.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lblAPSResult.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblAPSResult.Location = new System.Drawing.Point(24, 414);
            this.lblAPSResult.Name = "lblAPSResult";
            this.lblAPSResult.Size = new System.Drawing.Size(424, 44);
            this.lblAPSResult.TabIndex = 15;
            this.lblAPSResult.Text = "Your APS Score: -";
            this.lblAPSResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // APSForm
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(520, 616);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "APSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APS Calculator";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label lblMaths;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.Label lblPhysicalScience;
        private System.Windows.Forms.TextBox txtPhysicalScience;
        private System.Windows.Forms.Label lblLifeScience;
        private System.Windows.Forms.TextBox txtLifeScience;
        private System.Windows.Forms.Label lblSubject5;
        private System.Windows.Forms.TextBox txtSubject5;
        private System.Windows.Forms.Label lblSubject6;
        private System.Windows.Forms.TextBox txtSubject6;
        private System.Windows.Forms.Label lblSubject7;
        private System.Windows.Forms.TextBox txtSubject7;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAPSResult;
    }
}
