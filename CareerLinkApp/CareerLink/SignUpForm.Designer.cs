namespace CareerLink
{
    partial class SignUpForm
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
            lblFirstName = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            lblSurname = new System.Windows.Forms.Label();
            txtSurname = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lblUserType = new System.Windows.Forms.Label();
            cmbUserType = new System.Windows.Forms.ComboBox();
            lblSecurity = new System.Windows.Forms.Label();
            lblQuestion1 = new System.Windows.Forms.Label();
            cmbQuestion1 = new System.Windows.Forms.ComboBox();
            lblAnswer1 = new System.Windows.Forms.Label();
            txtAnswer1 = new System.Windows.Forms.TextBox();
            lblQuestion2 = new System.Windows.Forms.Label();
            cmbQuestion2 = new System.Windows.Forms.ComboBox();
            lblAnswer2 = new System.Windows.Forms.Label();
            txtAnswer2 = new System.Windows.Forms.TextBox();
            btnSignUp = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblFirstName.Location = new System.Drawing.Point(46, 44);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(110, 28);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtFirstName.Location = new System.Drawing.Point(229, 40);
            txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(308, 32);
            txtFirstName.TabIndex = 0;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSurname.Location = new System.Drawing.Point(46, 111);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new System.Drawing.Size(93, 28);
            lblSurname.TabIndex = 1;
            lblSurname.Text = "Surname:";
            // 
            // txtSurname
            // 
            txtSurname.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtSurname.Location = new System.Drawing.Point(229, 107);
            txtSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new System.Drawing.Size(308, 32);
            txtSurname.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblEmail.Location = new System.Drawing.Point(46, 177);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(63, 28);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtEmail.Location = new System.Drawing.Point(229, 173);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(308, 32);
            txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblPassword.Location = new System.Drawing.Point(46, 244);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(97, 28);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtPassword.Location = new System.Drawing.Point(229, 240);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(308, 32);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblUserType.Location = new System.Drawing.Point(46, 311);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new System.Drawing.Size(101, 28);
            lblUserType.TabIndex = 4;
            lblUserType.Text = "User Type:";
            // 
            // cmbUserType
            // 
            cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbUserType.Font = new System.Drawing.Font("Segoe UI", 11F);
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Location = new System.Drawing.Point(229, 307);
            cmbUserType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new System.Drawing.Size(308, 33);
            cmbUserType.TabIndex = 4;
            // 
            // lblSecurity
            // 
            lblSecurity.AutoSize = true;
            lblSecurity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            lblSecurity.Location = new System.Drawing.Point(46, 373);
            lblSecurity.Name = "lblSecurity";
            lblSecurity.Size = new System.Drawing.Size(391, 23);
            lblSecurity.TabIndex = 5;
            lblSecurity.Text = "Security questions (used if you forget your password)";
            // 
            // lblQuestion1
            // 
            lblQuestion1.AutoSize = true;
            lblQuestion1.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblQuestion1.Location = new System.Drawing.Point(46, 424);
            lblQuestion1.Name = "lblQuestion1";
            lblQuestion1.Size = new System.Drawing.Size(111, 28);
            lblQuestion1.TabIndex = 6;
            lblQuestion1.Text = "Question 1:";
            // 
            // cmbQuestion1
            // 
            cmbQuestion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbQuestion1.DropDownWidth = 380;
            cmbQuestion1.Font = new System.Drawing.Font("Segoe UI", 11F);
            cmbQuestion1.FormattingEnabled = true;
            cmbQuestion1.Location = new System.Drawing.Point(229, 420);
            cmbQuestion1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbQuestion1.Name = "cmbQuestion1";
            cmbQuestion1.Size = new System.Drawing.Size(308, 33);
            cmbQuestion1.TabIndex = 5;
            // 
            // lblAnswer1
            // 
            lblAnswer1.AutoSize = true;
            lblAnswer1.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblAnswer1.Location = new System.Drawing.Point(46, 484);
            lblAnswer1.Name = "lblAnswer1";
            lblAnswer1.Size = new System.Drawing.Size(95, 28);
            lblAnswer1.TabIndex = 7;
            lblAnswer1.Text = "Answer 1:";
            // 
            // txtAnswer1
            // 
            txtAnswer1.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtAnswer1.Location = new System.Drawing.Point(229, 480);
            txtAnswer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAnswer1.Name = "txtAnswer1";
            txtAnswer1.Size = new System.Drawing.Size(308, 32);
            txtAnswer1.TabIndex = 6;
            // 
            // lblQuestion2
            // 
            lblQuestion2.AutoSize = true;
            lblQuestion2.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblQuestion2.Location = new System.Drawing.Point(46, 551);
            lblQuestion2.Name = "lblQuestion2";
            lblQuestion2.Size = new System.Drawing.Size(111, 28);
            lblQuestion2.TabIndex = 8;
            lblQuestion2.Text = "Question 2:";
            // 
            // cmbQuestion2
            // 
            cmbQuestion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbQuestion2.DropDownWidth = 380;
            cmbQuestion2.Font = new System.Drawing.Font("Segoe UI", 11F);
            cmbQuestion2.FormattingEnabled = true;
            cmbQuestion2.Location = new System.Drawing.Point(229, 547);
            cmbQuestion2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbQuestion2.Name = "cmbQuestion2";
            cmbQuestion2.Size = new System.Drawing.Size(308, 33);
            cmbQuestion2.TabIndex = 7;
            // 
            // lblAnswer2
            // 
            lblAnswer2.AutoSize = true;
            lblAnswer2.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblAnswer2.Location = new System.Drawing.Point(46, 617);
            lblAnswer2.Name = "lblAnswer2";
            lblAnswer2.Size = new System.Drawing.Size(95, 28);
            lblAnswer2.TabIndex = 9;
            lblAnswer2.Text = "Answer 2:";
            // 
            // txtAnswer2
            // 
            txtAnswer2.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtAnswer2.Location = new System.Drawing.Point(229, 613);
            txtAnswer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAnswer2.Name = "txtAnswer2";
            txtAnswer2.Size = new System.Drawing.Size(308, 32);
            txtAnswer2.TabIndex = 8;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = System.Drawing.Color.SeaGreen;
            btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSignUp.Font = new System.Drawing.Font("Segoe UI", 11F);
            btnSignUp.ForeColor = System.Drawing.Color.White;
            btnSignUp.Location = new System.Drawing.Point(229, 693);
            btnSignUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new System.Drawing.Size(149, 51);
            btnSignUp.TabIndex = 9;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.DarkGray;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F);
            btnCancel.Location = new System.Drawing.Point(394, 693);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(143, 51);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // SignUpForm
            // 
            AcceptButton = btnSignUp;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightYellow;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(594, 780);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblSurname);
            Controls.Add(txtSurname);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblUserType);
            Controls.Add(cmbUserType);
            Controls.Add(lblSecurity);
            Controls.Add(lblQuestion1);
            Controls.Add(cmbQuestion1);
            Controls.Add(lblAnswer1);
            Controls.Add(txtAnswer1);
            Controls.Add(lblQuestion2);
            Controls.Add(cmbQuestion2);
            Controls.Add(lblAnswer2);
            Controls.Add(txtAnswer2);
            Controls.Add(btnSignUp);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignUpForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.ComboBox cmbQuestion1;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.ComboBox cmbQuestion2;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnCancel;
    }
}
