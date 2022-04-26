using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Domain;
using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.BookFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;
using BookStoreManagementSystem.App.Infrastructure.Data;

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

            books = Filter(books, request);

            var bookDto = books.ProjectTo<BookDto>(_mapper.ConfigurationProvider);
            var response = await bookDto.ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
            return response;
        }

        private static IQueryable<Book> Filter(IQueryable<Book> books, ListBooksQuery request)
        {
            if (!string.IsNullOrWhiteSpace(request.BookName))
            {
                books = books.Where(x => x.Name.Contains(request.BookName));
            }
            if (!string.IsNullOrWhiteSpace(request.BookCode))
            {
                books = books.Where(x => x.Code.Contains(request.BookCode));
            }
            if (!string.IsNullOrWhiteSpace(request.AuthorName))
            {
                books = books.Include(x => x.Author)
                    .Where(x => x.Author.Name.Contains(request.AuthorName));
            }
            books = FilterPrice(books, request);
            return books;
        }

        private static IQueryable<Book> FilterPrice(IQueryable<Book> books, ListBooksQuery request)
        {
            switch (request.Price)
            {
                case QueryBookPriceRange.LessThan50K:
                    books = books.Where(x => x.Price < 50000);
                    break;

                case QueryBookPriceRange.From50kTo100K:
                    books = books.Where(x => x.Price >= 50000 && x.Price < 100000);
                    break;

                case QueryBookPriceRange.From100kTo500K:
                    books = books.Where(x => x.Price >= 100000 && x.Price < 500000);
                    break;

                case QueryBookPriceRange.From500kTo1M:
                    books = books.Where(x => x.Price >= 500000 && x.Price < 1000000);
                    break;

                case QueryBookPriceRange.GreaterThan1M:
                    books = books.Where(x => x.Price >= 1000000);
                    break;
            }

            return books;
        }
    }
}