
namespace projeto_es.Presentation_Layer
{
    partial class UserMenuCreateAppointmentForm
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
            this.staffListBox = new System.Windows.Forms.ListBox();
            this.selectDoctorLabel = new System.Windows.Forms.Label();
            this.selectCalendarLabel = new System.Windows.Forms.Label();
            this.createAppointmentButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.backButton = new System.Windows.Forms.Button();
            this.selectHourLabel = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addDescriptionRichBox = new System.Windows.Forms.Label();
            this.hourDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // staffListBox
            // 
            this.staffListBox.FormattingEnabled = true;
            this.staffListBox.Items.AddRange(new object[] {
            "Dr. Joao",
            "Dr. Alberto",
            "Dr. Milos",
            "Dr. Scuff"});
            this.staffListBox.Location = new System.Drawing.Point(183, 65);
            this.staffListBox.Name = "staffListBox";
            this.staffListBox.Size = new System.Drawing.Size(413, 82);
            this.staffListBox.TabIndex = 0;
            // 
            // selectDoctorLabel
            // 
            this.selectDoctorLabel.AutoSize = true;
            this.selectDoctorLabel.Location = new System.Drawing.Point(180, 49);
            this.selectDoctorLabel.Name = "selectDoctorLabel";
            this.selectDoctorLabel.Size = new System.Drawing.Size(178, 13);
            this.selectDoctorLabel.TabIndex = 1;
            this.selectDoctorLabel.Text = "Select a doctor for your appointment";
            // 
            // selectCalendarLabel
            // 
            this.selectCalendarLabel.AutoSize = true;
            this.selectCalendarLabel.Location = new System.Drawing.Point(180, 163);
            this.selectCalendarLabel.Name = "selectCalendarLabel";
            this.selectCalendarLabel.Size = new System.Drawing.Size(165, 13);
            this.selectCalendarLabel.TabIndex = 3;
            this.selectCalendarLabel.Text = "Select a day for your appointment";
            this.selectCalendarLabel.Click += new System.EventHandler(this.selectCalendarLabel_Click);
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.Location = new System.Drawing.Point(604, 405);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(145, 23);
            this.createAppointmentButton.TabIndex = 4;
            this.createAppointmentButton.Text = "Create Appointment";
            this.createAppointmentButton.UseVisualStyleBackColor = true;
            this.createAppointmentButton.Click += new System.EventHandler(this.createAppointmentButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(183, 179);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(225, 20);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(765, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // selectHourLabel
            // 
            this.selectHourLabel.AutoSize = true;
            this.selectHourLabel.Location = new System.Drawing.Point(180, 224);
            this.selectHourLabel.Name = "selectHourLabel";
            this.selectHourLabel.Size = new System.Drawing.Size(181, 13);
            this.selectHourLabel.TabIndex = 7;
            this.selectHourLabel.Text = "Select and hour for your appointment";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(183, 309);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(318, 96);
            this.descriptionRichTextBox.TabIndex = 9;
            this.descriptionRichTextBox.Text = "";
            // 
            // addDescriptionRichBox
            // 
            this.addDescriptionRichBox.AutoSize = true;
            this.addDescriptionRichBox.Location = new System.Drawing.Point(180, 293);
            this.addDescriptionRichBox.Name = "addDescriptionRichBox";
            this.addDescriptionRichBox.Size = new System.Drawing.Size(89, 13);
            this.addDescriptionRichBox.TabIndex = 10;
            this.addDescriptionRichBox.Text = "Add a description";
            // 
            // hourDateTimePicker
            // 
            this.hourDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hourDateTimePicker.Location = new System.Drawing.Point(183, 251);
            this.hourDateTimePicker.Name = "hourDateTimePicker";
            this.hourDateTimePicker.Size = new System.Drawing.Size(225, 20);
            this.hourDateTimePicker.TabIndex = 12;
            this.hourDateTimePicker.Value = new System.DateTime(2021, 6, 21, 21, 44, 0, 0);
            this.hourDateTimePicker.ValueChanged += new System.EventHandler(this.hourDateTimePicker_ValueChanged);
            // 
            // UserMenuCreateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hourDateTimePicker);
            this.Controls.Add(this.addDescriptionRichBox);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.selectHourLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.createAppointmentButton);
            this.Controls.Add(this.selectCalendarLabel);
            this.Controls.Add(this.selectDoctorLabel);
            this.Controls.Add(this.staffListBox);
            this.Name = "UserMenuCreateAppointmentForm";
            this.Text = "UserMenuCreateAppointmentForm";
            this.Load += new System.EventHandler(this.UserMenuCreateAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox staffListBox;
        private System.Windows.Forms.Label selectDoctorLabel;
        private System.Windows.Forms.Label selectCalendarLabel;
        private System.Windows.Forms.Button createAppointmentButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label selectHourLabel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label addDescriptionRichBox;
        private System.Windows.Forms.DateTimePicker hourDateTimePicker;
    }
}