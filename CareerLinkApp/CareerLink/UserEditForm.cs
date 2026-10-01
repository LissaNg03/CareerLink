using System;
using System.Windows.Forms;
using CareerLink.BusinessLogic;
using CareerLink.Models;

namespace CareerLink
{
    public partial class UserEditForm : Form
    {
        private readonly UserService userService = new UserService();

        private int userId = 0;                  // the user being edited

        public UserEditForm()
        {
            InitializeComponent();
            cmbUserType.Items.AddRange(UserTypes.All);
        }

        // fill the form with the user's data for editing
        public void EditUser(User user)
        {
            this.Text = "Edit User";
            this.lblAdd.Text = "EDIT USER";

            this.txtFirstName.Text = user.FirstName;
            this.txtSurname.Text = user.Surname;
            this.txtEmail.Text = user.Email;
            this.cmbUserType.SelectedItem = user.UserType;

            this.userId = user.UserId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                UserId = this.userId,
                FirstName = this.txtFirstName.Text,
                Surname = this.txtSurname.Text,
                Email = this.txtEmail.Text,
                UserType = this.cmbUserType.SelectedItem?.ToString()
            };

            try
            {
                int actingUserId = Session.CurrentUser.UserId;

                userService.UpdateUser(user, actingUserId, this.txtNewPassword.Text);

                // if the Admin edited their own account, keep the session in step
                if (this.userId == actingUserId)
                    Session.CurrentUser = userService.GetUser(this.userId);

                this.DialogResult = DialogResult.OK;   // closes the form
            }
            catch (BusinessRuleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
