using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Tracking_Models
{
    public class CategoryTypes
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        public string Name { get; set; }
    }
}
