using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Virtuala
{
    public class Book
    {
        protected int bookID = 9999, bookQty = 0;
        protected string bookName = "book error", bookAuthor = "book error", bookDesc = "book error", bookAddedTime = "book error";

        public string BookName
        {
            get { return bookName; }
        }
        public int BookID
        {
            get { return bookID; }
        }

        private const int infoArraySize = 5;

        public Book() { }
        public Book(int bookID, int bookQty, string bookName, string bookAuthor, string bookDesc, string bookAddedTime)
        {
            this.bookID = bookID;
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookDesc = bookDesc;
            this.bookQty = bookQty;
            this.bookAddedTime = bookAddedTime;
        }

        public string[] BookListInfo()
        {
            string[] infoArray = new string[infoArraySize];

            infoArray[0] = this.bookID + "";
            infoArray[1] = this.bookName;
            infoArray[2] = this.bookAuthor;
            infoArray[3] = this.bookQty + "";

            return infoArray;
        }
        public string[] BookFullInfo()
        {
            string[] infoArray = new string[infoArraySize];

            infoArray[0] = this.bookName;
            infoArray[1] = this.bookAuthor;
            infoArray[2] = this.bookDesc;
            infoArray[3] = this.bookQty + "";
            infoArray[4] = this.bookAddedTime;

            return infoArray;
        }
        public void UpdateInfo(string info, string value)
        {
            switch(info)
            {
                case "name":
                    this.bookName = value;
                    break;
                case "author":
                    this.bookAuthor = value;
                    break;
                case "desc":
                    this.bookDesc = value;
                    break;
                case "qty":
                    if(!int.TryParse(value, out int quantity))
                    {
                        break;
                    }
                    else
                    {
                        this.bookQty = Convert.ToInt32(quantity);
                    }      
                    break;
            }
        }
    }
}
