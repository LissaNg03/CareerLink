using System;
using System.Windows.Forms;
using CareerLink.BusinessLogic;

namespace CareerLink
{
    public partial class ForgotPasswordForm : Form
    {
        private readonly UserService userService = new UserService();

        private const string LockedMessage =
            "Too many wrong attempts. Please ask an administrator to reset your password.";

        // Opens Forgot Password without a pre-filled email
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        // Opens Forgot Password with an email already filled in
        public ForgotPasswordForm(string email)
        {
            InitializeComponent();

            txtEmail.Text = email;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.");
                return;
            }

            if (userService.IsLockedOut(email))
            {
                MessageBox.Show(LockedMessage);
                return;
            }

            var questions = userService.GetSecurityQuestions(email);

            if (questions == null)
            {
                MessageBox.Show(
                    "We couldn't find security questions for that email.\n" +
                    "Please check the address, or ask an administrator to reset your password.");

                return;
            }

            // Display the user's security questions
            lblQuestion1.Text = questions.Value.question1;
            lblQuestion2.Text = questions.Value.question2;

            // Prevent changing the email after questions are loaded
            txtEmail.ReadOnly = true;
            btnContinue.Enabled = false;

            // Show the password reset section
            pnlReset.Visible = true;

            txtAnswer1.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirm.Text;

            if (string.IsNullOrEmpty(newPassword) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter and confirm your new password.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("The two passwords don't match.");
                return;
            }

            try
            {
                userService.ResetPasswordWithAnswers(
                    email,
                    txtAnswer1.Text,
                    txtAnswer2.Text,
                    newPassword
                );

                MessageBox.Show(
                    "Your password has been changed. You can now log in.");

                DialogResult = DialogResult.OK;
            }
            catch (BusinessRuleException ex)
            {
                MessageBox.Show(ex.Message);

                if (userService.IsLockedOut(email))
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}