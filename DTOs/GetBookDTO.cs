namespace BookStoreAPI.DTOs
{
    public class GetBookDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? CoverImage { get; set; }
        public short NumberOfPages { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        //one to one
        public BookNoteDTO? Note { get; set; }

        //one to many
        public Guid AuthorId { get; set; }
        public BookAuthorDTO Author { get; set; }

        public Guid CategoryId { get; set; }
        public BookCategoryDTO Category { get; set; }

        //many to many
        public List<BookFormatDTO> Formats { get; set; } = new();
        public List<BookReviewDTO> Reviews { get; set; } = new();
        public List<BookTagDTO> Tags { get; set; } = new();
    }
}
