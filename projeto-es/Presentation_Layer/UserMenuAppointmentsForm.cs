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
            //appointmentsListBox.Items.Add("Name of Staff | scheduled time");
            foreach (var Appointment in Appointments)
            {
                
                appointmentsListBox.Items.Add(Appointment.description);
                scheduledTimeListBox.Items.Add(Appointment.scheduled_time);
                AppointmentIDlistBox.Items.Add(Appointment.id);
            }
        }

        private bool checkAvailabilityCancel()
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
                        errorLabel.Text = "The selected date is an old appointment";
                        return false;

                    }
                    else
                    {
                        return true;
                    }

                }

            }
            return false;

        }

        private bool checkAvailabilityAttend()
        {

            DateTime localDate = DateTime.Now;

            var Appointments = appointmentService.GetsAppointmentsOfAClient(LoggedSession.Account.Id);


            foreach (var appointment in Appointments)
            {
                if (appointment.id == (uint)AppointmentIDlistBox.SelectedItem)
                {

                    DateTime selectedAppointmentDate = Convert.ToDateTime(appointment.scheduled_time);
                    DateTime toleranceAppointmentEarly = selectedAppointmentDate.AddMinutes(-10);
                    DateTime toleranceAppointmentLate = selectedAppointmentDate.AddMinutes(10);

                    //Console.WriteLine("localdate: " + localDate);
                    //Console.WriteLine("selecteddate: " + selectedAppointmentDate);

                    //Console.WriteLine("selectedDate.Date: " + selectedAppointmentDate.Date);
                    //Console.WriteLine("localDate.Date: " + localDate.Date);

                    //Console.WriteLine("ToleranceEarly: " + toleranceAppointmentEarly);
                    //Console.WriteLine("ToleranceLate: " + toleranceAppointmentLate);


                    if (selectedAppointmentDate.Date == localDate.Date)
                    {
                        if(localDate.TimeOfDay < toleranceAppointmentEarly.TimeOfDay)
                        {
                            errorLabel.Text = "It's too early to be attended";
                            break;
                        }

                        if(localDate.TimeOfDay > toleranceAppointmentLate.TimeOfDay)
                        {
                            errorLabel.Text = "You lost the oportunity to be attended";
                            break;
                        }

                        return true;

                    }
                    else
                    {
                        errorLabel.Text = "The selected date is not available";
                        return false;
                    }

                }

            }
            return false;

        }

        private void atendAppointmentButton_Click(object sender, EventArgs e)
        {
            if (checkAvailabilityAttend())
            {
                Console.WriteLine("Ayyyy lmaaao");
            }
        }

        private void cancelAppointmentButton_Click(object sender, EventArgs e)
        {
            if (checkAvailabilityCancel())
            {
                appointmentService.DeleteAppointment((uint)AppointmentIDlistBox.SelectedItem);
                Console.WriteLine("Deleted appointment: " + (uint)AppointmentIDlistBox.SelectedItem);
            }

        }

        private void appointmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AppointmentIDlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
