using System;
using System.Windows.Forms;
using CareerLink.BusinessLogic;

namespace CareerLink
{
    public partial class MainForm : Form
    {
        private readonly UserService userService = new UserService();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Session.CurrentUser = userService.Login(
                    txtUsername.Text,
                    txtPassword.Text
                );

                Close();
            }
            catch (BusinessRuleException ex)
            {
                MessageBox.Show(ex.Message);

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (var form = new SignUpForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK &&
                    Session.CurrentUser != null)
                {
                    Close();
                }
            }
        }

        private void lnkForgot_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            string email = txtUsername.Text.Trim();

            using (var form = new ForgotPasswordForm(email))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
        }
    }
}