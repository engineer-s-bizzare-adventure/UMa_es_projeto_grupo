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
    public partial class UserMenuCreateAppointmentForm : Form
    {
        AccountService NewAccountService = new AccountService();
        public UserMenuCreateAppointmentForm(Session loggedSession)
        {
            InitializeComponent();
            LoggedSession = loggedSession;
        }
        public Session LoggedSession { get; set; }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
 
            AppointmentService NewAppointment = new AppointmentService();
            int ClientAccountid = NewAccountService.GetClientAccountId(LoggedSession.Account.Id);
            string formatedDate = dateTimePicker.Value.ToString("yyyy-MM-dd");
            string formatedHour = dateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            int StaffAccountId = NewAccountService.GetStaffMembersID((int)StaffIDlistBox.SelectedItem);

            NewAppointment.CreateAppointment(new Appointment()
            {
                date = formatedDate,
                description = descriptionRichTextBox.Text,
                scheduled_time = formatedHour,
            }, ClientAccountid, StaffAccountId);
            
            this.Close();
        }

        private void UserMenuCreateAppointmentForm_Load(object sender, EventArgs e)
        {
            
            var StaffMembers = NewAccountService.GetAllStaffMembers();
           
            foreach (var Staff in StaffMembers)
            {
                //staffListBox.Items.Add(string.Format("Name: {0} | ID: {1}", Staff.name, Staff.id));
                staffListBox.Items.Add(Staff.name);
                StaffIDlistBox.Items.Add(Staff.id);
            }
        }

        private void selectCalendarLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void scheduleTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hourDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            hourDateTimePicker.Format = DateTimePickerFormat.Time;
        }

        private void staffListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void StaffIDlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
