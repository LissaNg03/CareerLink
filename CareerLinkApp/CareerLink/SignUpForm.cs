using System;
using System.ComponentModel;
using System.Windows.Forms;
using CareerLink.BusinessLogic;
using CareerLink.Models;

namespace CareerLink
{
    public partial class SignUpForm : Form
    {
        private readonly UserService userService = new UserService();

        private readonly bool isFirstUser;

        // Runtime property only.
        // The WinForms Designer should not serialize this property.
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AutoLogin { get; set; } = true;

        public SignUpForm()
        {
            InitializeComponent();

            // Load security questions
            cmbQuestion1.Items.AddRange(SecurityQuestions.All);
            cmbQuestion2.Items.AddRange(SecurityQuestions.All);

            // Check whether this is the first registered user
            isFirstUser = userService.IsFirstUser();

            if (isFirstUser)
            {
                // First user must be an Admin
                cmbUserType.Items.Add(UserTypes.Admin);
                cmbUserType.SelectedIndex = 0;
                cmbUserType.Enabled = false;
            }
            else
            {
                // Other users can choose from available signup roles
                cmbUserType.Items.AddRange(UserTypes.SignUp);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                User created = userService.Register(
                    txtFirstName.Text.Trim(),
                    txtSurname.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtPassword.Text,
                    cmbUserType.SelectedItem?.ToString(),
                    cmbQuestion1.SelectedItem?.ToString(),
                    txtAnswer1.Text.Trim(),
                    cmbQuestion2.SelectedItem?.ToString(),
                    txtAnswer2.Text.Trim()
                );

                if (AutoLogin)
                {
                    Session.CurrentUser = created;
                }
                else
                {
                    MessageBox.Show("User added.");
                }

                DialogResult = DialogResult.OK;
            }
            catch (BusinessRuleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}