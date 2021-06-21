using projeto_es.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_es.Presentation_Layer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            Account account = accountService.FetchAccount(emailTextBox.Text, passwordTextBox.Text);

            if (account == null)
            {
                MessageBox.Show("Error logging in! Check details.");
                return;
            }

            Person PersonAssociatedToAccount = accountService.GetUserDataFromAccount(account.Email);
            Session accountSession = new Session(account, PersonAssociatedToAccount);

            this.Hide();
            Form userMenuForm = new UserMenuForm(accountSession);
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
