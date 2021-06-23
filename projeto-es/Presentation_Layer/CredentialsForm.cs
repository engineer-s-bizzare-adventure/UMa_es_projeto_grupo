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
        private Form login = null;
        private Form register = null;

        // Verificar se há maneira de juntar o LoginForm e o RegisterForm
        public CredentialsForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (login == null)
            {
                Form loginForm = new LoginForm(this);
                login = loginForm;
                loginForm.Show();
            }
            else
            {
                login.Show();
            }
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (register == null)
            {
                Form registerForm = new RegisterForm(this);
                register = registerForm;
                registerForm.Show();
            }
            else
            {
                register.Show();
            }
        }

        private void close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void ShowMe(MainMenuStaff mmStaff)
        {
            mmStaff.Close();
            Show();
        }
    }
}
