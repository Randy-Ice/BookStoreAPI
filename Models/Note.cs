namespace BookStoreAPI.Models
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
    }
}
