using System.Text.Json.Serialization;

namespace BookStoreAPI.Models
{
    public class Review
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        [JsonIgnore]
        public List<Book> Books { get; set; } = new();

    }
}
