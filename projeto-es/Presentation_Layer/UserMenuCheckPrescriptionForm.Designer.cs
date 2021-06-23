
namespace projeto_es.Presentation_Layer
{
    partial class UserMenuCheckPrescriptionForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.prescriptionLabel = new System.Windows.Forms.Label();
            this.prescriptionDetailsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(765, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // prescriptionLabel
            // 
            this.prescriptionLabel.AutoSize = true;
            this.prescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionLabel.Location = new System.Drawing.Point(77, 66);
            this.prescriptionLabel.Name = "prescriptionLabel";
            this.prescriptionLabel.Size = new System.Drawing.Size(189, 24);
            this.prescriptionLabel.TabIndex = 5;
            this.prescriptionLabel.Text = "Prescription Details";
            // 
            // prescriptionDetailsListBox
            // 
            this.prescriptionDetailsListBox.FormattingEnabled = true;
            this.prescriptionDetailsListBox.Location = new System.Drawing.Point(81, 108);
            this.prescriptionDetailsListBox.Name = "prescriptionDetailsListBox";
            this.prescriptionDetailsListBox.Size = new System.Drawing.Size(631, 290);
            this.prescriptionDetailsListBox.TabIndex = 6;
            this.prescriptionDetailsListBox.SelectedIndexChanged += new System.EventHandler(this.prescriptionDetailsListBox_SelectedIndexChanged);
            // 
            // UserMenuCheckPrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prescriptionDetailsListBox);
            this.Controls.Add(this.prescriptionLabel);
            this.Controls.Add(this.backButton);
            this.Name = "UserMenuCheckPrescriptionForm";
            this.Text = "UserMenuCheckPrecription";
            this.Load += new System.EventHandler(this.UserMenuCheckPrecription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label prescriptionLabel;
        private System.Windows.Forms.ListBox prescriptionDetailsListBox;
    }
}