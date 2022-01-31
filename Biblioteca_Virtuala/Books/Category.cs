using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Biblioteca_Virtuala
{
    public class Category
    {
        private int categID = 9999;

        private string categName = "category error";
        public string CategName
        {
            get { return categName; }
        }

        private DB database = null;

        private List<Book> books;
        public List<Book> Books
        {
            get { return books; }
        }

        public Category() { }
        public Category(int categID, string categName, DB database)
        {
            this.categID = categID;
            this.categName = categName;
            this.database = database;

            books = new List<Book>();
        }

        public bool CheckCategory(int value)
        {
            if(value == this.categID)
            {
                return true;
            }

            return false;
        }

        public void LoadBooks()
        {
            database.SqlQuery = new MySqlCommand("select * from books where Category='" + categID + "'", database.Conn);
            database.SqlReader = database.SqlQuery.ExecuteReader();

            if (database.SqlReader.HasRows)
            {
                int id, qty;
                string name, author, desc, added;

                while (database.SqlReader.Read())
                {
                    id = database.SqlReader.GetInt32((int)Book_Data.ID);
                    qty = database.SqlReader.GetInt32((int)Book_Data.QTY);

                    name = database.SqlReader.GetString((int)Book_Data.NAME);
                    author = database.SqlReader.GetString((int)Book_Data.AUTHOR);
                    desc = database.SqlReader.GetString((int)Book_Data.DESC);
                    added = database.SqlReader.GetString((int)Book_Data.ADDEDTIME);

                    books.Add(new Book(id, qty, name, author, desc, added));
                }
            }

            database.SqlReader.Close();
        }
        public void LoadSingleBook(string bookName)
        {
            database.SqlQuery = new MySqlCommand("select * from books where Name='" + bookName + "'", database.Conn);
            database.SqlReader = database.SqlQuery.ExecuteReader();

            if (database.SqlReader.Read())
            { 
                int id = database.SqlReader.GetInt32((int)Book_Data.ID);
                int qty = database.SqlReader.GetInt32((int)Book_Data.QTY);

                string author = database.SqlReader.GetString((int)Book_Data.AUTHOR);
                string desc = database.SqlReader.GetString((int)Book_Data.DESC);
                string added = database.SqlReader.GetString((int)Book_Data.ADDEDTIME);

                books.Add(new Book(id, qty, bookName, author, desc, added));
            }

            database.SqlReader.Close();
        }

        public void AddBook(Book bookObject)
        {
            this.books.Add(bookObject);
        }
    }
}
