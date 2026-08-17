namespace BookStoreAPI.DTOs
{
    public class BookNoteDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid BookId { get; set; }

    }
}
