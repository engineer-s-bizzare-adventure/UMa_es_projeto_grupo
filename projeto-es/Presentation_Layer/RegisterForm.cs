using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_es.Models;

namespace projeto_es
{
    public partial class RegisterForm : Form
    {
        AccountService accountService = new AccountService();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerLabel_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            AccountService newRegisteredAccount = new AccountService();
            newRegisteredAccount.CreateAccount(new Account()
            {
                Email = emailTextBox.Text,
                Password = passwordTextBox.Text,
            }); ;
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }
    }
}
