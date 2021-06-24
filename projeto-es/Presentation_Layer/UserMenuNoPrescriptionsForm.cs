using System;
using System.Windows.Forms;

namespace projeto_es.Presentation_Layer
{
    public partial class UserMenuNoPrescriptionsForm : Form
    {
        public UserMenuNoPrescriptionsForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void UserMenuNoPrescriptionsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
