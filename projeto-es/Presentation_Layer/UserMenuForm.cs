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
    public partial class UserMenuForm : Form
    {

        public UserMenuForm()
        {
            InitializeComponent();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form userAccountForm = new UserMenuAccountForm();
            userAccountForm.ShowDialog();

            if (!UserMenuAccountForm.loggedIn)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void UserMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void appointmentsButton_Click(object sender, EventArgs e)
        {
            //CHECK FOR APPOINTMENTS FIRST
            this.Hide();
            Form userCreateAppointmentForm = new UserMenuCreateAppointmentForm();
            userCreateAppointmentForm.ShowDialog();
            this.Show();
        }

        private void prescriptionsButton_Click(object sender, EventArgs e)
        {
            //CHECK FOR PRESCRIPTIONS FIRST
            this.Hide();
            Form userPrescriptionForm = new UserMenuPrescriptionsForm();
            userPrescriptionForm.ShowDialog();
            this.Show();
        }
    }
}
