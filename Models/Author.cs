using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Author
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Book> Books { get; set; } = new();


    }
}
