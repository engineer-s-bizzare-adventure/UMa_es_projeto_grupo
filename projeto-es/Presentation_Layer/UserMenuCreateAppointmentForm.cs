﻿using projeto_es.Models;
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

        public UserMenuCreateAppointmentForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
 
            AppointmentService NewAppointment = new AppointmentService();

            NewAppointment.CreateAppointment(new Appointment()
            {
                date = dateTimePicker.Value,
                description = descriptionRichTextBox.Text,
                scheduled_time = hourDateTimePicker.Value,
            });

            this.Close();
        }

        private void UserMenuCreateAppointmentForm_Load(object sender, EventArgs e)
        {
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
    }
}
