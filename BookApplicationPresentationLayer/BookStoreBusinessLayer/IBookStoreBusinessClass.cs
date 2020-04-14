using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusinessLayer
{
    
        public interface IBookStoreBusinessClass
        {
            void InsertBookData(BookMenu newBook);

            List<BookMenu> BookDetails();

        
    }
}
