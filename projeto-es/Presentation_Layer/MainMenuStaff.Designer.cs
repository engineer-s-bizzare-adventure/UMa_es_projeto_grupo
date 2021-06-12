namespace projeto_es.Presentation_Layer
{
    partial class MainMenuStaff
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
            this.btn_view_prescriptions = new System.Windows.Forms.Button();
            this.btn_check_appointments = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.Label_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_view_prescriptions
            // 
            this.btn_view_prescriptions.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_prescriptions.Location = new System.Drawing.Point(92, 59);
            this.btn_view_prescriptions.Name = "btn_view_prescriptions";
            this.btn_view_prescriptions.Size = new System.Drawing.Size(152, 126);
            this.btn_view_prescriptions.TabIndex = 0;
            this.btn_view_prescriptions.Text = "View Prescriptions";
            this.btn_view_prescriptions.UseVisualStyleBackColor = true;
            this.btn_view_prescriptions.Click += new System.EventHandler(this.btn_view_prescriptions_Click);
            // 
            // btn_check_appointments
            // 
            this.btn_check_appointments.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check_appointments.Location = new System.Drawing.Point(92, 228);
            this.btn_check_appointments.Name = "btn_check_appointments";
            this.btn_check_appointments.Size = new System.Drawing.Size(152, 126);
            this.btn_check_appointments.TabIndex = 1;
            this.btn_check_appointments.Text = "Check Appointments";
            this.btn_check_appointments.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(310, 59);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(152, 126);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Label_info
            // 
            this.Label_info.AutoSize = true;
            this.Label_info.Location = new System.Drawing.Point(392, 408);
            this.Label_info.Name = "Label_info";
            this.Label_info.Size = new System.Drawing.Size(35, 13);
            this.Label_info.TabIndex = 3;
            this.Label_info.Text = "label1";
            // 
            // MainMenuStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.Label_info);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_check_appointments);
            this.Controls.Add(this.btn_view_prescriptions);
            this.Name = "MainMenuStaff";
            this.Text = "Main Menu Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_view_prescriptions;
        private System.Windows.Forms.Button btn_check_appointments;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label Label_info;
    }
}