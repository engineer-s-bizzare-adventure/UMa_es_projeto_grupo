
namespace projeto_es.Presentation_Layer
{
    partial class UserMenuForm
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
            this.accountButton = new System.Windows.Forms.Button();
            this.appointmentsButton = new System.Windows.Forms.Button();
            this.prescriptionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountButton
            // 
            this.accountButton.Location = new System.Drawing.Point(713, 12);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(75, 23);
            this.accountButton.TabIndex = 0;
            this.accountButton.Text = "My account";
            this.accountButton.UseVisualStyleBackColor = true;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // appointmentsButton
            // 
            this.appointmentsButton.Location = new System.Drawing.Point(97, 341);
            this.appointmentsButton.Name = "appointmentsButton";
            this.appointmentsButton.Size = new System.Drawing.Size(207, 23);
            this.appointmentsButton.TabIndex = 1;
            this.appointmentsButton.Text = "Check Appointments";
            this.appointmentsButton.UseVisualStyleBackColor = true;
            this.appointmentsButton.Click += new System.EventHandler(this.appointmentsButton_Click);
            // 
            // prescriptionsButton
            // 
            this.prescriptionsButton.Location = new System.Drawing.Point(488, 341);
            this.prescriptionsButton.Name = "prescriptionsButton";
            this.prescriptionsButton.Size = new System.Drawing.Size(207, 23);
            this.prescriptionsButton.TabIndex = 2;
            this.prescriptionsButton.Text = "Check Prescriptions";
            this.prescriptionsButton.UseVisualStyleBackColor = true;
            this.prescriptionsButton.Click += new System.EventHandler(this.prescriptionsButton_Click);
            // 
            // UserMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prescriptionsButton);
            this.Controls.Add(this.appointmentsButton);
            this.Controls.Add(this.accountButton);
            this.Name = "UserMenuForm";
            this.Text = "ClientMenuForm";
            this.Load += new System.EventHandler(this.UserMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.Button appointmentsButton;
        private System.Windows.Forms.Button prescriptionsButton;
    }
}