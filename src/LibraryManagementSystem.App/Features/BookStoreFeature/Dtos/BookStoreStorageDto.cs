namespace BookStoreManagementSystem.App.Features.BookStoreFeature.Dtos
{
    public class BookStoreStorageDto
    {
        public Guid BookId { get; set; }
        public string BookCode { get; set; } = string.Empty;
        public string BookTypeName { get; set; } = string.Empty;
        public Guid BookTypeId { get; set; }
        public string BookName { get; set; } = string.Empty;
        public int Availability { get; set; }
    }
}