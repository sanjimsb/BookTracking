using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Book_Tracking_Context;
using Book_Tracking_Models;

namespace Book_Tracking.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BookContext _db;

        public ICollection<Books> Books { get; set; }

        public Books BooksModel { get; set; }

        public IndexModel(ILogger<IndexModel> logger, BookContext db)
        {
            _logger = logger;
            _db = db;
            BooksModel = new Books() { Title ="test", Author = "Bipin" };

            _logger.LogInformation("lajsdlfjasdjf");
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
            Books = _db.Books.Select(books => books).ToList();
        }
    }
}
