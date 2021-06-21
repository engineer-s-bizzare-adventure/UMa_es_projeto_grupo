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
        public UserMenuPrescriptionsForm()
        {
            InitializeComponent();
        }

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

        private void appointmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
