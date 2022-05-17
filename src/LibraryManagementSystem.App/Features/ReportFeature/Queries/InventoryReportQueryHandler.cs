using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.ReportFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;
using BookStoreManagementSystem.App.Infrastructure.Data;

namespace BookStoreManagementSystem.App.Features.ReportFeature.Queries
{
    public class InventoryReportQueryHandler : IListQueryHandler<InventoryReportQuery, InventoryReportDto>
    {
        private readonly BookStoreContext _context;

        public InventoryReportQueryHandler(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<IPagedList<InventoryReportDto>> Handle(InventoryReportQuery request, CancellationToken cancellationToken)
        {
            var bookStoreStorages = await _context.BookStoresStorage
                .AsNoTracking()
                .Include(x => x.Book)
                .Where(x => x.BookStoreId == new Guid("0F427D88-47A9-4ED0-868C-5C01477CFB96"))
                .ToListAsync(cancellationToken);
            var inventoryFromStartToNow = await _context.InventoryHistory
                .AsNoTracking()
                .Where(x => x.Date.Date >= request.StartDate.Date)
                .OrderBy(x => x.Date)
                .ToListAsync(cancellationToken);
            var inventoryFromStartToEndDate = inventoryFromStartToNow
                .Where(x => x.Date.Date >= request.StartDate.Date && x.Date.Date <= request.EndDate.Date)
                .OrderBy(x => x.Date)
                .ToList();
            if (inventoryFromStartToEndDate.Count == 0)
            {
                return new PagedList<InventoryReportDto>();
            }

            var inventoryReports = new List<InventoryReportDto>();
            foreach (var bss in bookStoreStorages)
            {
                if (!inventoryFromStartToEndDate.Any(x => x.BookId == bss.BookId))
                    continue;
                var minDifferentStartDate = inventoryFromStartToEndDate.Where(x => x.BookId == bss.BookId)?.Min(x => x.Date - request.StartDate);
                var minDifferentEndDate = inventoryFromStartToEndDate.Where(x => x.BookId == bss.BookId)?.Min(x => request.EndDate - x.Date);

                var startDate = inventoryFromStartToNow.FirstOrDefault(x => x.BookId == bss.BookId && x.Date - request.StartDate == minDifferentStartDate)?.Date;
                var startDateInventory = inventoryFromStartToNow.Where(x => x.BookId == bss.BookId && x.Date >= startDate);
                var startDateNumber = startDateInventory.Sum(x => x.ChangeNumber);

                var endDate = inventoryFromStartToEndDate.FirstOrDefault(x => x.BookId == bss.BookId && request.EndDate - x.Date == minDifferentEndDate)?.Date;
                var endDateInventory = inventoryFromStartToEndDate.FirstOrDefault(x => x.BookId == bss.BookId && request.EndDate.Date == x.Date);
                var endDateInventory1 = inventoryFromStartToEndDate.FirstOrDefault(x => x.BookId == bss.BookId && request.EndDate.Date < x.Date);
                var endDateNumber = endDateInventory == null ? 0 : inventoryFromStartToEndDate.Where(x => x.BookId == bss.BookId && x.Date > endDateInventory.Date)?.Sum(x => x.ChangeNumber);

                var inventoryReport = new InventoryReportDto
                {
                    BookId = bss.BookId,
                    BookName = bss.Book.Name,
                    OpeningStocks = bss.Availability - startDateNumber,
                    EndingStocks = bss.Availability - endDateNumber == null ? 0 : bss.Availability,
                };
                inventoryReports.Add(inventoryReport);
            }

            return inventoryReports.ToPagedList(1, 1000);
        }
    }
}