using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.ReportFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;

namespace BookStoreManagementSystem.App.Features.ReportFeature.Queries
{
    public class CustomerDebtReportQueryHandler : IListQueryHandler<CustomerDebtReportQuery, DebtReportDto>
    {
        private readonly BookStoreContext _context;

        public CustomerDebtReportQueryHandler(BookStoreContext context)
        {
            _context = context;
        }

        public Task<IPagedList<DebtReportDto>> Handle(CustomerDebtReportQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}