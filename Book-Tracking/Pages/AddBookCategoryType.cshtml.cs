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
    public class AddBookCategoryTypeModel : PageModel
    {
        private readonly BookContext _db;

        [FromForm]
        public CategoryTypes categoryType { get; set; }

        public AddBookCategoryTypeModel(BookContext db)
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
        }

        public void OnPost()
        {
            _db.Add<CategoryTypes>(categoryType);
            _db.SaveChangesAsync();
        }
    }
}
