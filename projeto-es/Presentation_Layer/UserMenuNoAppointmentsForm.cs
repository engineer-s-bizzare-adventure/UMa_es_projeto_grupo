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
    public partial class UserMenuNoAppointmentsForm : Form
    {
        public UserMenuNoAppointmentsForm(Session loggedSession)
        {
            InitializeComponent();
            LoggedSession = loggedSession;
        }
        public Session LoggedSession { get; set; }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form userCreateAppointmentForm = new UserMenuCreateAppointmentForm(LoggedSession);
            userCreateAppointmentForm.ShowDialog();
            this.Close();
        }

        private void UserMenuNoAppointmentsForm_Load(object sender, EventArgs e)
        {

        }
    }
}