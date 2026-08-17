namespace BookStoreAPI.DTOs
{
    public class AuthorGetDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
