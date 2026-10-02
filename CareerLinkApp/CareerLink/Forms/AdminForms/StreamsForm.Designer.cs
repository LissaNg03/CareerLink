namespace CareerLink
{
    partial class StreamsForm
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
            streamsTable = new System.Windows.Forms.DataGridView();
            btnAddStream = new System.Windows.Forms.Button();
            btnEditStream = new System.Windows.Forms.Button();
            btnDeleteStream = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)streamsTable).BeginInit();
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
            lblTitle.Text = "Manage Streams";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // streamsTable
            // 
            streamsTable.AllowUserToAddRows = false;
            streamsTable.AllowUserToDeleteRows = false;
            streamsTable.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            streamsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            streamsTable.ColumnHeadersHeight = 29;
            streamsTable.Location = new System.Drawing.Point(23, 93);
            streamsTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            streamsTable.MultiSelect = false;
            streamsTable.Name = "streamsTable";
            streamsTable.ReadOnly = true;
            streamsTable.RowHeadersVisible = false;
            streamsTable.RowHeadersWidth = 51;
            streamsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            streamsTable.Size = new System.Drawing.Size(869, 453);
            streamsTable.TabIndex = 1;
            // 
            // btnAddStream
            // 
            btnAddStream.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAddStream.Location = new System.Drawing.Point(23, 573);
            btnAddStream.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddStream.Name = "btnAddStream";
            btnAddStream.Size = new System.Drawing.Size(160, 51);
            btnAddStream.TabIndex = 2;
            btnAddStream.Text = "Add Stream";
            btnAddStream.UseVisualStyleBackColor = true;
            btnAddStream.Click += btnAddStream_Click;
            // 
            // btnEditStream
            // 
            btnEditStream.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnEditStream.Location = new System.Drawing.Point(194, 573);
            btnEditStream.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEditStream.Name = "btnEditStream";
            btnEditStream.Size = new System.Drawing.Size(160, 51);
            btnEditStream.TabIndex = 3;
            btnEditStream.Text = "Edit Stream";
            btnEditStream.UseVisualStyleBackColor = true;
            btnEditStream.Click += btnEditStream_Click;
            // 
            // btnDeleteStream
            // 
            btnDeleteStream.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnDeleteStream.Location = new System.Drawing.Point(366, 573);
            btnDeleteStream.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDeleteStream.Name = "btnDeleteStream";
            btnDeleteStream.Size = new System.Drawing.Size(160, 51);
            btnDeleteStream.TabIndex = 4;
            btnDeleteStream.Text = "Delete Stream";
            btnDeleteStream.UseVisualStyleBackColor = true;
            btnDeleteStream.Click += btnDeleteStream_Click;
            // 
            // StreamsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightYellow;
            ClientSize = new System.Drawing.Size(914, 653);
            Controls.Add(lblTitle);
            Controls.Add(streamsTable);
            Controls.Add(btnAddStream);
            Controls.Add(btnEditStream);
            Controls.Add(btnDeleteStream);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(797, 518);
            Name = "StreamsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Manage Streams";
            ((System.ComponentModel.ISupportInitialize)streamsTable).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView streamsTable;
        private System.Windows.Forms.Button btnAddStream;
        private System.Windows.Forms.Button btnEditStream;
        private System.Windows.Forms.Button btnDeleteStream;
    }
}
