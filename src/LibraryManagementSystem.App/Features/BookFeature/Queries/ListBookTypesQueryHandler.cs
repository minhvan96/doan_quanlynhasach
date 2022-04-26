using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.BookFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;
using BookStoreManagementSystem.App.Infrastructure.Data;

namespace BookStoreManagementSystem.App.Features.BookFeature.Queries
{
    public class ListBookTypesQueryHandler : IListQueryHandler<ListBookTypesQuery, BookTypeDto>
    {
        private readonly BookStoreContext _context;

        public ListBookTypesQueryHandler(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<IPagedList<BookTypeDto>> Handle(ListBookTypesQuery request, CancellationToken cancellationToken)
        {
            var bookTypes = _context.BookTypes
                .Select(x => new BookTypeDto
                {
                    Id = x.Id,
                    Name = x.Name,
                });
            return await bookTypes.ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
        }
    }
}