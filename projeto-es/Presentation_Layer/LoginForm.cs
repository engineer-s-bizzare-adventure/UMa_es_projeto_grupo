using projeto_es.Models;
using System;
using System.Windows.Forms;

namespace projeto_es.Presentation_Layer
{
    public partial class LoginForm : Form
    {
        public LoginForm(LoggedInSingleton loggedSingleton)
        {
            InitializeComponent();
            LoggedSingleton = loggedSingleton;
        }

        private LoggedInSingleton LoggedSingleton { get; set; }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            // Conta
            Account account = accountService.FetchAccount(emailTextBox.Text, passwordTextBox.Text);

            if (account == null)
            {
                MessageBox.Show("Error logging in! Check details.");
                return;
            }
            // Pessoa 
            Person personAssociatedToAccount = accountService.GetUserDataFromAccount(account.Email);
            //Session accountSession = new Session(account, personAssociatedToAccount
            LoggedSingleton.clientID = accountService.GetClientAccountId(account.Id);
            LoggedSingleton.Account = account;
            LoggedSingleton.Person = personAssociatedToAccount;
                
            this.Hide();
            Form userMenuForm = new UserMenuForm(LoggedSingleton);
            userMenuForm.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
