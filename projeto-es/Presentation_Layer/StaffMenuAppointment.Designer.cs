
namespace projeto_es.Presentation_Layer
{
    partial class StaffMenuAppointment
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
            this.PrescriptionsListbox = new System.Windows.Forms.ListBox();
            this.prescriptionIDlistbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreatePrescriptionsButton = new System.Windows.Forms.Button();
            this.EditPrescriptionButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrescriptionsListbox
            // 
            this.PrescriptionsListbox.FormattingEnabled = true;
            this.PrescriptionsListbox.Location = new System.Drawing.Point(169, 44);
            this.PrescriptionsListbox.Name = "PrescriptionsListbox";
            this.PrescriptionsListbox.Size = new System.Drawing.Size(445, 303);
            this.PrescriptionsListbox.TabIndex = 0;
            this.PrescriptionsListbox.SelectedIndexChanged += new System.EventHandler(this.PrescriptionsListbox_SelectedIndexChanged);
            // 
            // prescriptionIDlistbox
            // 
            this.prescriptionIDlistbox.FormattingEnabled = true;
            this.prescriptionIDlistbox.Location = new System.Drawing.Point(637, 44);
            this.prescriptionIDlistbox.Name = "prescriptionIDlistbox";
            this.prescriptionIDlistbox.Size = new System.Drawing.Size(54, 303);
            this.prescriptionIDlistbox.TabIndex = 1;
            this.prescriptionIDlistbox.SelectedIndexChanged += new System.EventHandler(this.prescriptionIDlistbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prescriptions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // CreatePrescriptionsButton
            // 
            this.CreatePrescriptionsButton.Location = new System.Drawing.Point(297, 392);
            this.CreatePrescriptionsButton.Name = "CreatePrescriptionsButton";
            this.CreatePrescriptionsButton.Size = new System.Drawing.Size(127, 23);
            this.CreatePrescriptionsButton.TabIndex = 4;
            this.CreatePrescriptionsButton.Text = "Create Prescription";
            this.CreatePrescriptionsButton.UseVisualStyleBackColor = true;
            this.CreatePrescriptionsButton.Click += new System.EventHandler(this.CreatePrescriptionsButton_Click);
            // 
            // EditPrescriptionButton
            // 
            this.EditPrescriptionButton.Location = new System.Drawing.Point(446, 392);
            this.EditPrescriptionButton.Name = "EditPrescriptionButton";
            this.EditPrescriptionButton.Size = new System.Drawing.Size(109, 23);
            this.EditPrescriptionButton.TabIndex = 5;
            this.EditPrescriptionButton.Text = "Edit Prescription";
            this.EditPrescriptionButton.UseVisualStyleBackColor = true;
            this.EditPrescriptionButton.Click += new System.EventHandler(this.EditPrescriptionButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(756, 18);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // StaffMenuAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.EditPrescriptionButton);
            this.Controls.Add(this.CreatePrescriptionsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prescriptionIDlistbox);
            this.Controls.Add(this.PrescriptionsListbox);
            this.Name = "StaffMenuAppointment";
            this.Text = "StaffMenuAppointment";
            this.Load += new System.EventHandler(this.StaffMenuAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PrescriptionsListbox;
        private System.Windows.Forms.ListBox prescriptionIDlistbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreatePrescriptionsButton;
        private System.Windows.Forms.Button EditPrescriptionButton;
        private System.Windows.Forms.Button backButton;
    }
}