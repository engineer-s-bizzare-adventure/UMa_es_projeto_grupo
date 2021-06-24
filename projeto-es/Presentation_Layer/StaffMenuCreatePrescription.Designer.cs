using System.Collections.Generic;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace projeto_es.Presentation_Layer
{
    partial class StaffMenuCreatePrescription
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
            this.area_descrição = new System.Windows.Forms.RichTextBox();
            this.label_description = new System.Windows.Forms.Label();
            this.label_name_utente = new System.Windows.Forms.Label();
            this.tb_name_utente = new System.Windows.Forms.TextBox();
            this.btn_confirm_prescription = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // area_descrição
            // 
            this.area_descrição.Location = new System.Drawing.Point(139, 154);
            this.area_descrição.Name = "area_descrição";
            this.area_descrição.Size = new System.Drawing.Size(580, 192);
            this.area_descrição.TabIndex = 3;
            this.area_descrição.Text = "";
            this.area_descrição.TextChanged += new System.EventHandler(this.area_descrição_TextChanged);
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_description.Location = new System.Drawing.Point(61, 157);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(60, 13);
            this.label_description.TabIndex = 1;
            this.label_description.Text = "Description";
            // 
            // label_name_utente
            // 
            this.label_name_utente.AutoSize = true;
            this.label_name_utente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_name_utente.Location = new System.Drawing.Point(26, 114);
            this.label_name_utente.Name = "label_name_utente";
            this.label_name_utente.Size = new System.Drawing.Size(104, 13);
            this.label_name_utente.TabIndex = 0;
            this.label_name_utente.Text = "Name of prescription";
            this.label_name_utente.Click += new System.EventHandler(this.label_name_utente_Click);
            // 
            // tb_name_utente
            // 
            this.tb_name_utente.AccessibleName = "Nome Completo";
            this.tb_name_utente.ForeColor = System.Drawing.Color.Black;
            this.tb_name_utente.Location = new System.Drawing.Point(139, 114);
            this.tb_name_utente.Name = "tb_name_utente";
            this.tb_name_utente.Size = new System.Drawing.Size(580, 20);
            this.tb_name_utente.TabIndex = 9;
            this.tb_name_utente.Tag = "";
            this.tb_name_utente.TextChanged += new System.EventHandler(this.tb_name_utente_TextChanged);
            // 
            // btn_confirm_prescription
            // 
            this.btn_confirm_prescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_confirm_prescription.Location = new System.Drawing.Point(567, 380);
            this.btn_confirm_prescription.Name = "btn_confirm_prescription";
            this.btn_confirm_prescription.Size = new System.Drawing.Size(152, 36);
            this.btn_confirm_prescription.TabIndex = 9;
            this.btn_confirm_prescription.Text = "Create";
            this.btn_confirm_prescription.UseVisualStyleBackColor = true;
            this.btn_confirm_prescription.Click += new System.EventHandler(this.btn_confirm_prescription_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(767, 28);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // StaffMenuCreatePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.area_descrição);
            this.Controls.Add(this.btn_confirm_prescription);
            this.Controls.Add(this.tb_name_utente);
            this.Controls.Add(this.label_name_utente);
            this.MaximizeBox = false;
            this.Name = "StaffMenuCreatePrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make prescription";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btn_close);
            this.Load += new System.EventHandler(this.StaffMenuCreateAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_name_utente;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.RichTextBox area_descrição;
        private TextBox tb_name_utente;
        private Button btn_confirm_prescription;
        private Button backButton;
    }
}
    