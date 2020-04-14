using BookStoreBusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookApplicationPresentationLayer.Models
{
    public class ModelManager
    {
        IBookStoreBusinessClass _BookStoreBusiness = new BookStoreBusinessClass();
        public void InsertData(BookMenuModel bmodel)
        {
            BookMenu b = new BookMenu();

            bmodel.BookTitle = b.BookTitle;
            b.Author = bmodel.Author;
            b.Category = bmodel.Category;
            b.Location = bmodel.Location;
            b.Price = bmodel.Price;
            b.Tags = bmodel.Tags;


            _BookStoreBusiness.InsertBookData(b);
        }
        public List<BookMenuModel> BookData()
        {
            BookMenu j1 = new BookMenu();
            List<BookMenu> bookstore = _BookStoreBusiness.BookDetails();
            List<BookMenuModel> modelmenu = new List<BookMenuModel>();
            foreach (BookMenu book in bookstore)
            {
                BookMenuModel b = new BookMenuModel();
       
                b.BookTitle = book.BookTitle;
                b.Author = book.Author;
                b.Category = book.Category;
                b.Location = book.Location;
                b.Price = book.Price;
                b.Tags = book.Tags;
                modelmenu.Add(b);
            }
            return modelmenu;
        }
        public void DeleteData(BookMenuModel bmodel)
        {
            BookMenu b = new BookMenu();
            b.BookTitle = bmodel.BookTitle;
            b.Author = bmodel.Author;
            b.Category = bmodel.Category;
            b.Location = bmodel.Location;
            b.Price = bmodel.Price;
            b.Tags = bmodel.Tags;

            _BookStoreBusiness.InsertBookData(b);
        }

        public List<BookMenuModel> DeletedData()
        {
            BookMenu j1 = new BookMenu();
            List<BookMenu> bookStore = _BookStoreBusiness.BookDetails();
            List<BookMenuModel> modelmenu = new List<BookMenuModel>();
            foreach (BookMenu book in bookStore)
            {
                BookMenuModel b = new BookMenuModel();
                b.BookTitle = book.BookTitle;
                b.Author = book.Author;
                b.Category = book.Category;
                b.Location = book.Location;
                b.Price = book.Price;
                b.Tags = book.Tags;


                modelmenu.Add(b);
            }
            return modelmenu;
        }
    }
}