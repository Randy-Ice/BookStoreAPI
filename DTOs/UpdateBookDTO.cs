namespace BookStoreAPI.DTOs
{
    public class UpdateBookDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? CoverImage { get; set; }
        public short NumberOfPages { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }


    }
}
