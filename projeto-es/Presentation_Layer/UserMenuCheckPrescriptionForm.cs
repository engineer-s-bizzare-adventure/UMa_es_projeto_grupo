using projeto_es.Models;
using System;
using System.Windows.Forms;

namespace projeto_es.Presentation_Layer
{
    public partial class UserMenuCheckPrescriptionForm : Form
    {
        public UserMenuCheckPrescriptionForm(Prescription prescription)
        {
            InitializeComponent();
            Prescription = prescription;
        }

        public Prescription Prescription { get; set; }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserMenuCheckPrecription_Load(object sender, EventArgs e)
        {
            prescriptionDetailsListBox.Items.Add("Prescription id: " + Prescription.Id);
            prescriptionDetailsListBox.Items.Add("Prescription name: " + Prescription.Name);
            prescriptionDetailsListBox.Items.Add("Date Prescribed: " + Prescription.DatePrescribed);
            prescriptionDetailsListBox.Items.Add("Appointment id: " + Prescription.Appointment_Id);
            
        }

        
        private void prescriptionDetailsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
