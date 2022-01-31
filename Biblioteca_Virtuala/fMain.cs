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
    public partial class fMain : Form
    {
        private int formOriginalWidth, sortIndex = 1, selectedCategory = 0;
        private bool formExpanding = false;

        private User meObject;
        private DB database = null;
        private Main mainObject = null;

        private fEditView editForm = null;
        private fAddBook addForm = null;

        public fMain(DB database, Main mainObject, User meObject = null)
        {
            InitializeComponent();

            this.database = database;
            this.mainObject = mainObject;
            this.meObject = meObject;

            if(this.meObject == null)
            {
                System.Windows.Forms.Application.Exit();
            }

            timerUpdateList.Start();
        }
        private void fMain_Load(object sender, EventArgs e)
        {
            formOriginalWidth = this.Width;


            if(meObject is Administrator)
            {
                btnAddBook.Visible = true;
                btnEditBook.Visible = true;
                btnRemoveBook.Visible = true;
                lOnlyAdmin.Visible = true;

                lUserTypeT.ForeColor = Color.Red;
                lUserTypeT.Text = "Administrator";
            }
            else if(meObject is Student)
            {
                lUserTypeT.Text = "Student";
            }
            else
            {
                lUserTypeT.Text = "Utilizator normal";
            }

            database.LoadCategories(mainObject);

            mainObject.UpdateUsersList(listView1);
            mainObject.UpdateBookList(comboBox1, listView2, (meObject is Student || meObject is Administrator), selectedCategory);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            database.LogoutUser(meObject);
            System.Windows.Forms.Application.Exit();
        }

        private void btnOnlineList_Click(object sender, EventArgs e)
        {
            if(this.Width == formOriginalWidth)
            {
                btnOnlineList.Text = "<< Utilizatori conectati";
                formExpanding = true;
                timerAnimation.Start();       
            }
            else
            {
                btnOnlineList.Text = "Utilizatori conectati >>";
                timerAnimation.Start();
            }
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            if(formExpanding)
            {
                if(this.Width < formOriginalWidth + 400)
                {
                    this.Width += 10;
                }
                else
                {
                    formExpanding = false;
                    timerAnimation.Stop();
                }
            }
            else
            {
                if(this.Width > formOriginalWidth)
                {
                    this.Width -= 10;
                }
                else
                {
                    timerAnimation.Stop();
                }
            }
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int selectedUserID = Convert.ToInt32(listView1.SelectedItems[0].Text);

                foreach (User u in mainObject.ConnectedUsers)
                {
                    if (u.GetID == selectedUserID)
                    {
                        u.ShowProfile();

                        break;
                    }
                }
            }

        }

        private void timerUpdateList_Tick(object sender, EventArgs e)
        {
            if(database.UpdateConnectedList(mainObject))
            {
                mainObject.UpdateUsersList(listView1);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            foreach (ListViewItem item in mainObject.BookList.Where(lvi => lvi.SubItems[sortIndex].Text.ToLower().Contains(textBox1.Text.ToLower().Trim()))) //https://stackoverflow.com/questions/51885778/filter-items-in-a-listview-in-real-time/51886069
            {
                listView2.Items.Add(item);
            }
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            if(rbName.Checked)
            {
                sortIndex = 1;
            }
        }

        private void rbAuthor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAuthor.Checked)
            {
                sortIndex = 2;
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if(listView2.SelectedItems.Count == 0)
            {
                return;
            }
            if(editForm == null)
            {
                editForm = new fEditView();
            }

            editForm.LoadData(mainObject.ReturnBookFromID(Convert.ToInt32(listView2.SelectedItems[0].Text)), database, false);
            editForm.ShowDialog();

            mainObject.UpdateBookList(comboBox1, listView2, (meObject is Student || meObject is Administrator), selectedCategory);
        }

        private void btnViewBook_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                return;
            }
            if (editForm == null)
            {
                editForm = new fEditView();
            }

            editForm.LoadData(mainObject.ReturnBookFromID(Convert.ToInt32(listView2.SelectedItems[0].Text)), database);
            editForm.ShowDialog();
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            btnViewBook_Click(sender, e);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if(addForm == null)
            {
                addForm = new fAddBook(mainObject, database);
            }

            addForm.ShowDialog();

            mainObject.UpdateBookList(comboBox1, listView2, (meObject is Student || meObject is Administrator), selectedCategory);
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                return;
            }

            DialogResult res = MessageBox.Show("Esti sigur ca vrei sa stergi aceasta carte?", "Esti sigur?", MessageBoxButtons.YesNo);

            if(res == DialogResult.Yes)
            {
                mainObject.RemoveBookFromItemIndex(database, Convert.ToInt32(listView2.SelectedItems[0].Text));
                mainObject.UpdateBookList(comboBox1, listView2, (meObject is Student || meObject is Administrator), selectedCategory);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory = comboBox1.SelectedIndex;
            mainObject.UpdateBookList(comboBox1, listView2, (meObject is Student || meObject is Administrator), selectedCategory);
        }
    }
}
