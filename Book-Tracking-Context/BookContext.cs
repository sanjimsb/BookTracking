using Microsoft.EntityFrameworkCore;
using System;
using Book_Tracking_Models;

namespace Book_Tracking_Context
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
        : base(options)
        { }

        public DbSet<Books> Books { get; set; }
        public DbSet<BookCategories> BookCategories { get; set; }
        public DbSet<CategoryTypes> CategoryTypes { get; set; }
    }
}
