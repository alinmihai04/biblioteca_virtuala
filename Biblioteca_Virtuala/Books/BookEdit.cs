using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Virtuala
{
    public abstract class BookEdit
    {
        public abstract bool input(string value);

        public abstract void edit(DB database, Book bookObject, string newText);
    }
}
