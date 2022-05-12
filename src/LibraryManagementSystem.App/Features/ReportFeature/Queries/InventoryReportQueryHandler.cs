using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.ReportFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;

namespace BookStoreManagementSystem.App.Features.ReportFeature.Queries
{
    public class InventoryReportQueryHandler : IListQueryHandler<InventoryReportQuery, InventoryReportDto>
    {
        private readonly BookStoreContext _context;

        public InventoryReportQueryHandler(BookStoreContext context)
        {
            _context = context;
        }

        public Task<IPagedList<InventoryReportDto>> Handle(InventoryReportQuery request, CancellationToken cancellationToken)
        {
            var report = from bss in _context.BookStoresStorage
                         join bsh in _context.InventoryHistory on bss.BookStoreId equals bsh.BookStoreId into xxx
                         select new InventoryReportDto
                         {
                             EndingStocks = xxx.Sum(x => x.ChangeNumber),
                             BookId = bss.BookId,
                             BookName = bss.Book.Name,
                             OpeningStocks = bss.Availability
                         };
            return null;
        }
    }
}