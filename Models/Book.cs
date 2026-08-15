namespace BookStoreAPI.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? CoverImage { get; set; }
        public short NumberOfPages { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        //one to one
        public Note? Note { get; set; }

        //one to many
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        //many to many
        public List<Format> Formats { get; set; } = new();
        public List<Review> Reviews { get; set; } = new();
        public List<Tag> Tags { get; set; } = new();





    }
}
