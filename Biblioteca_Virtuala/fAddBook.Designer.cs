namespace Biblioteca_Virtuala
{
    partial class fAddBook
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
            this.eName = new System.Windows.Forms.TextBox();
            this.eAuthor = new System.Windows.Forms.TextBox();
            this.eCat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eName
            // 
            this.eName.Location = new System.Drawing.Point(101, 22);
            this.eName.Name = "eName";
            this.eName.Size = new System.Drawing.Size(144, 20);
            this.eName.TabIndex = 0;
            // 
            // eAuthor
            // 
            this.eAuthor.Location = new System.Drawing.Point(101, 58);
            this.eAuthor.Name = "eAuthor";
            this.eAuthor.Size = new System.Drawing.Size(144, 20);
            this.eAuthor.TabIndex = 1;
            // 
            // eCat
            // 
            this.eCat.Location = new System.Drawing.Point(101, 94);
            this.eCat.Name = "eCat";
            this.eCat.Size = new System.Drawing.Size(63, 20);
            this.eCat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume carte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Autor carte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categorie (ID):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(435, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pentru a edita alte detalii ale cartii, se va folosi butonul \"Editeaza carte\" din" +
    " meniul principal";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(371, 155);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Gata";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // fAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 190);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eCat);
            this.Controls.Add(this.eAuthor);
            this.Controls.Add(this.eName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fAddBook";
            this.Text = "Adauga carte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eName;
        private System.Windows.Forms.TextBox eAuthor;
        private System.Windows.Forms.TextBox eCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDone;
    }
}