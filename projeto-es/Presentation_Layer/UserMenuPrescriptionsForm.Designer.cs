
namespace projeto_es.Presentation_Layer
{
    partial class UserMenuPrescriptionsForm
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
            this.prescriptionsLabel = new System.Windows.Forms.Label();
            this.checkPrescriptionButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.prescriptionListBox = new System.Windows.Forms.ListBox();
            this.prescriptionIDListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // prescriptionsLabel
            // 
            this.prescriptionsLabel.AutoSize = true;
            this.prescriptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionsLabel.Location = new System.Drawing.Point(343, 43);
            this.prescriptionsLabel.Name = "prescriptionsLabel";
            this.prescriptionsLabel.Size = new System.Drawing.Size(113, 20);
            this.prescriptionsLabel.TabIndex = 2;
            this.prescriptionsLabel.Text = "Prescriptions";
            // 
            // checkPrescriptionButton
            // 
            this.checkPrescriptionButton.Location = new System.Drawing.Point(315, 333);
            this.checkPrescriptionButton.Name = "checkPrescriptionButton";
            this.checkPrescriptionButton.Size = new System.Drawing.Size(178, 23);
            this.checkPrescriptionButton.TabIndex = 8;
            this.checkPrescriptionButton.Text = "View Precriptions";
            this.checkPrescriptionButton.UseVisualStyleBackColor = true;
            this.checkPrescriptionButton.Click += new System.EventHandler(this.checkPrescriptionButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(765, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 23);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "<";
            this.backButton.UseMnemonic = false;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // prescriptionListBox
            // 
            this.prescriptionListBox.FormattingEnabled = true;
            this.prescriptionListBox.Location = new System.Drawing.Point(90, 76);
            this.prescriptionListBox.Name = "prescriptionListBox";
            this.prescriptionListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.prescriptionListBox.Size = new System.Drawing.Size(481, 251);
            this.prescriptionListBox.TabIndex = 10;
            this.prescriptionListBox.SelectedIndexChanged += new System.EventHandler(this.prescriptionListBox_SelectedIndexChanged);
            // 
            // prescriptionIDListBox
            // 
            this.prescriptionIDListBox.FormattingEnabled = true;
            this.prescriptionIDListBox.Location = new System.Drawing.Point(577, 76);
            this.prescriptionIDListBox.Name = "prescriptionIDListBox";
            this.prescriptionIDListBox.Size = new System.Drawing.Size(120, 251);
            this.prescriptionIDListBox.TabIndex = 11;
            this.prescriptionIDListBox.SelectedIndexChanged += new System.EventHandler(this.prescriptionIDListBox_SelectedIndexChanged);
            // 
            // UserMenuPrescriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prescriptionIDListBox);
            this.Controls.Add(this.prescriptionListBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.checkPrescriptionButton);
            this.Controls.Add(this.prescriptionsLabel);
            this.Name = "UserMenuPrescriptionsForm";
            this.Text = "UserMenuPrescriptionsForm";
            this.Load += new System.EventHandler(this.UserMenuPrescriptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prescriptionsLabel;
        private System.Windows.Forms.Button checkPrescriptionButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox prescriptionListBox;
        private System.Windows.Forms.ListBox prescriptionIDListBox;
    }
}