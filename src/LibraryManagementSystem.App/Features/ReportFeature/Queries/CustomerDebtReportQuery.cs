using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Features.ReportFeature.Dtos;

namespace BookStoreManagementSystem.App.Features.ReportFeature.Queries
{
    public class CustomerDebtReportQuery : ListQuery<DebtReportDto>
    {
        public Guid CustomerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}