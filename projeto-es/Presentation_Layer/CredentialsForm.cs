using projeto_es.Presentation_Layer;
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
    public partial class CredentialsForm : Form
    {
        public CredentialsForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void loginRegisterLabel_Click(object sender, EventArgs e)
        {

        }

        private void CredentialsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
