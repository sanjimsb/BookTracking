using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Tracking_Models
{
    public class Books
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [ForeignKey("BookCategories")]
        public int BookCategoriesId { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Title { get; set; }

        public string Author { get; set; }
    }
}
