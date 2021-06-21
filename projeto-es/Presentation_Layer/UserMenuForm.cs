using projeto_es.Models;
using System;
using System.Windows.Forms;

namespace projeto_es.Presentation_Layer
{
    public partial class UserMenuForm : Form
    {

        public UserMenuForm(Session loggedSession)
        {
            InitializeComponent();
            LoggedSession = loggedSession;
        }

        public Session LoggedSession { get; set;}
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
            welcomeLabel.Text = "Welcome, " + LoggedSession.Person.name + " !";
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

        private void welcomeLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
