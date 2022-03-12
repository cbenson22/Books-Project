using Books_Project.Models;
using Books_Project.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_Project.Controllers
{
    public class HomeController : Controller
    {
        private IBooksRepository repo;

        public HomeController (IBooksRepository temp)
        {
            repo = temp;
        }
        public IActionResult Index(string categoryType, int pageNum = 1)
        {
            int pageSize = 10;

            var x = new BooksViewModel
            {
                Books = repo.Books
                .Where(c => c.Category == categoryType || categoryType == null )
                .OrderBy(c => c.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = (categoryType == null
                        ? repo.Books.Count()
                        : repo.Books.Where(x=> x.Category == categoryType).Count()),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };
            

            return View(x);
        }
        
    }
}
