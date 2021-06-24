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
    public partial class AdminForm : Form
    {
        public AdminForm(LoggedInSingleton loggedSingleton)
        {
            InitializeComponent();
            LoggedSingleton = loggedSingleton;
        }

        public LoggedInSingleton LoggedSingleton { get; set; }
        private void dataGridHolder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void manageStaffButton_Click(object sender, EventArgs e)
        {

        }

        private void checkPrescriptionHistory_Click(object sender, EventArgs e)
        {

        }

        private void appointmentHistoryButton_Click(object sender, EventArgs e)
        {

        }

        private void itemListButton_Click(object sender, EventArgs e)
        {

        }

        private void addItem_Click(object sender, EventArgs e)
        {
            ItemTemplateAbstract newExercise = new ExerciseTemplateConcrete();
            ItemTemplateAbstract newMedicine = new MedicineTemplateConcrete();
            ItemTemplateAbstract newTreatment = new TreatmentTemplateConcrete();

            var weight = weightTextBox.Text;
            var session = sessionTextBox.Text;
            var treatTime = treatTimeTextBox.Text;
            var exerciseDur = exerciseDurTextBox.Text;
            var name = nameTextBox.Text;
            var prescriptionID = prescriptionTextBox.Text;

            newExercise.addItem(Int32.Parse(prescriptionID),name, Int32.Parse(weight),session, Int32.Parse(treatTime), Int32.Parse(exerciseDur));
            newMedicine.addItem(Int32.Parse(prescriptionID), name, Int32.Parse(weight), session, Int32.Parse(treatTime), Int32.Parse(exerciseDur));
            newTreatment.addItem(Int32.Parse(prescriptionID), name, Int32.Parse(weight), session, Int32.Parse(treatTime), Int32.Parse(exerciseDur));
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
