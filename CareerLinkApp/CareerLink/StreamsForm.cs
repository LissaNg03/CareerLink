using System;
using System.Data;
using System.Windows.Forms;
using CareerLink.BusinessLogic;
using CareerLink.Models;

namespace CareerLink
{
    public partial class StreamsForm : Form
    {
        private readonly StreamService streamService = new StreamService();

        public StreamsForm()
        {
            InitializeComponent();
            ReadStreams();
        }

        private void ReadStreams()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Stream ID", typeof(int));
            dataTable.Columns.Add("Field", typeof(string));
            dataTable.Columns.Add("Stream", typeof(string));
            dataTable.Columns.Add("Requirements", typeof(string));

            foreach (StudyStream stream in streamService.GetAllStreams())
                dataTable.Rows.Add(stream.StreamId, stream.FieldName, stream.StreamName,
                                   StreamService.RequirementsSummary(stream.Requirements));

            this.streamsTable.DataSource = dataTable;
        }

        private int? SelectedStreamId()
        {
            if (streamsTable.SelectedRows.Count == 0) return null;
            return Convert.ToInt32(streamsTable.SelectedRows[0].Cells[0].Value);
        }

        private void btnAddStream_Click(object sender, EventArgs e)
        {
            using (var form = new StreamEditForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    ReadStreams();
            }
        }

        private void btnEditStream_Click(object sender, EventArgs e)
        {
            int? streamId = SelectedStreamId();
            if (streamId == null)
            {
                MessageBox.Show("Please select a stream first.");
                return;
            }

            StudyStream stream = streamService.GetStream(streamId.Value);
            if (stream == null) { ReadStreams(); return; }

            using (var form = new StreamEditForm())
            {
                form.EditStream(stream);
                if (form.ShowDialog(this) == DialogResult.OK)
                    ReadStreams();
            }
        }

        private void btnDeleteStream_Click(object sender, EventArgs e)
        {
            int? streamId = SelectedStreamId();
            if (streamId == null)
            {
                MessageBox.Show("Please select a stream first.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this stream?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No) return;

            streamService.DeleteStream(streamId.Value);
            ReadStreams();
        }
    }
}
