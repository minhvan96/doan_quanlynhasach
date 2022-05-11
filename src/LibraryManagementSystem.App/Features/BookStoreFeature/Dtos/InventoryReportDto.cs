namespace BookStoreManagementSystem.App.Features.BookStoreFeature.Dtos
{
    public class InventoryReportDto
    {
        public Guid BookId { get; set; }
        public string BookName { get; set; } = string.Empty;
        public int EndingStocks { get; set; }
        public int OpeningStocks { get; set; }
    }
}