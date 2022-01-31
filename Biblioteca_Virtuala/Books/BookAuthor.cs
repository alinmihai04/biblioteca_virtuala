using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Virtuala
{
    public class BookAuthor : BookEdit
    {
        public override bool input(string value)
        {
            if (value.Equals("editAuthor"))
            {
                return true;
            }
            return false;
        }

        public override void edit(DB database, Book bookObject, string newText)
        {
            database.SqlQuery = new MySql.Data.MySqlClient.MySqlCommand("update books set author='" + newText + "' where id='" + bookObject.BookID + "'", database.Conn);
            database.SqlQuery.ExecuteNonQuery();

            bookObject.UpdateInfo("author", newText);
        }
    }
}
