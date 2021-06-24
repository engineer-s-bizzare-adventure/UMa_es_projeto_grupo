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
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_prescription = new System.Windows.Forms.Panel();
            this.RB_exercise = new System.Windows.Forms.RadioButton();
            this.RB_treatment = new System.Windows.Forms.RadioButton();
            this.RB_Medican = new System.Windows.Forms.RadioButton();
            this.kind_prescription = new System.Windows.Forms.Label();
            this.btn_confirm_prescription = new System.Windows.Forms.Button();
            this.area_descrição = new System.Windows.Forms.RichTextBox();
            this.tb_name_utente = new System.Windows.Forms.TextBox();
            this.label_description = new System.Windows.Forms.Label();
            this.label_name_utente = new System.Windows.Forms.Label();
            this.pnl_prescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(634, 393);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(152, 36);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pnl_prescription
            // 
            this.pnl_prescription.Controls.Add(this.RB_exercise);
            this.pnl_prescription.Controls.Add(this.RB_treatment);
            this.pnl_prescription.Controls.Add(this.RB_Medican);
            this.pnl_prescription.Controls.Add(this.kind_prescription);
            this.pnl_prescription.Controls.Add(this.btn_confirm_prescription);
            this.pnl_prescription.Controls.Add(this.area_descrição);
            this.pnl_prescription.Controls.Add(this.tb_name_utente);
            this.pnl_prescription.Controls.Add(this.label_description);
            this.pnl_prescription.Controls.Add(this.label_name_utente);
            this.pnl_prescription.Location = new System.Drawing.Point(36, 33);
            this.pnl_prescription.Name = "pnl_prescription";
            this.pnl_prescription.Size = new System.Drawing.Size(764, 354);
            this.pnl_prescription.TabIndex = 8;
            // 
            // RB_exercise
            // 
            this.RB_exercise.AutoSize = true;
            this.RB_exercise.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_exercise.Location = new System.Drawing.Point(450, 308);
            this.RB_exercise.Name = "RB_exercise";
            this.RB_exercise.Size = new System.Drawing.Size(76, 19);
            this.RB_exercise.TabIndex = 13;
            this.RB_exercise.TabStop = true;
            this.RB_exercise.Text = "Exercício";
            this.RB_exercise.UseVisualStyleBackColor = true;
            // 
            // RB_treatment
            // 
            this.RB_treatment.AutoSize = true;
            this.RB_treatment.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_treatment.Location = new System.Drawing.Point(326, 308);
            this.RB_treatment.Name = "RB_treatment";
            this.RB_treatment.Size = new System.Drawing.Size(83, 19);
            this.RB_treatment.TabIndex = 12;
            this.RB_treatment.TabStop = true;
            this.RB_treatment.Text = "Tratamento";
            this.RB_treatment.UseVisualStyleBackColor = true;
            // 
            // RB_Medican
            // 
            this.RB_Medican.AutoSize = true;
            this.RB_Medican.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Medican.Location = new System.Drawing.Point(202, 308);
            this.RB_Medican.Name = "RB_Medican";
            this.RB_Medican.Size = new System.Drawing.Size(93, 19);
            this.RB_Medican.TabIndex = 11;
            this.RB_Medican.TabStop = true;
            this.RB_Medican.Text = "Medicamento";
            this.RB_Medican.UseVisualStyleBackColor = true;
            // 
            // kind_prescription
            // 
            this.kind_prescription.AutoSize = true;
            this.kind_prescription.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kind_prescription.Location = new System.Drawing.Point(29, 306);
            this.kind_prescription.Name = "kind_prescription";
            this.kind_prescription.Size = new System.Drawing.Size(127, 19);
            this.kind_prescription.TabIndex = 10;
            this.kind_prescription.Text = "Tipo de Prescrição";
            // 
            // btn_confirm_prescription
            // 
            this.btn_confirm_prescription.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm_prescription.Location = new System.Drawing.Point(590, 306);
            this.btn_confirm_prescription.Name = "btn_confirm_prescription";
            this.btn_confirm_prescription.Size = new System.Drawing.Size(152, 36);
            this.btn_confirm_prescription.TabIndex = 9;
            this.btn_confirm_prescription.Text = "Confirmar";
            this.btn_confirm_prescription.UseVisualStyleBackColor = true;
            this.btn_confirm_prescription.Click += new System.EventHandler(this.btn_confirm_prescription_Click);
            // 
            // area_descrição
            // 
            this.area_descrição.Location = new System.Drawing.Point(162, 85);
            this.area_descrição.Name = "area_descrição";
            this.area_descrição.Size = new System.Drawing.Size(580, 192);
            this.area_descrição.TabIndex = 3;
            this.area_descrição.Text = "Descrição da Prescrição";
            this.area_descrição.TextChanged += new System.EventHandler(this.area_descrição_TextChanged);
            // 
            // tb_name_utente
            // 
            this.tb_name_utente.AccessibleName = "Nome Completo";
            this.tb_name_utente.ForeColor = System.Drawing.Color.Black;
            this.tb_name_utente.Location = new System.Drawing.Point(162, 40);
            this.tb_name_utente.Name = "tb_name_utente";
            this.tb_name_utente.Size = new System.Drawing.Size(580, 20);
            this.tb_name_utente.TabIndex = 2;
            this.tb_name_utente.Tag = "";
            this.tb_name_utente.Text = "Nome Completo";
            this.tb_name_utente.Click += new System.EventHandler(this.tb_name_utente_TextChanged);
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(29, 84);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(69, 19);
            this.label_description.TabIndex = 1;
            this.label_description.Text = "Descrição";
            // 
            // label_name_utente
            // 
            this.label_name_utente.AutoSize = true;
            this.label_name_utente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_utente.Location = new System.Drawing.Point(29, 39);
            this.label_name_utente.Name = "label_name_utente";
            this.label_name_utente.Size = new System.Drawing.Size(111, 19);
            this.label_name_utente.TabIndex = 0;
            this.label_name_utente.Text = "Nome do utente";
            // 
            // StaffMenuCreatePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.pnl_prescription);
            this.Controls.Add(this.btn_back);
            this.MaximizeBox = false;
            this.Name = "StaffMenuCreatePrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make prescription";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btn_close);
            this.Load += new System.EventHandler(this.StaffMenuCreateAppointment_Load);
            this.pnl_prescription.ResumeLayout(false);
            this.pnl_prescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel pnl_prescription;
        private System.Windows.Forms.Label label_name_utente;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox tb_name_utente;
        private System.Windows.Forms.RichTextBox area_descrição;
        

        private Button btn_confirm_prescription;
        private RadioButton RB_exercise;
        private RadioButton RB_treatment;
        private RadioButton RB_Medican;
        private Label kind_prescription;
    }
}
    