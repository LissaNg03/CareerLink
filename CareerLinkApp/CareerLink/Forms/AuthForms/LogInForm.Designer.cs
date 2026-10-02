namespace CareerLink
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            lblHeading = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            lnkForgot = new System.Windows.Forms.LinkLabel();
            btnCreate = new System.Windows.Forms.Button();
            pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblHeading.Location = new System.Drawing.Point(0, 213);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new System.Drawing.Size(1029, 53);
            lblHeading.TabIndex = 7;
            lblHeading.Text = "Have an Account?";
            lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtUsername.Location = new System.Drawing.Point(383, 313);
            txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username or Email";
            txtUsername.Size = new System.Drawing.Size(262, 32);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtPassword.Location = new System.Drawing.Point(383, 400);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new System.Drawing.Size(262, 32);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.LightSeaGreen;
            btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnLogin.Location = new System.Drawing.Point(331, 480);
            btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(366, 64);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkForgot
            // 
            lnkForgot.ActiveLinkColor = System.Drawing.Color.DimGray;
            lnkForgot.Font = new System.Drawing.Font("Segoe UI", 10F);
            lnkForgot.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            lnkForgot.LinkColor = System.Drawing.Color.Black;
            lnkForgot.Location = new System.Drawing.Point(331, 552);
            lnkForgot.Name = "lnkForgot";
            lnkForgot.Size = new System.Drawing.Size(366, 29);
            lnkForgot.TabIndex = 3;
            lnkForgot.TabStop = true;
            lnkForgot.Text = "Forgot Password?";
            lnkForgot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lnkForgot.LinkClicked += lnkForgot_LinkClicked;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.Color.PaleTurquoise;
            btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnCreate.Location = new System.Drawing.Point(331, 620);
            btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(366, 64);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create new account";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBoxLogo.Image = (System.Drawing.Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new System.Drawing.Size(1029, 210);
            pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 8;
            pictureBoxLogo.TabStop = false;
          
            // 
            // MainForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightYellow;
            ClientSize = new System.Drawing.Size(1029, 733);
            Controls.Add(pictureBoxLogo);
            Controls.Add(lblHeading);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(lnkForgot);
            Controls.Add(btnCreate);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "CareerLink";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
