
namespace projeto_es.Presentation_Layer
{
    partial class UserMenuNoAppointmentsForm
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
            this.noAppointmentsLabel = new System.Windows.Forms.Label();
            this.createAppointmentButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noAppointmentsLabel
            // 
            this.noAppointmentsLabel.AutoSize = true;
            this.noAppointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noAppointmentsLabel.Location = new System.Drawing.Point(154, 46);
            this.noAppointmentsLabel.Name = "noAppointmentsLabel";
            this.noAppointmentsLabel.Size = new System.Drawing.Size(493, 31);
            this.noAppointmentsLabel.TabIndex = 0;
            this.noAppointmentsLabel.Text = "You don\'t have any appointments yet\r\n";
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.Location = new System.Drawing.Point(301, 127);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(195, 23);
            this.createAppointmentButton.TabIndex = 1;
            this.createAppointmentButton.Text = "Create Appointment";
            this.createAppointmentButton.UseVisualStyleBackColor = true;
            this.createAppointmentButton.Click += new System.EventHandler(this.createAppointmentButton_Click);
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
            // UserMenuNoAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.createAppointmentButton);
            this.Controls.Add(this.noAppointmentsLabel);
            this.Name = "UserMenuNoAppointmentsForm";
            this.Text = "UserMenuNoAppointments";
            this.Load += new System.EventHandler(this.UserMenuNoAppointmentsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noAppointmentsLabel;
        private System.Windows.Forms.Button createAppointmentButton;
        private System.Windows.Forms.Button backButton;
    }
}