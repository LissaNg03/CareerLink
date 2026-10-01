namespace CareerLink
{
    partial class Internships
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
            pnlinternships = new System.Windows.Forms.Panel();
            lblinternships = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlinternships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlinternships
            // 
            pnlinternships.BackColor = System.Drawing.Color.DarkSlateGray;
            pnlinternships.Controls.Add(lblinternships);
            pnlinternships.Dock = System.Windows.Forms.DockStyle.Top;
            pnlinternships.Location = new System.Drawing.Point(0, 0);
            pnlinternships.Name = "pnlinternships";
            pnlinternships.Size = new System.Drawing.Size(901, 82);
            pnlinternships.TabIndex = 0;
            // 
            // lblinternships
            // 
            lblinternships.AutoSize = true;
            lblinternships.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblinternships.ForeColor = System.Drawing.Color.White;
            lblinternships.Location = new System.Drawing.Point(12, 22);
            lblinternships.Name = "lblinternships";
            lblinternships.Size = new System.Drawing.Size(162, 31);
            lblinternships.TabIndex = 0;
            lblinternships.Text = "INTERNSHIPS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Company, Position, Type, Deadline, Apply });
            dataGridView1.Location = new System.Drawing.Point(0, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(898, 239);
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
            // Internships
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightYellow;
            ClientSize = new System.Drawing.Size(901, 610);
            Controls.Add(dataGridView1);
            Controls.Add(pnlinternships);
            Name = "Internships";
            Text = "Internships";
            pnlinternships.ResumeLayout(false);
            pnlinternships.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlinternships;
        private System.Windows.Forms.Label lblinternships;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apply;
    }
}