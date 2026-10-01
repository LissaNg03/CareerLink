namespace CareerLink
{
    partial class Learnships
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
            pnlLearnships = new System.Windows.Forms.Panel();
            lblLearnships = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlLearnships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlLearnships
            // 
            pnlLearnships.BackColor = System.Drawing.Color.DarkSlateGray;
            pnlLearnships.Controls.Add(lblLearnships);
            pnlLearnships.Dock = System.Windows.Forms.DockStyle.Top;
            pnlLearnships.Location = new System.Drawing.Point(0, 0);
            pnlLearnships.Name = "pnlLearnships";
            pnlLearnships.Size = new System.Drawing.Size(883, 92);
            pnlLearnships.TabIndex = 0;
            // 
            // lblLearnships
            // 
            lblLearnships.AutoSize = true;
            lblLearnships.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblLearnships.ForeColor = System.Drawing.Color.White;
            lblLearnships.Location = new System.Drawing.Point(12, 30);
            lblLearnships.Name = "lblLearnships";
            lblLearnships.Size = new System.Drawing.Size(152, 31);
            lblLearnships.TabIndex = 0;
            lblLearnships.Text = "LEARNSHIPS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Company, Position, Type, Deadline, Apply });
            dataGridView1.Location = new System.Drawing.Point(0, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(883, 195);
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
            // Learnships
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(883, 580);
            Controls.Add(dataGridView1);
            Controls.Add(pnlLearnships);
            Name = "Learnships";
            Text = "Learnships";
            pnlLearnships.ResumeLayout(false);
            pnlLearnships.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLearnships;
        private System.Windows.Forms.Label lblLearnships;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apply;
    }
}