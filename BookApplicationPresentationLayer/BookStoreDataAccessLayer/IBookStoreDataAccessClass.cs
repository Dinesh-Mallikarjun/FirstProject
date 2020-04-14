using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDataAccessLayer
{
    
        public interface IBookStoreDataAccessClass
        {
            void Insert(BookMenu newBook);
            List<BookMenu> Display();
        }
    
}
