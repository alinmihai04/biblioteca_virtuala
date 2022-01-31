namespace Biblioteca_Virtuala
{
    partial class fMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOnlineList = new System.Windows.Forms.Button();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.headerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerExtra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerUpdateList = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.bookIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookAuthorHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtyBookHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lOnlyAdmin = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbAuthor = new System.Windows.Forms.RadioButton();
            this.lUserType = new System.Windows.Forms.Label();
            this.lUserTypeT = new System.Windows.Forms.Label();
            this.btnViewBook = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnOnlineList
            // 
            this.btnOnlineList.Location = new System.Drawing.Point(660, 404);
            this.btnOnlineList.Name = "btnOnlineList";
            this.btnOnlineList.Size = new System.Drawing.Size(128, 34);
            this.btnOnlineList.TabIndex = 1;
            this.btnOnlineList.Text = "Utilizatori conectati >>";
            this.btnOnlineList.UseVisualStyleBackColor = true;
            this.btnOnlineList.Click += new System.EventHandler(this.btnOnlineList_Click);
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 10;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerID,
            this.headerName,
            this.headerAge,
            this.headerExtra});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(816, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(357, 380);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // headerID
            // 
            this.headerID.Text = "ID";
            // 
            // headerName
            // 
            this.headerName.Text = "Nume";
            // 
            // headerAge
            // 
            this.headerAge.Text = "Varsta";
            // 
            // headerExtra
            // 
            this.headerExtra.Text = "Informatii suplimentare";
            this.headerExtra.Width = 300;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.profilToolStripMenuItem.Text = "Profil";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // timerUpdateList
            // 
            this.timerUpdateList.Interval = 5000;
            this.timerUpdateList.Tick += new System.EventHandler(this.timerUpdateList_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(490, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cauta o carte:";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookIdHeader,
            this.bookNameHeader,
            this.bookAuthorHeader,
            this.qtyBookHeader});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(154, 139);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(487, 299);
            this.listView2.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            // 
            // bookIdHeader
            // 
            this.bookIdHeader.Text = "ID";
            this.bookIdHeader.Width = 53;
            // 
            // bookNameHeader
            // 
            this.bookNameHeader.Text = "Nume";
            this.bookNameHeader.Width = 178;
            // 
            // bookAuthorHeader
            // 
            this.bookAuthorHeader.Text = "Autor";
            this.bookAuthorHeader.Width = 151;
            // 
            // qtyBookHeader
            // 
            this.qtyBookHeader.Text = "Cantitate";
            this.qtyBookHeader.Width = 100;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Toate categoriile";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lOnlyAdmin
            // 
            this.lOnlyAdmin.AutoSize = true;
            this.lOnlyAdmin.Location = new System.Drawing.Point(9, 318);
            this.lOnlyAdmin.Name = "lOnlyAdmin";
            this.lOnlyAdmin.Size = new System.Drawing.Size(131, 13);
            this.lOnlyAdmin.TabIndex = 7;
            this.lOnlyAdmin.Text = "Doar pentru Administratori:";
            this.lOnlyAdmin.Visible = false;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(12, 334);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(120, 29);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Adauga carte";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Visible = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(12, 404);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(120, 29);
            this.btnRemoveBook.TabIndex = 9;
            this.btnRemoveBook.Text = "Sterge carte";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Visible = false;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(13, 369);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(120, 29);
            this.btnEditBook.TabIndex = 10;
            this.btnEditBook.Text = "Editeaza carte";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Visible = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Checked = true;
            this.rbName.Location = new System.Drawing.Point(151, 116);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(80, 17);
            this.rbName.TabIndex = 11;
            this.rbName.TabStop = true;
            this.rbName.Text = "Dupa nume";
            this.rbName.UseVisualStyleBackColor = true;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged);
            // 
            // rbAuthor
            // 
            this.rbAuthor.AutoSize = true;
            this.rbAuthor.Location = new System.Drawing.Point(237, 116);
            this.rbAuthor.Name = "rbAuthor";
            this.rbAuthor.Size = new System.Drawing.Size(78, 17);
            this.rbAuthor.TabIndex = 12;
            this.rbAuthor.Text = "Dupa autor";
            this.rbAuthor.UseVisualStyleBackColor = true;
            this.rbAuthor.CheckedChanged += new System.EventHandler(this.rbAuthor_CheckedChanged);
            // 
            // lUserType
            // 
            this.lUserType.AutoSize = true;
            this.lUserType.Location = new System.Drawing.Point(12, 139);
            this.lUserType.Name = "lUserType";
            this.lUserType.Size = new System.Drawing.Size(66, 13);
            this.lUserType.TabIndex = 15;
            this.lUserType.Text = "Tip utilizator:";
            // 
            // lUserTypeT
            // 
            this.lUserTypeT.AutoSize = true;
            this.lUserTypeT.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserTypeT.Location = new System.Drawing.Point(12, 157);
            this.lUserTypeT.Name = "lUserTypeT";
            this.lUserTypeT.Size = new System.Drawing.Size(96, 17);
            this.lUserTypeT.TabIndex = 16;
            this.lUserTypeT.Text = "Tip utilizator:";
            // 
            // btnViewBook
            // 
            this.btnViewBook.Location = new System.Drawing.Point(11, 177);
            this.btnViewBook.Name = "btnViewBook";
            this.btnViewBook.Size = new System.Drawing.Size(120, 29);
            this.btnViewBook.TabIndex = 18;
            this.btnViewBook.Text = "Vizualizeaza carte";
            this.btnViewBook.UseVisualStyleBackColor = true;
            this.btnViewBook.Click += new System.EventHandler(this.btnViewBook_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.btnViewBook);
            this.Controls.Add(this.lUserTypeT);
            this.Controls.Add(this.lUserType);
            this.Controls.Add(this.rbAuthor);
            this.Controls.Add(this.rbName);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lOnlyAdmin);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnOnlineList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.Text = "Biblioteca virtuala";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMain_FormClosed);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnOnlineList;
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader headerID;
        private System.Windows.Forms.ColumnHeader headerName;
        private System.Windows.Forms.ColumnHeader headerExtra;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.Timer timerUpdateList;
        private System.Windows.Forms.ColumnHeader headerAge;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lOnlyAdmin;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbAuthor;
        private System.Windows.Forms.Label lUserType;
        private System.Windows.Forms.Label lUserTypeT;
        private System.Windows.Forms.Button btnViewBook;
        private System.Windows.Forms.ColumnHeader bookIdHeader;
        private System.Windows.Forms.ColumnHeader bookNameHeader;
        private System.Windows.Forms.ColumnHeader bookAuthorHeader;
        private System.Windows.Forms.ColumnHeader qtyBookHeader;
    }
}