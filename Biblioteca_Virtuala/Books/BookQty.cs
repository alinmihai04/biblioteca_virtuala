using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Virtuala
{
    public class BookQty : BookEdit
    {
        public override bool input(string value)
        {
            if (value.Equals("editQty"))
            {
                return true;
            }
            return false;
        }

        public override void edit(DB database, Book bookObject, string newText)
        {
            if(!int.TryParse(newText, out int quantity))
            {
                Console.WriteLine("Invalid input in BookQty.edit");
            }
            else
            {
                database.SqlQuery = new MySql.Data.MySqlClient.MySqlCommand("update books set qty='" + quantity + "' where id='" + bookObject.BookID + "'", database.Conn);
                database.SqlQuery.ExecuteNonQuery();

                bookObject.UpdateInfo("qty", newText);
            }


        }
    }
}
