using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Book_Tracking_Models;
using Book_Tracking_Context;

namespace Book_Tracking.Pages
{
    public class AddBookCategoryModel : PageModel
    {
        private readonly ILogger<AddBookCategoryModel> _logger;
        private readonly BookContext _db;

        [FromForm]
        public BookCategories BookCategory { get; set; }

        public ICollection<CategoryTypes> BookCatTypes { get; set; }


        public AddBookCategoryModel(ILogger<AddBookCategoryModel> logger, BookContext db)
        {
            _logger = logger;
            _db = db;

            _logger.LogInformation("lajsdlfjasdjf");
        }

        public void OnGet()
        {
            BookCatTypes = _db.CategoryTypes.Select(ct => ct).ToList();
        }

        public void OnPost()
        {
            BookCatTypes = _db.CategoryTypes.Select(ct => ct).ToList();
            _db.Add<BookCategories>(BookCategory);
            _db.SaveChangesAsync();
        }
    }
}