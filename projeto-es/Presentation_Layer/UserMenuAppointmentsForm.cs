using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_es.Models;

namespace projeto_es.Presentation_Layer
{
    public partial class UserMenuAppointmentsForm : Form
    {
        public Session LoggedSession { get; set; }
        AppointmentService appointmentService = new AppointmentService();
        public UserMenuAppointmentsForm(Session loggedSession)
        {
            InitializeComponent();
            LoggedSession = loggedSession;
        }
         
        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void createPrescriptionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form userCreateAppointmentForm = new UserMenuCreateAppointmentForm(LoggedSession);
            userCreateAppointmentForm.ShowDialog();
            this.Close();
        }

        private void UserMenuAppointmentsForm_Load(object sender, EventArgs e)
        { 
            
            var Appointments = appointmentService.GetsAppointmentsOfAClient(LoggedSession.Account.Id);

            foreach (var Appointment in Appointments)
            {
                appointmentsListBox.Items.Add(Appointment.description);
                AppointmentIDlistBox.Items.Add(Appointment.id);
            }
        }

        private void checkAvailability()
        {

            DateTime localDate = DateTime.Now;

            var Appointments = appointmentService.GetsAppointmentsOfAClient(LoggedSession.Account.Id);


            foreach(var appointment in Appointments)
            {
                if(appointment.id == (uint)AppointmentIDlistBox.SelectedItem)
                {

                    DateTime selectedDate = Convert.ToDateTime(appointment.scheduled_time);

                    Console.WriteLine(localDate);
                    Console.WriteLine(selectedDate);
                    Console.WriteLine(appointment.scheduled_time);

                    if (selectedDate < localDate)
                    {
                        Console.WriteLine("The selected date is not possible.");

                    }
                    else
                    {
                        Console.WriteLine("The selected date good.");
                    }

                }

            }

        }
        private void atendAppointmentButton_Click(object sender, EventArgs e)
        {
            checkAvailability();

        }

        private void cancelAppointmentButton_Click(object sender, EventArgs e)
        {
            appointmentService.DeleteAppointment((uint)AppointmentIDlistBox.SelectedItem);
            Console.WriteLine("Deleted appointment: " + (uint)AppointmentIDlistBox.SelectedItem);

        }

        private void appointmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AppointmentIDlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
