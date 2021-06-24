using projeto_es.Business_Layer;
using projeto_es.Models;
using System;
using System.Windows.Forms;

namespace projeto_es.Presentation_Layer
{
    public partial class UserMenuPrescriptionsForm : Form
    {
        public UserMenuPrescriptionsForm(LoggedInSingleton loggedSingleton)
        {
            InitializeComponent();
            LoggedSingleton = loggedSingleton;
        }

        public LoggedInSingleton LoggedSingleton { get; set; }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void checkPrescriptionButton_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(prescriptionIDListBox.SelectedItem.ToString());

            PrescriptionService prescriptionService = new PrescriptionService();
            Prescription fetchedPrescription = prescriptionService.GetPrescription(selectedID);
            
            
            this.Hide();
            Form userCreatePrescriptionForm = new UserMenuCheckPrescriptionForm(fetchedPrescription);
            userCreatePrescriptionForm.ShowDialog();
            this.Close();
        }


        private void UserMenuPrescriptionsForm_Load(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();

            var prescriptions = accountService.GetClientPrescriptions(LoggedSingleton.clientID);

            if (LoggedSingleton.Role == "Staff") 
            {
                prescriptions = accountService.GetClientPrescriptionsOfStaff(LoggedSingleton.staffID);
            }
            

            foreach (var prescription in prescriptions)
            {
                prescriptionListBox.Items.Add(prescription.Name + " " + prescription.Description + " " + prescription.DatePrescribed);
                prescriptionIDListBox.Items.Add(prescription.Id);
            }
        }

        private void prescriptionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prescriptionIDListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
