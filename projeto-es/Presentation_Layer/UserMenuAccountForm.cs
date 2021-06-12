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
    public partial class UserMenuAccountForm : Form
    {
        public static bool loggedIn = true;
        public UserMenuAccountForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loggedIn = false;
            this.DialogResult = DialogResult.OK;

        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void UserMenuAccountForm_Load(object sender, EventArgs e)
        {

        }
    }
}
