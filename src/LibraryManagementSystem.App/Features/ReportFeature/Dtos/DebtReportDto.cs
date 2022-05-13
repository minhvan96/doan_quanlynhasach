namespace BookStoreManagementSystem.App.Features.ReportFeature.Dtos
{
    public class DebtReportDto
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public decimal OpeningDebt { get; set; }
        public decimal EndingDebt { get; set; }
    }
}