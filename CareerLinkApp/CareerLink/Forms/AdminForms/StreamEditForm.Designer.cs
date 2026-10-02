namespace CareerLink
{
    partial class StreamEditForm
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
            lblField = new System.Windows.Forms.Label();
            cmbField = new System.Windows.Forms.ComboBox();
            lblStream = new System.Windows.Forms.Label();
            txtStreamName = new System.Windows.Forms.TextBox();
            lblRequirements = new System.Windows.Forms.Label();
            txtRequirements = new System.Windows.Forms.TextBox();
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
            lblAdd.Size = new System.Drawing.Size(170, 32);
            lblAdd.TabIndex = 0;
            lblAdd.Text = "ADD STREAM";
            // 
            // lblField
            // 
            lblField.AutoSize = true;
            lblField.Location = new System.Drawing.Point(23, 91);
            lblField.Name = "lblField";
            lblField.Size = new System.Drawing.Size(44, 20);
            lblField.TabIndex = 1;
            lblField.Text = "Field:";
            // 
            // cmbField
            // 
            cmbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbField.FormattingEnabled = true;
            cmbField.Location = new System.Drawing.Point(194, 87);
            cmbField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbField.Name = "cmbField";
            cmbField.Size = new System.Drawing.Size(342, 28);
            cmbField.TabIndex = 2;
            // 
            // lblStream
            // 
            lblStream.AutoSize = true;
            lblStream.Location = new System.Drawing.Point(23, 144);
            lblStream.Name = "lblStream";
            lblStream.Size = new System.Drawing.Size(100, 20);
            lblStream.TabIndex = 3;
            lblStream.Text = "Stream name:";
            // 
            // txtStreamName
            // 
            txtStreamName.Location = new System.Drawing.Point(194, 140);
            txtStreamName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtStreamName.Name = "txtStreamName";
            txtStreamName.Size = new System.Drawing.Size(342, 27);
            txtStreamName.TabIndex = 4;
            // 
            // lblRequirements
            // 
            lblRequirements.AutoSize = true;
            lblRequirements.Location = new System.Drawing.Point(23, 197);
            lblRequirements.Name = "lblRequirements";
            lblRequirements.Size = new System.Drawing.Size(103, 20);
            lblRequirements.TabIndex = 5;
            lblRequirements.Text = "Requirements:";
            // 
            // txtRequirements
            // 
            txtRequirements.AcceptsReturn = true;
            txtRequirements.Location = new System.Drawing.Point(194, 193);
            txtRequirements.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtRequirements.Multiline = true;
            txtRequirements.Name = "txtRequirements";
            txtRequirements.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtRequirements.Size = new System.Drawing.Size(342, 199);
            txtRequirements.TabIndex = 6;
            // 
            // lblHint
            // 
            lblHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblHint.ForeColor = System.Drawing.Color.DimGray;
            lblHint.Location = new System.Drawing.Point(194, 400);
            lblHint.Name = "lblHint";
            lblHint.Size = new System.Drawing.Size(343, 48);
            lblHint.TabIndex = 7;
            lblHint.Text = "One per line: Subject: minimum %  (for example  Mathematics: 60)";
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.SeaGreen;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(194, 480);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(149, 48);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(389, 480);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(149, 48);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // StreamEditForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightYellow;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(571, 553);
            Controls.Add(lblAdd);
            Controls.Add(lblField);
            Controls.Add(cmbField);
            Controls.Add(lblStream);
            Controls.Add(txtStreamName);
            Controls.Add(lblRequirements);
            Controls.Add(txtRequirements);
            Controls.Add(lblHint);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StreamEditForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Add Stream";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.Label lblStream;
        private System.Windows.Forms.TextBox txtStreamName;
        private System.Windows.Forms.Label lblRequirements;
        private System.Windows.Forms.TextBox txtRequirements;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
