
namespace projeto_es.Presentation_Layer
{
    partial class UserMenuNoPrescriptionsForm
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
            this.noPrecriptionsLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noPrecriptionsLabel
            // 
            this.noPrecriptionsLabel.AutoSize = true;
            this.noPrecriptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noPrecriptionsLabel.Location = new System.Drawing.Point(148, 60);
            this.noPrecriptionsLabel.Name = "noPrecriptionsLabel";
            this.noPrecriptionsLabel.Size = new System.Drawing.Size(486, 31);
            this.noPrecriptionsLabel.TabIndex = 1;
            this.noPrecriptionsLabel.Text = "You don\'t have any prescriptions yet\r\n";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(765, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(303, 214);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(195, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // UserMenuNoPrescriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.noPrecriptionsLabel);
            this.Name = "UserMenuNoPrescriptionsForm";
            this.Text = "UserMenuNoPrescriptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noPrecriptionsLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button okButton;
    }
}