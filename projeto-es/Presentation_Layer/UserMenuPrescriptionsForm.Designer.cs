
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
            this.appointmentsListBox = new System.Windows.Forms.ListBox();
            this.checkPrescriptionButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prescriptionsLabel
            // 
            this.prescriptionsLabel.AutoSize = true;
            this.prescriptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionsLabel.Location = new System.Drawing.Point(340, 48);
            this.prescriptionsLabel.Name = "prescriptionsLabel";
            this.prescriptionsLabel.Size = new System.Drawing.Size(113, 20);
            this.prescriptionsLabel.TabIndex = 2;
            this.prescriptionsLabel.Text = "Prescriptions";
            // 
            // appointmentsListBox
            // 
            this.appointmentsListBox.FormattingEnabled = true;
            this.appointmentsListBox.Items.AddRange(new object[] {
            "Prescrição - Dr. Joao - 20:00 | 10/06/2021",
            ""});
            this.appointmentsListBox.Location = new System.Drawing.Point(216, 100);
            this.appointmentsListBox.Name = "appointmentsListBox";
            this.appointmentsListBox.Size = new System.Drawing.Size(377, 186);
            this.appointmentsListBox.TabIndex = 6;
            this.appointmentsListBox.SelectedIndexChanged += new System.EventHandler(this.appointmentsListBox_SelectedIndexChanged);
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
            // UserMenuPrescriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.checkPrescriptionButton);
            this.Controls.Add(this.appointmentsListBox);
            this.Controls.Add(this.prescriptionsLabel);
            this.Name = "UserMenuPrescriptionsForm";
            this.Text = "UserMenuPrescriptionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prescriptionsLabel;
        private System.Windows.Forms.ListBox appointmentsListBox;
        private System.Windows.Forms.Button checkPrescriptionButton;
        private System.Windows.Forms.Button backButton;
    }
}