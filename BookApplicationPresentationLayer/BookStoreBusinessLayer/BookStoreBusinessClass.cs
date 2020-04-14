using BookStoreDataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusinessLayer
{
    public class BookStoreBusinessClass : IBookStoreBusinessClass
    {
        IBookStoreDataAccessClass _BookDataAccess = new BookStoreDataAccessClass();
        public void InsertBookData(BookMenu newBook)
        {
            _BookDataAccess.Insert(newBook);
        }
        public List<BookMenu> BookDetails()
        {
            List<BookMenu> bList = _BookDataAccess.Display();
            return bList;
        }
    }
    }
