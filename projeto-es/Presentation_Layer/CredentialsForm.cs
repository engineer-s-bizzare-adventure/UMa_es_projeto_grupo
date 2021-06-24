using projeto_es.Models;
using projeto_es.Presentation_Layer;
using System;
using System.Windows.Forms;


namespace projeto_es
{
    public partial class CredentialsForm : Form
    {
        public CredentialsForm(LoggedInSingleton loggedInSingleton)
        {
            InitializeComponent();
            LoggedSingleton = loggedInSingleton;
        }
        private LoggedInSingleton LoggedSingleton { get; set; }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loginForm = new LoginForm(LoggedSingleton);
            loginForm.ShowDialog();
            this.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Show();
        }

        private void loginRegisterLabel_Click(object sender, EventArgs e)
        {

        }

        private void CredentialsForm_Load(object sender, EventArgs e) {

        }
    }
}
