namespace Biblioteca_Virtuala
{
    partial class fEditView
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
            this.eDesc = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eQty = new System.Windows.Forms.TextBox();
            this.labelAdded = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eName
            // 
            this.eName.Location = new System.Drawing.Point(80, 12);
            this.eName.Name = "eName";
            this.eName.Size = new System.Drawing.Size(293, 20);
            this.eName.TabIndex = 0;
            this.eName.TextChanged += new System.EventHandler(this.eName_TextChanged);
            // 
            // eAuthor
            // 
            this.eAuthor.Location = new System.Drawing.Point(80, 48);
            this.eAuthor.Name = "eAuthor";
            this.eAuthor.Size = new System.Drawing.Size(293, 20);
            this.eAuthor.TabIndex = 1;
            this.eAuthor.TextChanged += new System.EventHandler(this.eAuthor_TextChanged);
            // 
            // eDesc
            // 
            this.eDesc.Location = new System.Drawing.Point(80, 90);
            this.eDesc.Multiline = true;
            this.eDesc.Name = "eDesc";
            this.eDesc.Size = new System.Drawing.Size(293, 96);
            this.eDesc.TabIndex = 2;
            this.eDesc.TextChanged += new System.EventHandler(this.eDesc_TextChanged);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(451, 163);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Gata";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descriere:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantitate:";
            // 
            // eQty
            // 
            this.eQty.Location = new System.Drawing.Point(451, 15);
            this.eQty.Name = "eQty";
            this.eQty.Size = new System.Drawing.Size(75, 20);
            this.eQty.TabIndex = 8;
            this.eQty.TextChanged += new System.EventHandler(this.eQty_TextChanged);
            // 
            // labelAdded
            // 
            this.labelAdded.AutoSize = true;
            this.labelAdded.Location = new System.Drawing.Point(396, 48);
            this.labelAdded.Name = "labelAdded";
            this.labelAdded.Size = new System.Drawing.Size(97, 13);
            this.labelAdded.TabIndex = 9;
            this.labelAdded.Text = "Carte adaugata la: ";
            // 
            // fEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 198);
            this.Controls.Add(this.labelAdded);
            this.Controls.Add(this.eQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.eDesc);
            this.Controls.Add(this.eAuthor);
            this.Controls.Add(this.eName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fEditView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEdit";
            this.Load += new System.EventHandler(this.fEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eName;
        private System.Windows.Forms.TextBox eAuthor;
        private System.Windows.Forms.TextBox eDesc;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eQty;
        private System.Windows.Forms.Label labelAdded;
    }
}