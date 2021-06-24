
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
            this.AppointmentIDlistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scheduledTimeListBox = new System.Windows.Forms.ListBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.scheduledTimeLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
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
            this.createPrescriptionButton.Visible = false;
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
            this.appointmentsListBox.Location = new System.Drawing.Point(130, 105);
            this.appointmentsListBox.Name = "appointmentsListBox";
            this.appointmentsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.appointmentsListBox.Size = new System.Drawing.Size(377, 186);
            this.appointmentsListBox.TabIndex = 5;
            this.appointmentsListBox.SelectedIndexChanged += new System.EventHandler(this.appointmentsListBox_SelectedIndexChanged);
            // 
            // AppointmentIDlistBox
            // 
            this.AppointmentIDlistBox.FormattingEnabled = true;
            this.AppointmentIDlistBox.Location = new System.Drawing.Point(640, 105);
            this.AppointmentIDlistBox.Name = "AppointmentIDlistBox";
            this.AppointmentIDlistBox.Size = new System.Drawing.Size(36, 186);
            this.AppointmentIDlistBox.TabIndex = 6;
            this.AppointmentIDlistBox.SelectedIndexChanged += new System.EventHandler(this.AppointmentIDlistBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select an appointment id";
            // 
            // scheduledTimeListBox
            // 
            this.scheduledTimeListBox.FormattingEnabled = true;
            this.scheduledTimeListBox.Location = new System.Drawing.Point(513, 105);
            this.scheduledTimeListBox.Name = "scheduledTimeListBox";
            this.scheduledTimeListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.scheduledTimeListBox.Size = new System.Drawing.Size(120, 186);
            this.scheduledTimeListBox.TabIndex = 8;
            this.scheduledTimeListBox.SelectedIndexChanged += new System.EventHandler(this.scheduledTimeListBox_SelectedIndexChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(127, 294);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 9;
            // 
            // scheduledTimeLabel
            // 
            this.scheduledTimeLabel.AutoSize = true;
            this.scheduledTimeLabel.Location = new System.Drawing.Point(510, 89);
            this.scheduledTimeLabel.Name = "scheduledTimeLabel";
            this.scheduledTimeLabel.Size = new System.Drawing.Size(81, 13);
            this.scheduledTimeLabel.TabIndex = 10;
            this.scheduledTimeLabel.Text = "ScheduledTime";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(637, 89);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "ID";
            // 
            // UserMenuAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.scheduledTimeLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.scheduledTimeListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppointmentIDlistBox);
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
        private System.Windows.Forms.ListBox AppointmentIDlistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox scheduledTimeListBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label scheduledTimeLabel;
        private System.Windows.Forms.Label idLabel;
    }
}