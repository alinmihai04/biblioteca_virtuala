using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Virtuala
{
    public class BookName : BookEdit
    {
        public override bool input(string value)
        {
            if (value.Equals("editName"))
            {
                return true;
            }
            return false;
        }

        public override void edit(DB database, Book bookObject, string newText)
        {
            database.SqlQuery = new MySql.Data.MySqlClient.MySqlCommand("update books set name='" + newText + "' where id='" + bookObject.BookID + "'", database.Conn);
            database.SqlQuery.ExecuteNonQuery();

            bookObject.UpdateInfo("name", newText);
        }
    }
}
