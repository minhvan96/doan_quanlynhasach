using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.BookStoreFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;

namespace BookStoreManagementSystem.App.Features.BookStoreFeature.Queries
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
            var inventory = _context.BookStoresStorage
                .Where(x => x.imp)
        }
    }
}