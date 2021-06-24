using projeto_es.Models;
using System;
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
        private void StaffMenuAppointment_Load(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            var prescriptions = accountService.GetClientPrescriptionsOfStaff(LoggedSingleton.staffID);

            foreach (var prescription in prescriptions)
            {
                PrescriptionsListbox.Items.Add(prescription.Name + " " + prescription.Description + " " + prescription.DatePrescribed);
                prescriptionIDlistbox.Items.Add(prescription.Id);
            }
            
        }

        private void PrescriptionsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void prescriptionIDlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CreatePrescriptionsButton_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Form staffMenuCreatePrescriptionForm = new StaffMenuCreatePrescription(LoggedSingleton);
            staffMenuCreatePrescriptionForm.ShowDialog();
            this.Close();
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
