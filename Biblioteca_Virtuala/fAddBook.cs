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
    public partial class fAddBook : Form
    {
        private Main mainObject;
        private DB database;

        public fAddBook(Main mainObject, DB database)
        {
            InitializeComponent();

            this.mainObject = mainObject;
            this.database = database;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (eName.Text == string.Empty || eAuthor.Text == string.Empty || eCat.Text == string.Empty)
            {
                MessageBox.Show("Completeaza toate campurile!");
                return;
            }
            if(!int.TryParse(eCat.Text, out int category))
            {
                MessageBox.Show("Categoria trebuie sa fie un numar!");
                return;
            }

            mainObject.AddBook(database, eName.Text, eAuthor.Text, category);


            eName.Clear();
            eAuthor.Clear();
            eCat.Clear();
            this.Close();
        }
    }
}
