using System;
using System.Data;
using System.Windows.Forms;
using CareerLink.BusinessLogic;
using CareerLink.Models;

namespace CareerLink
{
    // Manage Users: DataGridView + Add / Edit / Delete (same pattern as the lecture's Products Manager)
    public partial class UsersForm : Form
    {
        private readonly UserService userService = new UserService();

        public UsersForm()
        {
            InitializeComponent();
            ReadUsers();                         // show the users when the form opens
        }

        // read users from the database into the DataGridView
        private void ReadUsers()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("User ID", typeof(int));
            dataTable.Columns.Add("First Name", typeof(string));
            dataTable.Columns.Add("Surname", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("User Type", typeof(string));

            foreach (User user in userService.GetAllUsers())
                dataTable.Rows.Add(user.UserId, user.FirstName, user.Surname, user.Email, user.UserType);

            this.usersTable.DataSource = dataTable;
        }

        // the ID is in the first cell of the selected row
        private int? SelectedUserId()
        {
            if (usersTable.SelectedRows.Count == 0) return null;
            return Convert.ToInt32(usersTable.SelectedRows[0].Cells[0].Value);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // an Admin adding a user: the Admin must stay logged in, so AutoLogin is off
            using (var form = new SignUpForm { AutoLogin = false })
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    ReadUsers();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            int? userId = SelectedUserId();
            if (userId == null)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            User user = userService.GetUser(userId.Value);
            if (user == null) { ReadUsers(); return; }

            using (var form = new UserEditForm())
            {
                form.EditUser(user);
                if (form.ShowDialog(this) == DialogResult.OK)
                    ReadUsers();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int? userId = SelectedUserId();
            if (userId == null)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this user?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No) return;

            try
            {
                userService.DeleteUser(userId.Value, Session.CurrentUser.UserId);
                ReadUsers();
            }
            catch (BusinessRuleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
