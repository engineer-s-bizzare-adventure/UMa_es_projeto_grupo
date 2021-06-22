using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_es
{
    public partial class RegisterForm : Form
    {
        private CredentialsForm credentialsForm_;
        public RegisterForm(CredentialsForm credentials)
        {
            credentialsForm_ = credentials;
            InitializeComponent();
            credentialsForm_.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            credentialsForm_.Show();
        }

        private void close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void view_password(object sender, MouseEventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
        }
    }
}
