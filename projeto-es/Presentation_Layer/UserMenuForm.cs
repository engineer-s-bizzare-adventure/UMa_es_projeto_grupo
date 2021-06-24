using projeto_es.Models;
using System;
using System.Windows.Forms;

namespace projeto_es.Presentation_Layer
{
    public partial class UserMenuForm : Form
    {

        public UserMenuForm(LoggedInSingleton loggedSingleton)
        {
            InitializeComponent();
            LoggedSingleton = loggedSingleton;
        }

        public LoggedInSingleton LoggedSingleton { get; set;}
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
            welcomeLabel.Text = "Welcome, " + LoggedSingleton.Person.name + " !";
        }

        private void appointmentsButton_Click(object sender, EventArgs e)
        {

            AppointmentService NewAppointmentService = new AppointmentService();
            var NumberOfAppointment = NewAppointmentService.CheckExistingAppointments(LoggedSingleton);

            if (LoggedSingleton.Role == "Staff")
            {
                NumberOfAppointment = NewAppointmentService.CheckExistingAppointmentsStaff(LoggedSingleton);
                    
            }

            if(NumberOfAppointment)
            {
                this.Hide();
                Form userShowAppointmentsForm = new UserMenuAppointmentsForm(LoggedSingleton);
                userShowAppointmentsForm.ShowDialog();
                this.Show();
            }

            else
            {
                this.Hide();
                Form userHasNoAppointmentsForm = new UserMenuNoAppointmentsForm(LoggedSingleton);
                userHasNoAppointmentsForm.ShowDialog();
                this.Show();
            }
        }

        private void prescriptionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form userPrescriptionForm = new UserMenuPrescriptionsForm(LoggedSingleton);
            userPrescriptionForm.ShowDialog();
            this.Show();
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
