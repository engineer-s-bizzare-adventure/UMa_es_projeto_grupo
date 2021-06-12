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
            label_wrong.Visible = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text.ToLower() == "pedro" && passwordTextBox.Text.ToLower() == "aaa")
            {
                this.Hide();
                var menuStaff = new MainMenuStaff();
                menuStaff.ShowDialog();
            }
            else
            {
                label_wrong.Text = "Algo está errado";
                label_wrong.ForeColor = Color.Red;
                label_wrong.Visible = true;
            }
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
    }
}
