
namespace projeto_es
{
    partial class CredentialsForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.loginRegisterLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.credentialsPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsPic)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(65, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(264, 20);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Bem-vindo ao Sistema de Apoio";
            // 
            // loginRegisterLabel
            // 
            this.loginRegisterLabel.AutoSize = true;
            this.loginRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginRegisterLabel.Location = new System.Drawing.Point(120, 276);
            this.loginRegisterLabel.Name = "loginRegisterLabel";
            this.loginRegisterLabel.Size = new System.Drawing.Size(143, 13);
            this.loginRegisterLabel.TabIndex = 1;
            this.loginRegisterLabel.Text = "Faça login ou registe-se";
            this.loginRegisterLabel.Click += new System.EventHandler(this.loginRegisterLabel_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(151, 304);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(151, 333);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Registrar";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // credentialsPic
            // 
            this.credentialsPic.Image = global::projeto_es.Properties.Resources.pubbsk4oked41;
            this.credentialsPic.Location = new System.Drawing.Point(93, 48);
            this.credentialsPic.Name = "credentialsPic";
            this.credentialsPic.Size = new System.Drawing.Size(202, 211);
            this.credentialsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.credentialsPic.TabIndex = 4;
            this.credentialsPic.TabStop = false;
            // 
            // CredentialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 391);
            this.Controls.Add(this.credentialsPic);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginRegisterLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "CredentialsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CredentialsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.credentialsPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label loginRegisterLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.PictureBox credentialsPic;
    }
}