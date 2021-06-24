
namespace projeto_es.Presentation_Layer
{
    partial class AdminForm
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
            this.checkPrescriptionHistory = new System.Windows.Forms.Button();
            this.manageStaffButton = new System.Windows.Forms.Button();
            this.appointmentHistoryButton = new System.Windows.Forms.Button();
            this.itemListButton = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.sessionTextBox = new System.Windows.Forms.TextBox();
            this.treatTimeTextBox = new System.Windows.Forms.TextBox();
            this.exerciseDurTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.sessionLabel = new System.Windows.Forms.Label();
            this.treatmentLabel = new System.Windows.Forms.Label();
            this.exerciseDurationLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.prescriptionIDLabel = new System.Windows.Forms.Label();
            this.prescriptionTextBox = new System.Windows.Forms.TextBox();
            this.selectedType = new System.Windows.Forms.ListBox();
            this.selectType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkPrescriptionHistory
            // 
            this.checkPrescriptionHistory.Location = new System.Drawing.Point(105, 12);
            this.checkPrescriptionHistory.Name = "checkPrescriptionHistory";
            this.checkPrescriptionHistory.Size = new System.Drawing.Size(87, 23);
            this.checkPrescriptionHistory.TabIndex = 1;
            this.checkPrescriptionHistory.Text = "Prescription history";
            this.checkPrescriptionHistory.UseVisualStyleBackColor = true;
            this.checkPrescriptionHistory.Click += new System.EventHandler(this.checkPrescriptionHistory_Click);
            // 
            // manageStaffButton
            // 
            this.manageStaffButton.Location = new System.Drawing.Point(12, 12);
            this.manageStaffButton.Name = "manageStaffButton";
            this.manageStaffButton.Size = new System.Drawing.Size(87, 23);
            this.manageStaffButton.TabIndex = 2;
            this.manageStaffButton.Text = "Manage staff members";
            this.manageStaffButton.UseVisualStyleBackColor = true;
            this.manageStaffButton.Click += new System.EventHandler(this.manageStaffButton_Click);
            // 
            // appointmentHistoryButton
            // 
            this.appointmentHistoryButton.Location = new System.Drawing.Point(292, 12);
            this.appointmentHistoryButton.Name = "appointmentHistoryButton";
            this.appointmentHistoryButton.Size = new System.Drawing.Size(87, 23);
            this.appointmentHistoryButton.TabIndex = 3;
            this.appointmentHistoryButton.Text = "Appointment history";
            this.appointmentHistoryButton.UseVisualStyleBackColor = true;
            this.appointmentHistoryButton.Click += new System.EventHandler(this.appointmentHistoryButton_Click);
            // 
            // itemListButton
            // 
            this.itemListButton.Location = new System.Drawing.Point(199, 12);
            this.itemListButton.Name = "itemListButton";
            this.itemListButton.Size = new System.Drawing.Size(87, 23);
            this.itemListButton.TabIndex = 4;
            this.itemListButton.Text = "Prescribed item history";
            this.itemListButton.UseVisualStyleBackColor = true;
            this.itemListButton.Click += new System.EventHandler(this.itemListButton_Click);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(131, 54);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(123, 23);
            this.addItem.TabIndex = 6;
            this.addItem.Text = "AddItem";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(141, 83);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 7;
            // 
            // sessionTextBox
            // 
            this.sessionTextBox.Location = new System.Drawing.Point(141, 112);
            this.sessionTextBox.Name = "sessionTextBox";
            this.sessionTextBox.Size = new System.Drawing.Size(100, 20);
            this.sessionTextBox.TabIndex = 8;
            // 
            // treatTimeTextBox
            // 
            this.treatTimeTextBox.Location = new System.Drawing.Point(141, 141);
            this.treatTimeTextBox.Name = "treatTimeTextBox";
            this.treatTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.treatTimeTextBox.TabIndex = 9;
            // 
            // exerciseDurTextBox
            // 
            this.exerciseDurTextBox.Location = new System.Drawing.Point(141, 169);
            this.exerciseDurTextBox.Name = "exerciseDurTextBox";
            this.exerciseDurTextBox.Size = new System.Drawing.Size(100, 20);
            this.exerciseDurTextBox.TabIndex = 10;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(84, 86);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(44, 13);
            this.weightLabel.TabIndex = 11;
            this.weightLabel.Text = "Weight:";
            // 
            // sessionLabel
            // 
            this.sessionLabel.AutoSize = true;
            this.sessionLabel.Location = new System.Drawing.Point(81, 119);
            this.sessionLabel.Name = "sessionLabel";
            this.sessionLabel.Size = new System.Drawing.Size(47, 13);
            this.sessionLabel.TabIndex = 12;
            this.sessionLabel.Text = "Session:";
            // 
            // treatmentLabel
            // 
            this.treatmentLabel.AutoSize = true;
            this.treatmentLabel.Location = new System.Drawing.Point(44, 148);
            this.treatmentLabel.Name = "treatmentLabel";
            this.treatmentLabel.Size = new System.Drawing.Size(84, 13);
            this.treatmentLabel.TabIndex = 13;
            this.treatmentLabel.Text = "Treatment Time:";
            // 
            // exerciseDurationLabel
            // 
            this.exerciseDurationLabel.AutoSize = true;
            this.exerciseDurationLabel.Location = new System.Drawing.Point(35, 176);
            this.exerciseDurationLabel.Name = "exerciseDurationLabel";
            this.exerciseDurationLabel.Size = new System.Drawing.Size(93, 13);
            this.exerciseDurationLabel.TabIndex = 14;
            this.exerciseDurationLabel.Text = "Exercise Duration:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(90, 202);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(141, 195);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 15;
            // 
            // prescriptionIDLabel
            // 
            this.prescriptionIDLabel.AutoSize = true;
            this.prescriptionIDLabel.Location = new System.Drawing.Point(49, 228);
            this.prescriptionIDLabel.Name = "prescriptionIDLabel";
            this.prescriptionIDLabel.Size = new System.Drawing.Size(79, 13);
            this.prescriptionIDLabel.TabIndex = 18;
            this.prescriptionIDLabel.Text = "Prescription ID:";
            // 
            // prescriptionTextBox
            // 
            this.prescriptionTextBox.Location = new System.Drawing.Point(141, 221);
            this.prescriptionTextBox.Name = "prescriptionTextBox";
            this.prescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.prescriptionTextBox.TabIndex = 17;
            // 
            // selectedType
            // 
            this.selectedType.FormattingEnabled = true;
            this.selectedType.Items.AddRange(new object[] {
            "medicine",
            "treatment",
            "exercise"});
            this.selectedType.Location = new System.Drawing.Point(141, 247);
            this.selectedType.Name = "selectedType";
            this.selectedType.Size = new System.Drawing.Size(120, 43);
            this.selectedType.TabIndex = 19;
            // 
            // selectType
            // 
            this.selectType.AutoSize = true;
            this.selectType.Location = new System.Drawing.Point(61, 261);
            this.selectType.Name = "selectType";
            this.selectType.Size = new System.Drawing.Size(67, 13);
            this.selectType.TabIndex = 20;
            this.selectType.Text = "Select Type:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 322);
            this.Controls.Add(this.selectType);
            this.Controls.Add(this.selectedType);
            this.Controls.Add(this.prescriptionIDLabel);
            this.Controls.Add(this.prescriptionTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.exerciseDurationLabel);
            this.Controls.Add(this.treatmentLabel);
            this.Controls.Add(this.sessionLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.exerciseDurTextBox);
            this.Controls.Add(this.treatTimeTextBox);
            this.Controls.Add(this.sessionTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.itemListButton);
            this.Controls.Add(this.appointmentHistoryButton);
            this.Controls.Add(this.manageStaffButton);
            this.Controls.Add(this.checkPrescriptionHistory);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button checkPrescriptionHistory;
        private System.Windows.Forms.Button manageStaffButton;
        private System.Windows.Forms.Button appointmentHistoryButton;
        private System.Windows.Forms.Button itemListButton;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox sessionTextBox;
        private System.Windows.Forms.TextBox treatTimeTextBox;
        private System.Windows.Forms.TextBox exerciseDurTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label sessionLabel;
        private System.Windows.Forms.Label treatmentLabel;
        private System.Windows.Forms.Label exerciseDurationLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label prescriptionIDLabel;
        private System.Windows.Forms.TextBox prescriptionTextBox;
        private System.Windows.Forms.ListBox selectedType;
        private System.Windows.Forms.Label selectType;
    }
}