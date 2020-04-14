using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementEntityLayer
{
    public class Book
    {
        private int _bookId;
        private string _bookName;
        private string _bookAuthor;

        public int BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }
        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }
        public string BookAuthor
        {
            get { return _bookAuthor; }
            set { _bookAuthor = value; }
        }

    }
}
