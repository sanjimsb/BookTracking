using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Book_Tracking_Models;
using Book_Tracking_Context;

namespace Book_Tracking.Pages
{
    public class AddBookModel : PageModel
    {
        private readonly BookContext _db;

        [FromForm]
        public Books Book { get; set; }

        public ICollection<BookCategories> BookCategories { get; set; }

        public AddBookModel(BookContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            if (_db.BookCategories.Count() > 0)
            {
                ViewData["hasCat"] = true;
            }
            if (_db.CategoryTypes.Count() > 0)
            {
                ViewData["hasCatType"] = true;
            }
            BookCategories = _db.BookCategories.Select(cat => cat).ToList();
        }

        public async void OnPost()
        {
            BookCategories = _db.BookCategories.Select(cat => cat).ToList();
            _db.Add<Books>(Book);
            await _db.SaveChangesAsync();
        }
    }
}
