using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Tracking_Models
{
    public class BookCategories
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [ForeignKey("CategoryTypes")]
        public int CategoryTypesId { get; set; }

        [Required]
        public string NameToken { get; set; }

        public string Description { get; set; }
    }
}
