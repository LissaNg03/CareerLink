using System;
using System.Windows.Forms;
using CareerLink.BusinessLogic;
using CareerLink.Models;

namespace CareerLink
{
    public partial class SignUpForm : Form
    {
        private readonly UserService userService = new UserService();

       
        public bool AutoLogin { get; set; } = true;

        private readonly bool isFirstUser;

        public SignUpForm()
        {
            InitializeComponent();

            cmbQuestion1.Items.AddRange(SecurityQuestions.All);
            cmbQuestion2.Items.AddRange(SecurityQuestions.All);

            
            isFirstUser = userService.IsFirstUser();

            if (isFirstUser)
            {
                cmbUserType.Items.Add(UserTypes.Admin);
                cmbUserType.SelectedIndex = 0;
                cmbUserType.Enabled = false;
            }
            else
            {
                cmbUserType.Items.AddRange(UserTypes.SignUp);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
               
                User created = userService.Register(
                    txtFirstName.Text, txtSurname.Text, txtEmail.Text, txtPassword.Text,
                    cmbUserType.SelectedItem?.ToString(),
                    cmbQuestion1.SelectedItem?.ToString(), txtAnswer1.Text,
                    cmbQuestion2.SelectedItem?.ToString(), txtAnswer2.Text);

                if (AutoLogin)
                    Session.CurrentUser = created;  
                else
                    MessageBox.Show("User added.");

                DialogResult = DialogResult.OK;      
            }
            catch (BusinessRuleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
