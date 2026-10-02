namespace CareerLink
{
    partial class UserEditForm
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
            lblFirstName = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            lblSurname = new System.Windows.Forms.Label();
            txtSurname = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblUserType = new System.Windows.Forms.Label();
            cmbUserType = new System.Windows.Forms.ComboBox();
            lblNewPassword = new System.Windows.Forms.Label();
            txtNewPassword = new System.Windows.Forms.TextBox();
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
            lblAdd.Size = new System.Drawing.Size(133, 32);
            lblAdd.TabIndex = 0;
            lblAdd.Text = "EDIT USER";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(23, 91);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(83, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(194, 87);
            txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(319, 27);
            txtFirstName.TabIndex = 2;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new System.Drawing.Point(23, 144);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new System.Drawing.Size(70, 20);
            lblSurname.TabIndex = 3;
            lblSurname.Text = "Surname:";
            // 
            // txtSurname
            // 
            txtSurname.Location = new System.Drawing.Point(194, 140);
            txtSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new System.Drawing.Size(319, 27);
            txtSurname.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(23, 197);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(49, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(194, 193);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(319, 27);
            txtEmail.TabIndex = 6;
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Location = new System.Drawing.Point(23, 251);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new System.Drawing.Size(76, 20);
            lblUserType.TabIndex = 7;
            lblUserType.Text = "User Type:";
            // 
            // cmbUserType
            // 
            cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Location = new System.Drawing.Point(194, 247);
            cmbUserType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new System.Drawing.Size(319, 28);
            cmbUserType.TabIndex = 8;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new System.Drawing.Point(23, 304);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new System.Drawing.Size(109, 20);
            lblNewPassword.TabIndex = 9;
            lblNewPassword.Text = "New password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new System.Drawing.Point(194, 300);
            txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new System.Drawing.Size(319, 27);
            txtNewPassword.TabIndex = 10;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblHint.ForeColor = System.Drawing.Color.DimGray;
            lblHint.Location = new System.Drawing.Point(194, 340);
            lblHint.Name = "lblHint";
            lblHint.Size = new System.Drawing.Size(286, 20);
            lblHint.TabIndex = 11;
            lblHint.Text = "Leave blank to keep the current password.";
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.SeaGreen;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(194, 413);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(149, 48);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(366, 413);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(149, 48);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // UserEditForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightYellow;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(549, 500);
            Controls.Add(lblAdd);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblSurname);
            Controls.Add(txtSurname);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblUserType);
            Controls.Add(cmbUserType);
            Controls.Add(lblNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblHint);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserEditForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Edit User";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
