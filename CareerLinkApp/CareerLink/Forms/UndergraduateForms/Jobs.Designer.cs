namespace CareerLink
{
    partial class Jobs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlJobs = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlJobs
            // 
            pnlJobs.BackColor = System.Drawing.Color.DarkSlateGray;
            pnlJobs.Controls.Add(label1);
            pnlJobs.Dock = System.Windows.Forms.DockStyle.Top;
            pnlJobs.Location = new System.Drawing.Point(0, 0);
            pnlJobs.Name = "pnlJobs";
            pnlJobs.Size = new System.Drawing.Size(876, 102);
            pnlJobs.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 31);
            label1.TabIndex = 0;
            label1.Text = "JOBS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Company, Position, Type, Deadline, Apply });
            dataGridView1.Location = new System.Drawing.Point(0, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(876, 188);
            dataGridView1.TabIndex = 1;
            // 
            // Company
            // 
            Company.HeaderText = "Company";
            Company.MinimumWidth = 6;
            Company.Name = "Company";
            Company.Width = 160;
            // 
            // Position
            // 
            Position.HeaderText = "Position";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            Position.Width = 160;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 160;
            // 
            // Deadline
            // 
            Deadline.HeaderText = "Deadline";
            Deadline.MinimumWidth = 6;
            Deadline.Name = "Deadline";
            Deadline.Width = 160;
            // 
            // Apply
            // 
            Apply.HeaderText = "Apply";
            Apply.MinimumWidth = 6;
            Apply.Name = "Apply";
            Apply.Width = 200;
            // 
            // Jobs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(876, 583);
            Controls.Add(dataGridView1);
            Controls.Add(pnlJobs);
            Name = "Jobs";
            Text = "Jobs";
            pnlJobs.ResumeLayout(false);
            pnlJobs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlJobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apply;
    }
}