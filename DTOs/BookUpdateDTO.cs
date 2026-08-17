using BookStoreAPI.Models;

namespace BookStoreAPI.DTOs
{
    public class BookUpdateDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? CoverImage { get; set; }
        public short NumberOfPages { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        //one to one


        //one to many
        public Guid AuthorId { get; set; }


        public Guid CategoryId { get; set; }


        //many to many
        public List<Format> Formats { get; set; } = new();

        public List<Tag> Tags { get; set; } = new();
    }
}
