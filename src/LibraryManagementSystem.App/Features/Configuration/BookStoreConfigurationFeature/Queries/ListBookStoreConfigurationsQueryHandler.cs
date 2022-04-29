using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.Configuration.BookStoreConfigurationFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;
using BookStoreManagementSystem.App.Infrastructure.Data;

namespace BookStoreManagementSystem.App.Features.Configuration.BookStoreConfigurationFeature.Queries
{
    public class ListBookStoreConfigurationsQueryHandler : IListQueryHandler<ListBookStoreConfigurationsQuery, BookStoreConfigurationDto>
    {
        private readonly BookStoreContext _context;

        public ListBookStoreConfigurationsQueryHandler(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<IPagedList<BookStoreConfigurationDto>> Handle(ListBookStoreConfigurationsQuery request, CancellationToken cancellationToken)
        {
            var bookStoreConfiguration = _context.BookStoreConfigurations
                .AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Select(x => new BookStoreConfigurationDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    MaximumStock = x.MaximumStock,
                    MinimumStock = x.MinimumStock,
                    MinimumBookImport = x.MinimumBookImport,
                });

            var response = await bookStoreConfiguration.ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
            return response;
        }
    }
}