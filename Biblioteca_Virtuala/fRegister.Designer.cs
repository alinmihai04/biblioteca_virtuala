namespace Biblioteca_Virtuala
{
    partial class fRegister
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.eUsername = new System.Windows.Forms.TextBox();
            this.ePassword = new System.Windows.Forms.TextBox();
            this.ePasswordConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.eFullname = new System.Windows.Forms.TextBox();
            this.eEmail = new System.Windows.Forms.TextBox();
            this.eAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(39, 193);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(113, 34);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Inregistrare";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // eUsername
            // 
            this.eUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.eUsername.Location = new System.Drawing.Point(39, 39);
            this.eUsername.Name = "eUsername";
            this.eUsername.Size = new System.Drawing.Size(138, 20);
            this.eUsername.TabIndex = 1;
            // 
            // ePassword
            // 
            this.ePassword.Location = new System.Drawing.Point(39, 95);
            this.ePassword.Name = "ePassword";
            this.ePassword.Size = new System.Drawing.Size(138, 20);
            this.ePassword.TabIndex = 2;
            this.ePassword.UseSystemPasswordChar = true;
            // 
            // ePasswordConfirm
            // 
            this.ePasswordConfirm.Location = new System.Drawing.Point(39, 144);
            this.ePasswordConfirm.Name = "ePasswordConfirm";
            this.ePasswordConfirm.Size = new System.Drawing.Size(138, 20);
            this.ePasswordConfirm.TabIndex = 3;
            this.ePasswordConfirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nume de utilizator:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parola:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirma parola:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(42, 174);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Inapoi la logare";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nume complet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Varsta";
            // 
            // eFullname
            // 
            this.eFullname.Location = new System.Drawing.Point(202, 39);
            this.eFullname.Name = "eFullname";
            this.eFullname.Size = new System.Drawing.Size(138, 20);
            this.eFullname.TabIndex = 12;
            // 
            // eEmail
            // 
            this.eEmail.Location = new System.Drawing.Point(202, 94);
            this.eEmail.Name = "eEmail";
            this.eEmail.Size = new System.Drawing.Size(138, 20);
            this.eEmail.TabIndex = 13;
            // 
            // eAge
            // 
            this.eAge.Location = new System.Drawing.Point(202, 143);
            this.eAge.Name = "eAge";
            this.eAge.Size = new System.Drawing.Size(138, 20);
            this.eAge.TabIndex = 14;
            // 
            // fRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 250);
            this.Controls.Add(this.eAge);
            this.Controls.Add(this.eEmail);
            this.Controls.Add(this.eFullname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ePasswordConfirm);
            this.Controls.Add(this.ePassword);
            this.Controls.Add(this.eUsername);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(469, 289);
            this.MinimumSize = new System.Drawing.Size(469, 289);
            this.Name = "fRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inregistreaza-te";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fRegister_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox eUsername;
        private System.Windows.Forms.TextBox ePassword;
        private System.Windows.Forms.TextBox ePasswordConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox eFullname;
        private System.Windows.Forms.TextBox eEmail;
        private System.Windows.Forms.TextBox eAge;
    }
}