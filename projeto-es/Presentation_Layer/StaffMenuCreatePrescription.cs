using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_es.Presentation_Layer
{
    public partial class StaffMenuCreatePrescription : Form
    {
        private string _nameUser;
        private static bool _control;
        public StaffMenuCreatePrescription(string userName, CredentialsForm credencialsForm)
        {
            InitializeComponent();
            _control = false;
        }

        private void btn_close(object sender, FormClosingEventArgs e)
        {
            if (!_control)
            {
                var question = MessageBox.Show($@"{_nameUser}, deseja sair da aplicação", @"Saíndo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.Yes)
                {
                    _control = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_confirm_prescription_Click(object sender, EventArgs e)
        {
            /*
             * Envio de informaçõa para a base de dados
             */
            if (!RB_Medican.Checked && !RB_exercise.Checked && !RB_treatment.Checked ||
                tb_name_utente.Text.ToLower() == "nome completo" ||
                area_descrição.Text.ToLower() == "descrição da prescrição")
            {
                MessageBox.Show("Falta inserir algumas informações", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pnl_prescription.Visible = false;
                btn_back.Visible = false;
            }
        }

        private void tb_name_utente_TextChanged(object sender, EventArgs e)
        {
            tb_name_utente.Text = "";
        }

        private void StaffMenuCreateAppointment_Load(object sender, EventArgs e)
        {

        }

        private void area_descrição_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
