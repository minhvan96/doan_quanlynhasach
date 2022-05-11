using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Features.BookStoreFeature.Dtos;
using MediatR;

namespace BookStoreManagementSystem.App.Features.BookStoreFeature.Queries
{
    public class InventoryReportQuery : ListQuery<InventoryReportDto>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}