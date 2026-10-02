namespace CareerLink
{
    partial class UsersForm
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
            lblTitle = new System.Windows.Forms.Label();
            usersTable = new System.Windows.Forms.DataGridView();
            btnAddUser = new System.Windows.Forms.Button();
            btnEditUser = new System.Windows.Forms.Button();
            btnDeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)usersTable).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(0, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(914, 53);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Users";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usersTable
            // 
            usersTable.AllowUserToAddRows = false;
            usersTable.AllowUserToDeleteRows = false;
            usersTable.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            usersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            usersTable.ColumnHeadersHeight = 29;
            usersTable.Location = new System.Drawing.Point(23, 93);
            usersTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            usersTable.MultiSelect = false;
            usersTable.Name = "usersTable";
            usersTable.ReadOnly = true;
            usersTable.RowHeadersVisible = false;
            usersTable.RowHeadersWidth = 51;
            usersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            usersTable.Size = new System.Drawing.Size(869, 453);
            usersTable.TabIndex = 1;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAddUser.Location = new System.Drawing.Point(23, 573);
            btnAddUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new System.Drawing.Size(160, 51);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnEditUser.Location = new System.Drawing.Point(194, 573);
            btnEditUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new System.Drawing.Size(160, 51);
            btnEditUser.TabIndex = 3;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnDeleteUser.Location = new System.Drawing.Point(366, 573);
            btnDeleteUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new System.Drawing.Size(160, 51);
            btnDeleteUser.TabIndex = 4;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightYellow;
            ClientSize = new System.Drawing.Size(914, 653);
            Controls.Add(lblTitle);
            Controls.Add(usersTable);
            Controls.Add(btnAddUser);
            Controls.Add(btnEditUser);
            Controls.Add(btnDeleteUser);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(797, 518);
            Name = "UsersForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Manage Users";
            ((System.ComponentModel.ISupportInitialize)usersTable).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView usersTable;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}
