using System;
using System.CodeDom.Compiler;
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
    public partial class MainMenuStaff : Form
    {
        private List<String> prescriptionList;
        public MainMenuStaff()
        {
            InitializeComponent();
            prescriptionList = new List<string>();
            Label_info.Visible = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Deseja sair da conta?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                var getOut = new CredentialsForm();
                getOut.ShowDialog();
            }
        }

        private void btn_view_prescriptions_Click(object sender, EventArgs e)
        {
            if (prescriptionList.Count == 0)
            {
                Label_info.Text = "Não tem prescrições no momento";
                Label_info.ForeColor = Color.Red;
                Label_info.Visible = true;
            }
        }
    }
}
