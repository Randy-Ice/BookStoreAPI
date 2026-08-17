namespace BookStoreAPI.DTOs
{
    public class BookReviewDTO
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Guid BookId { get; set; }


    }
}
