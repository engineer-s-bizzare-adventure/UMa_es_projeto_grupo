using projeto_es.Models;
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
    public partial class UserMenuPrescriptionsForm : Form
    {
        public UserMenuPrescriptionsForm(Session session)
        {
            InitializeComponent();
            LoggedSession = session;
        }

        public Session LoggedSession { get; set; }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void checkPrescriptionButton_Click(object sender, EventArgs e)
        {
            //SELECT A PRESCRIPTION FIRST
            this.Hide();
            Form userCreateAppointmentForm = new UserMenuCheckPrescriptionForm();
            userCreateAppointmentForm.ShowDialog();
            this.Close();
        }


        private void UserMenuPrescriptionsForm_Load(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            var prescriptions = accountService.GetClientPrescriptions(LoggedSession.clientID);

            foreach (var prescription in prescriptions)
            {
                prescriptionListBox.Items.Add(prescription.Name + " " + prescription.Description + " " + prescription.DatePrescribed);
                //prescriptionListBox.Items.Add(prescription.Description);
                //prescriptionListBox.Items.Add(prescription.DatePrescribed);
            }
        }

        private void prescriptionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
