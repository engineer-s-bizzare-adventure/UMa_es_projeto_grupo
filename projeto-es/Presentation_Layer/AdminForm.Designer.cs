
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
            this.dataGridHolder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // checkPrescriptionHistory
            // 
            this.checkPrescriptionHistory.Location = new System.Drawing.Point(12, 41);
            this.checkPrescriptionHistory.Name = "checkPrescriptionHistory";
            this.checkPrescriptionHistory.Size = new System.Drawing.Size(123, 23);
            this.checkPrescriptionHistory.TabIndex = 1;
            this.checkPrescriptionHistory.Text = "Prescription history";
            this.checkPrescriptionHistory.UseVisualStyleBackColor = true;
            this.checkPrescriptionHistory.Click += new System.EventHandler(this.checkPrescriptionHistory_Click);
            // 
            // manageStaffButton
            // 
            this.manageStaffButton.Location = new System.Drawing.Point(12, 12);
            this.manageStaffButton.Name = "manageStaffButton";
            this.manageStaffButton.Size = new System.Drawing.Size(123, 23);
            this.manageStaffButton.TabIndex = 2;
            this.manageStaffButton.Text = "Manage staff members";
            this.manageStaffButton.UseVisualStyleBackColor = true;
            this.manageStaffButton.Click += new System.EventHandler(this.manageStaffButton_Click);
            // 
            // appointmentHistoryButton
            // 
            this.appointmentHistoryButton.Location = new System.Drawing.Point(12, 70);
            this.appointmentHistoryButton.Name = "appointmentHistoryButton";
            this.appointmentHistoryButton.Size = new System.Drawing.Size(123, 23);
            this.appointmentHistoryButton.TabIndex = 3;
            this.appointmentHistoryButton.Text = "Appointment history";
            this.appointmentHistoryButton.UseVisualStyleBackColor = true;
            this.appointmentHistoryButton.Click += new System.EventHandler(this.appointmentHistoryButton_Click);
            // 
            // itemListButton
            // 
            this.itemListButton.Location = new System.Drawing.Point(12, 99);
            this.itemListButton.Name = "itemListButton";
            this.itemListButton.Size = new System.Drawing.Size(123, 23);
            this.itemListButton.TabIndex = 4;
            this.itemListButton.Text = "Prescribed item history";
            this.itemListButton.UseVisualStyleBackColor = true;
            this.itemListButton.Click += new System.EventHandler(this.itemListButton_Click);
            // 
            // dataGridHolder
            // 
            this.dataGridHolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHolder.Location = new System.Drawing.Point(12, 128);
            this.dataGridHolder.Name = "dataGridHolder";
            this.dataGridHolder.Size = new System.Drawing.Size(460, 321);
            this.dataGridHolder.TabIndex = 5;
            this.dataGridHolder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHolder_CellContentClick);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.dataGridHolder);
            this.Controls.Add(this.itemListButton);
            this.Controls.Add(this.appointmentHistoryButton);
            this.Controls.Add(this.manageStaffButton);
            this.Controls.Add(this.checkPrescriptionHistory);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHolder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button checkPrescriptionHistory;
        private System.Windows.Forms.Button manageStaffButton;
        private System.Windows.Forms.Button appointmentHistoryButton;
        private System.Windows.Forms.Button itemListButton;
        private System.Windows.Forms.DataGridView dataGridHolder;
    }
}