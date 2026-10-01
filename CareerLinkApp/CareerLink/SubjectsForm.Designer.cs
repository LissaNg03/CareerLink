namespace CareerLink
{
    partial class SubjectsForm
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
            subjectsTable = new System.Windows.Forms.DataGridView();
            btnAddSubject = new System.Windows.Forms.Button();
            btnEditSubject = new System.Windows.Forms.Button();
            btnDeleteSubject = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)subjectsTable).BeginInit();
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
            lblTitle.Text = "Manage Subjects";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subjectsTable
            // 
            subjectsTable.AllowUserToAddRows = false;
            subjectsTable.AllowUserToDeleteRows = false;
            subjectsTable.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            subjectsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            subjectsTable.ColumnHeadersHeight = 29;
            subjectsTable.Location = new System.Drawing.Point(23, 93);
            subjectsTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            subjectsTable.MultiSelect = false;
            subjectsTable.Name = "subjectsTable";
            subjectsTable.ReadOnly = true;
            subjectsTable.RowHeadersVisible = false;
            subjectsTable.RowHeadersWidth = 51;
            subjectsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            subjectsTable.Size = new System.Drawing.Size(869, 453);
            subjectsTable.TabIndex = 1;
            // 
            // btnAddSubject
            // 
            btnAddSubject.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAddSubject.Location = new System.Drawing.Point(23, 573);
            btnAddSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new System.Drawing.Size(160, 51);
            btnAddSubject.TabIndex = 2;
            btnAddSubject.Text = "Add Subject";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // btnEditSubject
            // 
            btnEditSubject.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnEditSubject.Location = new System.Drawing.Point(194, 573);
            btnEditSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEditSubject.Name = "btnEditSubject";
            btnEditSubject.Size = new System.Drawing.Size(160, 51);
            btnEditSubject.TabIndex = 3;
            btnEditSubject.Text = "Edit Subject";
            btnEditSubject.UseVisualStyleBackColor = true;
            btnEditSubject.Click += btnEditSubject_Click;
            // 
            // btnDeleteSubject
            // 
            btnDeleteSubject.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnDeleteSubject.Location = new System.Drawing.Point(366, 573);
            btnDeleteSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDeleteSubject.Name = "btnDeleteSubject";
            btnDeleteSubject.Size = new System.Drawing.Size(160, 51);
            btnDeleteSubject.TabIndex = 4;
            btnDeleteSubject.Text = "Delete Subject";
            btnDeleteSubject.UseVisualStyleBackColor = true;
            btnDeleteSubject.Click += btnDeleteSubject_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            txtSearch.Location = new System.Drawing.Point(686, 583);
            txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search subjects";
            txtSearch.Size = new System.Drawing.Size(205, 27);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // SubjectsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightYellow;
            ClientSize = new System.Drawing.Size(914, 653);
            Controls.Add(lblTitle);
            Controls.Add(subjectsTable);
            Controls.Add(btnAddSubject);
            Controls.Add(btnEditSubject);
            Controls.Add(btnDeleteSubject);
            Controls.Add(txtSearch);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(797, 518);
            Name = "SubjectsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Manage Subjects";
            ((System.ComponentModel.ISupportInitialize)subjectsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView subjectsTable;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnEditSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
