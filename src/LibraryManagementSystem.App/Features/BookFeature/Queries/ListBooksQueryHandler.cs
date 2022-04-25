using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.BookFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;
using BookStoreManagementSystem.App.Infrastructure.Data;
using MediatR;

namespace BookStoreManagementSystem.App.Features.BookFeature.Queries
{
    public class ListBooksQueryHandler : IListQueryHandler<ListBooksQuery, BookDto>
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public ListBooksQueryHandler(BookStoreContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IPagedList<BookDto>> Handle(ListBooksQuery request, CancellationToken cancellationToken)
        {
            var books = _context.Books
                .AsNoTracking()
                .Where(x => !x.IsDeleted);

            var bookDto = books.ProjectTo<BookDto>(_mapper.ConfigurationProvider);
            var response = await bookDto.ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
            return response;
        }
    }
}