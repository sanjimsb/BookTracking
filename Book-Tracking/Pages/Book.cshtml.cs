using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_Tracking_Context;
using Book_Tracking_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Book_Tracking.Pages
{
    public class BookModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BookContext _db;

        public Books Book { get; set; }

        public BookModel(ILogger<IndexModel> logger, BookContext db)
        {
            _logger = logger;
            _db = db;

            _logger.LogInformation("lajsdlfjasdjf");
        }

        public void OnGet([FromQuery] int Id)
        {
            Book = _db.Books.Where(bk => bk.Id == Id).FirstOrDefault();
        }
    }
}
