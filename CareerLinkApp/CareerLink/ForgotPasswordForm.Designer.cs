namespace CareerLink
{
    partial class ForgotPasswordForm
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
            lblInfo = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            btnContinue = new System.Windows.Forms.Button();
            pnlReset = new System.Windows.Forms.Panel();
            lblQuestion1 = new System.Windows.Forms.Label();
            txtAnswer1 = new System.Windows.Forms.TextBox();
            lblQuestion2 = new System.Windows.Forms.Label();
            txtAnswer2 = new System.Windows.Forms.TextBox();
            lblNewPassword = new System.Windows.Forms.Label();
            txtNewPassword = new System.Windows.Forms.TextBox();
            lblConfirm = new System.Windows.Forms.Label();
            txtConfirm = new System.Windows.Forms.TextBox();
            btnReset = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            pnlReset.SuspendLayout();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new System.Drawing.Point(23, 20);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(312, 20);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Enter your email address to find your account:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(23, 60);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(365, 27);
            txtEmail.TabIndex = 0;
            // 
            // btnContinue
            // 
            btnContinue.Location = new System.Drawing.Point(400, 56);
            btnContinue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new System.Drawing.Size(149, 40);
            btnContinue.TabIndex = 1;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // pnlReset
            // 
            pnlReset.Controls.Add(lblQuestion1);
            pnlReset.Controls.Add(txtAnswer1);
            pnlReset.Controls.Add(lblQuestion2);
            pnlReset.Controls.Add(txtAnswer2);
            pnlReset.Controls.Add(lblNewPassword);
            pnlReset.Controls.Add(txtNewPassword);
            pnlReset.Controls.Add(lblConfirm);
            pnlReset.Controls.Add(txtConfirm);
            pnlReset.Controls.Add(btnReset);
            pnlReset.Location = new System.Drawing.Point(23, 127);
            pnlReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlReset.Name = "pnlReset";
            pnlReset.Size = new System.Drawing.Size(526, 453);
            pnlReset.TabIndex = 2;
            pnlReset.Visible = false;
            // 
            // lblQuestion1
            // 
            lblQuestion1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblQuestion1.Location = new System.Drawing.Point(0, 0);
            lblQuestion1.Name = "lblQuestion1";
            lblQuestion1.Size = new System.Drawing.Size(526, 27);
            lblQuestion1.TabIndex = 0;
            // 
            // txtAnswer1
            // 
            txtAnswer1.Location = new System.Drawing.Point(0, 33);
            txtAnswer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAnswer1.Name = "txtAnswer1";
            txtAnswer1.Size = new System.Drawing.Size(525, 27);
            txtAnswer1.TabIndex = 0;
            // 
            // lblQuestion2
            // 
            lblQuestion2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblQuestion2.Location = new System.Drawing.Point(0, 93);
            lblQuestion2.Name = "lblQuestion2";
            lblQuestion2.Size = new System.Drawing.Size(526, 27);
            lblQuestion2.TabIndex = 1;
            // 
            // txtAnswer2
            // 
            txtAnswer2.Location = new System.Drawing.Point(0, 127);
            txtAnswer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAnswer2.Name = "txtAnswer2";
            txtAnswer2.Size = new System.Drawing.Size(525, 27);
            txtAnswer2.TabIndex = 1;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new System.Drawing.Point(0, 193);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new System.Drawing.Size(109, 20);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "New password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new System.Drawing.Point(0, 224);
            txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new System.Drawing.Size(342, 27);
            txtNewPassword.TabIndex = 2;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new System.Drawing.Point(0, 284);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new System.Drawing.Size(163, 20);
            lblConfirm.TabIndex = 3;
            lblConfirm.Text = "Confirm new password:";
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new System.Drawing.Point(0, 315);
            txtConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new System.Drawing.Size(342, 27);
            txtConfirm.TabIndex = 3;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // btnReset
            // 
            btnReset.BackColor = System.Drawing.Color.SeaGreen;
            btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReset.ForeColor = System.Drawing.Color.White;
            btnReset.Location = new System.Drawing.Point(0, 387);
            btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(183, 48);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset password";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(400, 593);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(149, 43);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightYellow;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(571, 653);
            Controls.Add(lblInfo);
            Controls.Add(txtEmail);
            Controls.Add(btnContinue);
            Controls.Add(pnlReset);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ForgotPasswordForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Forgot password";
            pnlReset.ResumeLayout(false);
            pnlReset.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Panel pnlReset;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
    }
}
