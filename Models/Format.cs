using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Format
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new();


    }
}
