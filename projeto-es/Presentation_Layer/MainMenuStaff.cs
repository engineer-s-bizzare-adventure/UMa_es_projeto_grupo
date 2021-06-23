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
    public partial class MainMenuStaff : Form
    {
        private string _nameUser;
        private List<string> _prescriptionList;
        private List<string> _appointmentsList;
        private static bool _control;
        private CredentialsForm credencials;
        public MainMenuStaff(string userName, CredentialsForm credencialsForm)
        {
            InitializeComponent();
            credencials = credencialsForm;
            _nameUser = userName;
            _prescriptionList = new List<string>();
            _appointmentsList = new List<string>();
            _prescriptionList.Add("ALL things");
            Label_info.Visible = false;
            _control = false;
            /*
             * Ligar á base de dados nesta parte do código
             */

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show($@"Deseja sair da sua conta, {_nameUser}?", @"Saíndo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                _control = true;
                credencials.ShowMe(this);
            }
        }

        private void nextStep(bool isAppointment, bool state)
        {
            btn_check_appointments.Visible = state;
            btn_logout.Visible = state;
            btn_view_prescriptions.Visible = state;
            btn_createPrescription.Visible = state;
            btn_back.Visible = !state;
            Label_saudacao.Location = state ? new Point(49, 59) : new Point(350, 9);
            //Label_info.Location = state ? new Point(51, 228) : new Point(51, 59);
            Label_saudacao.Text = state ? $"Hello, {_nameUser}" : isAppointment ? "Appointment List" : "Prescription List";
            //Label_info.Visible = !state;
        }

        private void btn_view_prescriptions_Click(object sender, EventArgs e)
        {
            if (_prescriptionList.Count == 0)
            {
                Label_info.Text = @"Voçê não tem prescrições no momento!";
                Label_info.ForeColor = Color.Red;
                Label_info.Visible = true;
            }
            else
            {
                nextStep(false, false);
                takeTheInformation(false);
                Label_info.ForeColor = Color.Black;
            }
            Label_info.Visible = true;
        }

        private void btn_check_appointments_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> appointments = new Dictionary<string, string>();
            if (_appointmentsList.Count == 0)
            {
                Label_info.Text = @"Neste momento, voçê não tem compromissos";
                Label_info.ForeColor = Color.Red;
                Label_info.ForeColor = Color.Black;
            }
            else
            {
                nextStep(true, false);
                takeTheInformation(true);
                Label_info.ForeColor = Color.Black;
            }
            Label_info.Visible = true;
        }

        private void takeTheInformation(bool appointment)
        {
            var informationList = appointment ? _appointmentsList : _prescriptionList; 
            for (int infoIndex = 0; infoIndex < informationList.Count; infoIndex++)
            {
                Label _label = new Label();
                _label.Text = informationList[infoIndex];
                this.Labels.Add(_label);
            }
            configLabelALL();
        }

        private void MainMenuStaff_Load(object sender, EventArgs e)
        {
            Label_saudacao.Text = $@"Hello {_nameUser}";
            btn_back.Visible = false;
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
            nextStep(false, true);
            if (pnl_prescription.Visible)
            {
                pnl_prescription.Visible = false;
            }

            foreach (var _labe in Labels)
            {
                _labe.Visible = false;
            }
        }

        private void btn_createPrescription_Click(object sender, EventArgs e)
        {
            tb_name_utente.Text = "Nome Completo";
            area_descrição.Text = "Descrição da prescrição";
            pnl_prescription.Visible = true;
            btn_back.Visible = true;
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

        // A ser editado -------------------------
        private List<Label> Labels = new List<Label>();

        public void configLabelALL()
        {
            for (int lab = 0; lab < Labels.Count; lab++)
            {
                this.Labels[lab].AutoSize = true;
                this.Labels[lab].Font = new Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Labels[lab].Name = $"label_name_utente {lab}";
                this.Labels[lab].Location = new Point(29, 39 + 5 * lab + 1);
                this.Labels[lab].Size = new Size(111, 19);
                this.Labels[lab].TabIndex = 0;
                this.Labels[lab].ForeColor = Color.Black;
            }
        }

    }
}
