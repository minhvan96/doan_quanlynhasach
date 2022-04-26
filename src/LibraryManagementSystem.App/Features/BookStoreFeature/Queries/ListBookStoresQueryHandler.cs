using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.BookStoreFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;
using BookStoreManagementSystem.App.Infrastructure.Data;

namespace BookStoreManagementSystem.App.Features.BookStoreFeature.Queries
{
    public class ListBookStoresQueryHandler : IListQueryHandler<ListBookStoresQuery, BookStoreDto>
    {
        private readonly BookStoreContext _context;

        public ListBookStoresQueryHandler(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<IPagedList<BookStoreDto>> Handle(ListBookStoresQuery request, CancellationToken cancellationToken)
        {
            var bookStores = _context.BookStores
                .Where(x => !x.IsDeleted)
                .Select(x => new BookStoreDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Address = x.Address,
                });

            var response = await bookStores.ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
            return response;
        }
    }
}