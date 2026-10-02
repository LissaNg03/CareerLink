using System;
using System.Windows.Forms;
using CareerLink.BusinessLogic;
using CareerLink.Models;

namespace CareerLink
{
    public partial class StreamEditForm : Form
    {
        private readonly StreamService streamService = new StreamService();

        private int streamId = 0;                // 0 = creating a new stream

        public StreamEditForm()
        {
            InitializeComponent();

            cmbField.DisplayMember = "FieldName";
            cmbField.ValueMember = "FieldId";
            cmbField.DataSource = streamService.GetFields();
        }

        // fill the form with the stream's data for editing
        public void EditStream(StudyStream stream)
        {
            this.Text = "Edit Stream";
            this.lblAdd.Text = "EDIT STREAM";

            this.cmbField.SelectedValue = stream.FieldId;
            this.txtStreamName.Text = stream.StreamName;
            this.txtRequirements.Text = StreamService.RequirementsToText(stream.Requirements);

            this.streamId = stream.StreamId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbField.SelectedValue == null)
                    throw new BusinessRuleException("Please choose a field.");

                var stream = new StudyStream
                {
                    StreamId = this.streamId,
                    FieldId = (int)cmbField.SelectedValue,
                    StreamName = this.txtStreamName.Text,
                    Requirements = StreamService.ParseRequirements(this.txtRequirements.Text)
                };

                streamService.Save(stream);              // creates when StreamId is 0, otherwise updates
                this.DialogResult = DialogResult.OK;
            }
            catch (BusinessRuleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
