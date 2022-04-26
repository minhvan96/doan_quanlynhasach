using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.BookStoreFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;
using BookStoreManagementSystem.App.Infrastructure.Data;

namespace BookStoreManagementSystem.App.Features.BookStoreFeature.Queries
{
    public class GetBookStoreStorageQueryHandler : IListQueryHandler<GetBookStoreStorageQuery, BookStoreStorageDto>
    {
        private readonly BookStoreContext _context;

        public GetBookStoreStorageQueryHandler(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<IPagedList<BookStoreStorageDto>> Handle(GetBookStoreStorageQuery request, CancellationToken cancellationToken)
        {
            var bookStoreStorage = _context.BookStoresStorage
                .AsNoTracking()
                .Include(x => x.Book).ThenInclude(x => x.Type)
                .Where(x => x.BookStoreId == request.BookStoreId)
                .Select(x => new BookStoreStorageDto
                {
                    BookId = x.BookId,
                    BookCode = x.Book.Code,
                    BookName = x.Book.Name,
                    BookTypeId = x.Book.TypeId,
                    BookTypeName = x.Book.Type.Name,
                    Availability = x.Availability
                });

            var response = await bookStoreStorage.ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
            return response;
        }
    }
}