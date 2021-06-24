using projeto_es.Models;
using projeto_es.Business_Layer;
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
    public partial class StaffMenuAppointment : Form
    {
        public LoggedInSingleton LoggedSingleton { get; set; }
        public StaffMenuAppointment(LoggedInSingleton loggedSingleton)
        {
            InitializeComponent();
            LoggedSingleton = loggedSingleton;
        }

        private void PrescriptionsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prescriptionIDlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreatePrescriptionsButton_Click(object sender, EventArgs e)
        {

        }

        private void EditPrescriptionButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
