using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_Project.Models
{
    public class EFBookRepository : IBooksRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
