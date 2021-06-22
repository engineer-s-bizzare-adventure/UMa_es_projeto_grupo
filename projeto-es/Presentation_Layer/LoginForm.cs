using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_es.Presentation_Layer
{
    public partial class LoginForm : Form
    {
        private CredentialsForm credentialsForm_;
        private Dictionary<String, String> autentification;
        public LoginForm(CredentialsForm credentials)
        {
            credentialsForm_ = credentials;
            InitializeComponent();
            label_wrong.Visible = false;
            autentification = new Dictionary<string, string>();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\pedro\OneDrive\Área de Trabalho\autentifica.txt");
            for (int index=0; index<lines.Length; index+=2)
            {
                autentification.Add(lines[index], lines[index+1]);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            List<String> keys = new List<string>(), values = new List<string>();
            keys.AddRange(autentification.Keys);
            values.AddRange(autentification.Values);
            bool canGo = false;
            for (int autentiNumber = 0; autentiNumber < autentification.Count; autentiNumber++)
            {
                if (emailTextBox.Text.ToLower() == keys[autentiNumber] && passwordTextBox.Text.ToLower() == values[autentiNumber])
                {
                    canGo = true;
                }
            }
            if (canGo)
            {
                this.Hide();
                credentialsForm_.Hide();
                var menuStaff = new MainMenuStaff(emailTextBox.Text, credentialsForm_);
                menuStaff.ShowDialog();
            }
            else
            {
                emailTextBox.Text = "";
                passwordTextBox.Text = "";
                label_wrong.Text = @"Sorry, but the email or the password is wrong";
                label_wrong.Visible = true;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void view_password(object sender, MouseEventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
