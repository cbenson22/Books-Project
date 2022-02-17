using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_Project.Models
{
    public interface IBooksRepository
    {
        IQueryable<Book> Books { get; }
    }
}
