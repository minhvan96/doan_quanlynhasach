namespace BookStoreManagementSystem.App.Features.BookFeature.Dtos
{
    public class BookDto
    {
        public string? TypeName { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? AuthorName { get; set; }
        public decimal Price { get; set; }
    }
}