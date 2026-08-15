using BookStoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.Data
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Format> Formats { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
