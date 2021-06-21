
namespace projeto_es.Presentation_Layer
{
    partial class UserMenuAppointmentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createPrescriptionButton = new System.Windows.Forms.Button();
            this.appointmentsLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.atendAppointmentButton = new System.Windows.Forms.Button();
            this.cancelAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // createPrescriptionButton
            // 
            this.createPrescriptionButton.Location = new System.Drawing.Point(498, 367);
            this.createPrescriptionButton.Name = "createPrescriptionButton";
            this.createPrescriptionButton.Size = new System.Drawing.Size(178, 23);
            this.createPrescriptionButton.TabIndex = 0;
            this.createPrescriptionButton.Text = "Create an appointment";
            this.createPrescriptionButton.UseVisualStyleBackColor = true;
            this.createPrescriptionButton.Click += new System.EventHandler(this.createPrescriptionButton_Click);
            // 
            // appointmentsLabel
            // 
            this.appointmentsLabel.AutoSize = true;
            this.appointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsLabel.Location = new System.Drawing.Point(329, 32);
            this.appointmentsLabel.Name = "appointmentsLabel";
            this.appointmentsLabel.Size = new System.Drawing.Size(120, 20);
            this.appointmentsLabel.TabIndex = 1;
            this.appointmentsLabel.Text = "Appointments";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(765, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // atendAppointmentButton
            // 
            this.atendAppointmentButton.Location = new System.Drawing.Point(130, 367);
            this.atendAppointmentButton.Name = "atendAppointmentButton";
            this.atendAppointmentButton.Size = new System.Drawing.Size(178, 23);
            this.atendAppointmentButton.TabIndex = 3;
            this.atendAppointmentButton.Text = "Atend Appointment";
            this.atendAppointmentButton.UseVisualStyleBackColor = true;
            this.atendAppointmentButton.Click += new System.EventHandler(this.atendAppointmentButton_Click);
            // 
            // cancelAppointmentButton
            // 
            this.cancelAppointmentButton.Location = new System.Drawing.Point(314, 367);
            this.cancelAppointmentButton.Name = "cancelAppointmentButton";
            this.cancelAppointmentButton.Size = new System.Drawing.Size(178, 23);
            this.cancelAppointmentButton.TabIndex = 4;
            this.cancelAppointmentButton.Text = "Cancel Appointment";
            this.cancelAppointmentButton.UseVisualStyleBackColor = true;
            this.cancelAppointmentButton.Click += new System.EventHandler(this.cancelAppointmentButton_Click);
            // 
            // appointmentsListBox
            // 
            this.appointmentsListBox.FormattingEnabled = true;
            this.appointmentsListBox.Items.AddRange(new object[] {
            "Dr. Joao - 20:00 | 10/06/2021",
            "Dr. Joao - 22:00 | 11/06/2021 - Faltou!",
            "Dr. Pedro - 11:00 | 12/06/2021  (Hoje)",
            "Dr. Joao - 23:00 | 13/06/2021"});
            this.appointmentsListBox.Location = new System.Drawing.Point(214, 105);
            this.appointmentsListBox.Name = "appointmentsListBox";
            this.appointmentsListBox.Size = new System.Drawing.Size(377, 186);
            this.appointmentsListBox.TabIndex = 5;
            // 
            // UserMenuAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appointmentsListBox);
            this.Controls.Add(this.cancelAppointmentButton);
            this.Controls.Add(this.atendAppointmentButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.appointmentsLabel);
            this.Controls.Add(this.createPrescriptionButton);
            this.Name = "UserMenuAppointmentsForm";
            this.Text = "UserMenuAppointmentsForm";
            this.Load += new System.EventHandler(this.UserMenuAppointmentsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createPrescriptionButton;
        private System.Windows.Forms.Label appointmentsLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button atendAppointmentButton;
        private System.Windows.Forms.Button cancelAppointmentButton;
        private System.Windows.Forms.ListBox appointmentsListBox;
    }
}