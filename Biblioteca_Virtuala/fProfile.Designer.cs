namespace Biblioteca_Virtuala
{
    partial class fProfile
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
            this.lUsername = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lExtra = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lJoined = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(13, 23);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(97, 13);
            this.lUsername.TabIndex = 0;
            this.lUsername.Text = "Nume de utilizator: ";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(13, 45);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(41, 13);
            this.lName.TabIndex = 1;
            this.lName.Text = "Nume: ";
            // 
            // lExtra
            // 
            this.lExtra.AutoSize = true;
            this.lExtra.Location = new System.Drawing.Point(13, 109);
            this.lExtra.Name = "lExtra";
            this.lExtra.Size = new System.Drawing.Size(36, 13);
            this.lExtra.TabIndex = 2;
            this.lExtra.Text = "Grad: ";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(13, 89);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(38, 13);
            this.lEmail.TabIndex = 3;
            this.lEmail.Text = "Email: ";
            // 
            // lJoined
            // 
            this.lJoined.AutoSize = true;
            this.lJoined.Location = new System.Drawing.Point(13, 67);
            this.lJoined.Name = "lJoined";
            this.lJoined.Size = new System.Drawing.Size(67, 13);
            this.lJoined.TabIndex = 4;
            this.lJoined.Text = "Inregistrat la:";
            // 
            // fProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 138);
            this.Controls.Add(this.lJoined);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lExtra);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fProfile";
            this.Text = "fProfile";
            this.Load += new System.EventHandler(this.fProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lExtra;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lJoined;
    }
}