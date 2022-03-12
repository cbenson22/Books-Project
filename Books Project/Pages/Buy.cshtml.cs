using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books_Project.Infrastructure;
using Books_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Books_Project.Pages
{
    public class BuyModel : PageModel
    {
        private IBooksRepository repo { get; set; }
        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }
        public BuyModel(IBooksRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }
        
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
           
        }
        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);
           
            basket.AddItem(b, 1);


            

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(int bookid, string returnUrl)
        {
            basket.RemoveItem(basket.Items.First(x => x.Book.BookId == bookid).Book);
            return RedirectToPage( new {ReturnUrl = returnUrl});
        }
    }
}
