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
            this.Close();
        }

        private void UserMenuCreateAppointmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
