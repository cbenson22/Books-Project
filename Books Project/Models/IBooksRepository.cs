﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_Project.Models
{
    public interface IBooksRepository
    {
        IQueryable<Book> Books { get; }
        //public void SaveBook(Book b);
        //public void CreateBook(Book b);
        //public void DeleteBook(Book b);

    }
}
