namespace BookStoreAPI.DTOs
{
    public class GetAuthorDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
