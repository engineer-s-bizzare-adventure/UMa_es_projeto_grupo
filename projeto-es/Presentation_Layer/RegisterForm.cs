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
            PersonService NewPerson = new PersonService();
            AccountService newRegisteredAccount = new AccountService();
            ClientAccountService NewClientAccountService = new ClientAccountService();

            NewPerson.InsertPerson(new Person()
            {
                name = accountName.Text,
                age = Int16.Parse(accountAge.Text),
                address = accountAddress.Text,
            });
            newRegisteredAccount.CreateAccount(new Account()
            {
                Email = emailTextBox.Text,
                Password = passwordTextBox.Text,
            });
            NewClientAccountService.CreateClientAccount();
            this.DialogResult = DialogResult.OK;
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void accountName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void accountAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void accountAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
