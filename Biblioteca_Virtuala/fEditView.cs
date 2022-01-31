using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Virtuala
{
    public partial class fEditView : Form
    {
        private bool formLoaded = false, readOnly = true;
        private List<string> operations;
        private List<BookEdit> bookOperations;

        private Book bookObject;
        private DB database;

        public fEditView()
        {
            InitializeComponent();
        }

        public void LoadData(Book bookObject, DB database, bool readOnly = true)
        {
            this.bookObject = bookObject;
            this.database = database;
            this.readOnly = readOnly;

            operations = new List<string>();
            bookOperations = new List<BookEdit>();

            bookOperations.Add(new BookName());
            bookOperations.Add(new BookAuthor());
            bookOperations.Add(new BookDesc());
            bookOperations.Add(new BookQty());
        }


        private void fEdit_Load(object sender, EventArgs e)
        {
            formLoaded = false;

            if (bookObject == null || database == null)
            {
                this.Close();
            }

            string[] info = bookObject.BookFullInfo();

            if (readOnly)
            {
                this.Text = "Vizualizezi cartea: " + info[0];

                ViewMode(false);
            }
            else
            {
                this.Text = "Editezi cartea: " + info[0];

                ViewMode(true);
            }


            this.eName.Text = info[0];
            this.eAuthor.Text = info[1];
            this.eDesc.Text = info[2];
            this.eQty.Text = info[3];
            this.labelAdded.Text = "Carte adaugata la: \n" + info[4];

            formLoaded = true;
        }

        private void ViewMode(bool state)
        {
            this.eName.Enabled = state;
            this.eAuthor.Enabled = state;
            this.eDesc.Enabled = state;
            this.eQty.Enabled = state;
        }

        private void eName_TextChanged(object sender, EventArgs e)
        {
            if (!formLoaded)
                return;

            if(!operations.Contains("editName"))
            {
                operations.Add("editName");
            }
        }

        private void eAuthor_TextChanged(object sender, EventArgs e)
        {
            if (!formLoaded)
                return;

            if (!operations.Contains("editAuthor"))
            {
                operations.Add("editAuthor");
            }
        }

        private void eDesc_TextChanged(object sender, EventArgs e)
        {
            if (!formLoaded)
                return;

            if (!operations.Contains("editDesc"))
            {
                operations.Add("editDesc");
            }
        }
        private void eQty_TextChanged(object sender, EventArgs e)
        {
            if (!formLoaded)
                return;

            if (!operations.Contains("editQty"))
            {
                operations.Add("editQty");
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if(!readOnly)
            { 
                foreach (string s in operations)
                {
                    foreach (BookEdit op in bookOperations)
                    {
                        if (op.input(s))
                        {
                            op.edit(database, bookObject, getTb(s).Text);
                        }
                    }
                }
            }

            this.Close();
        }
        private TextBox getTb(string input)
        {
            switch(input)
            {
                case "editName":
                    return eName;
                case "editAuthor":
                    return eAuthor;
                case "editDesc":
                    return eDesc;
                case "editQty":
                    return eQty;
            }

            return null;
        }
    }
}
