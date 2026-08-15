namespace BookStoreAPI.Models
{
    public class Review
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Guid BookId { get; set; }
        public Book Book { get; set; }
        //[JsonIgnore]
        //public List<Book> Books { get; set; } = new();

    }
}
