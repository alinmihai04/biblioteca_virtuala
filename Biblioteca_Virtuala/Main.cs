using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteca_Virtuala
{
    public class Main
    {
        private List<User> connectedUsers = new List<User>();
        public List<User> ConnectedUsers
        {
            get { return connectedUsers; }
            set { connectedUsers = value; }
        }

        protected List<Category> categories = new List<Category>();
        public List<Category> Categories
        {
            get { return categories; }
            set { categories = value; }
        }

        private List<ListViewItem> bookList = new List<ListViewItem>();
        public List<ListViewItem> BookList
        {
            get { return bookList; }
        }

        public void UpdateUsersList(ListView list)
        {
            list.Items.Clear();

            string[] userListInfo;
            ListViewItem item;

            foreach (User u in connectedUsers)
            {
                userListInfo = u.OnlineInfo();

                item = new ListViewItem(userListInfo[0], 0);
                item.SubItems.Add(userListInfo[1]);
                item.SubItems.Add(userListInfo[2]);
                item.SubItems.Add(userListInfo[3]);

                list.Items.Add(item);
            }
        }
        public void UpdateBookList(ComboBox combo, ListView list, bool isStudent = false, int category = 0)
        {
            if(combo.Items.Count == 0)
            {
                UpdateCategoriesList(combo, isStudent);
            }

            ListViewItem item;
            string[] bookInfo;

            bookList.Clear();
            foreach (Category c in categories)
            {
                if(category == 0 || c.CheckCategory(category))
                {
                    foreach (Book b in c.Books)
                    {
                        bookInfo = b.BookListInfo();

                        item = new ListViewItem(bookInfo[0]);

                        item.SubItems.Add(bookInfo[1]);
                        item.SubItems.Add(bookInfo[2]);
                        item.SubItems.Add(bookInfo[3]);

                        bookList.Add(item);
                    }
                }

            }

            DisplayItems(list);
        }
        private void UpdateCategoriesList(ComboBox combo, bool isStudent)
        {
            combo.Items.Clear();
            combo.Items.Add("Toate categoriile");

            foreach (Category c in categories)
            {
                if (c.CategName == "Studenti" && !isStudent)
                {
                    continue;
                }

                combo.Items.Add(c.CategName);
            }
        }
        private void DisplayItems(ListView list)
        {
            list.Items.Clear();

            foreach (ListViewItem item in bookList)
            {
                list.Items.Add(item);
            }
        }
        public Book ReturnBookFromID(int id)
        {
            Book returnBook = null;

            foreach(Category c in categories)
            {
                foreach(Book b in c.Books)
                {
                    if(b.BookID == id)
                    {
                        returnBook = b;
                        break;
                    }
                }
            }

            return returnBook;
        }
        public void RemoveBookFromItemIndex(DB database, int id)
        {
            database.SqlQuery = new MySqlCommand("delete from books where id='" + id + "'", database.Conn);
            database.SqlQuery.ExecuteNonQuery();

            foreach (Category c in categories)
            {
                foreach (Book b in c.Books)
                {
                    if (b.BookID == id)
                    {
                        c.Books.Remove(b);
                        break;
                    }
                }
            }
        }
        public void AddBook(DB database, string name, string author, int category)
        {
            bool isValidCategory = false;

            foreach(Category c in categories)
            {
                if(c.CheckCategory(category))
                {
                    isValidCategory = true;
                    break;
                }
            }

            if (!isValidCategory)
                return;

            database.SqlQuery = new MySqlCommand("insert into books (Name,Author,Category) values (@Name,@Author,@Category)", database.Conn);
            database.SqlQuery.Parameters.AddWithValue("name", name);
            database.SqlQuery.Parameters.AddWithValue("author", author);
            database.SqlQuery.Parameters.AddWithValue("category", category);
            database.SqlQuery.ExecuteNonQuery();

            foreach (Category c in categories)
            {
                if (c.CheckCategory(category))
                {
                    c.LoadSingleBook(name);
                    break;
                }
            }
        }

    }
}
