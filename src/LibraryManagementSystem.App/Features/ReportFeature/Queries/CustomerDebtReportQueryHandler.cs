using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.ReportFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;
using BookStoreManagementSystem.App.Infrastructure.Data;

namespace BookStoreManagementSystem.App.Features.ReportFeature.Queries
{
    public class CustomerDebtReportQueryHandler : IListQueryHandler<CustomerDebtReportQuery, DebtReportDto>
    {
        private readonly BookStoreContext _context;

        public CustomerDebtReportQueryHandler(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<IPagedList<DebtReportDto>> Handle(CustomerDebtReportQuery request, CancellationToken cancellationToken)
        {
            var customerDebts = _context.CustomerDebts
                .AsNoTracking()
                .OrderBy(x => x.CreatedDate);

            var report = customerDebts.GroupBy(x => x.CustomerId)
                .Select(x => new DebtReportDto
                {
                    CustomerId = x.Key,
                    OpeningDebt = x.Sum(x => x.Debt) - x.Where(y => y.CreatedDate.Date > request.StartDate.Date).Sum(x => x.Debt),
                    EndingDebt = x.Where(x => x.CreatedDate < request.EndDate).Sum(x => x.Debt),
                });

            return report.ToPagedList(1, 1000);
        }
    }
}