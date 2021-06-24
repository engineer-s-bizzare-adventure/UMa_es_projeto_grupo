using projeto_es.Models;
using System;
using System.Windows.Forms;

namespace projeto_es.Presentation_Layer
{
    public partial class UserMenuNoAppointmentsForm : Form
    {
        public UserMenuNoAppointmentsForm(LoggedInSingleton loggedSingleton)
        {
            InitializeComponent();
            LoggedSingleton = loggedSingleton;
        }
        public LoggedInSingleton LoggedSingleton { get; set; }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form userCreateAppointmentForm = new UserMenuCreateAppointmentForm(LoggedSingleton);
            userCreateAppointmentForm.ShowDialog();
            this.Close();
        }

        private void UserMenuNoAppointmentsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
