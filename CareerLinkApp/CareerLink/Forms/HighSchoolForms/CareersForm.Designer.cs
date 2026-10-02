namespace CareerLink
{
    partial class CareersForm
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
            careersTable = new System.Windows.Forms.DataGridView();
            btnAddCareer = new System.Windows.Forms.Button();
            btnEditCareer = new System.Windows.Forms.Button();
            btnDeleteCareer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)careersTable).BeginInit();
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
            lblTitle.Text = "Manage Careers";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // careersTable
            // 
            careersTable.AllowUserToAddRows = false;
            careersTable.AllowUserToDeleteRows = false;
            careersTable.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            careersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            careersTable.ColumnHeadersHeight = 29;
            careersTable.Location = new System.Drawing.Point(23, 93);
            careersTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            careersTable.MultiSelect = false;
            careersTable.Name = "careersTable";
            careersTable.ReadOnly = true;
            careersTable.RowHeadersVisible = false;
            careersTable.RowHeadersWidth = 51;
            careersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            careersTable.Size = new System.Drawing.Size(869, 453);
            careersTable.TabIndex = 1;
            // 
            // btnAddCareer
            // 
            btnAddCareer.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAddCareer.Location = new System.Drawing.Point(23, 573);
            btnAddCareer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddCareer.Name = "btnAddCareer";
            btnAddCareer.Size = new System.Drawing.Size(160, 51);
            btnAddCareer.TabIndex = 2;
            btnAddCareer.Text = "Add Career";
            btnAddCareer.UseVisualStyleBackColor = true;
            btnAddCareer.Click += btnAddCareer_Click;
            // 
            // btnEditCareer
            // 
            btnEditCareer.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnEditCareer.Location = new System.Drawing.Point(194, 573);
            btnEditCareer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEditCareer.Name = "btnEditCareer";
            btnEditCareer.Size = new System.Drawing.Size(160, 51);
            btnEditCareer.TabIndex = 3;
            btnEditCareer.Text = "Edit Career";
            btnEditCareer.UseVisualStyleBackColor = true;
            btnEditCareer.Click += btnEditCareer_Click;
            // 
            // btnDeleteCareer
            // 
            btnDeleteCareer.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnDeleteCareer.Location = new System.Drawing.Point(366, 573);
            btnDeleteCareer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDeleteCareer.Name = "btnDeleteCareer";
            btnDeleteCareer.Size = new System.Drawing.Size(160, 51);
            btnDeleteCareer.TabIndex = 4;
            btnDeleteCareer.Text = "Delete Career";
            btnDeleteCareer.UseVisualStyleBackColor = true;
            btnDeleteCareer.Click += btnDeleteCareer_Click;
            // 
            // CareersForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightYellow;
            ClientSize = new System.Drawing.Size(914, 653);
            Controls.Add(lblTitle);
            Controls.Add(careersTable);
            Controls.Add(btnAddCareer);
            Controls.Add(btnEditCareer);
            Controls.Add(btnDeleteCareer);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(797, 518);
            Name = "CareersForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Manage Careers";
            ((System.ComponentModel.ISupportInitialize)careersTable).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView careersTable;
        private System.Windows.Forms.Button btnAddCareer;
        private System.Windows.Forms.Button btnEditCareer;
        private System.Windows.Forms.Button btnDeleteCareer;
    }
}
