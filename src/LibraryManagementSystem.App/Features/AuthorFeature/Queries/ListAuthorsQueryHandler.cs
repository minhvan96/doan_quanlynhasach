using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.AuthorFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;
using BookStoreManagementSystem.App.Infrastructure.Data;

namespace BookStoreManagementSystem.App.Features.AuthorFeature.Queries
{
    internal class ListAuthorsQueryHandler : IListQueryHandler<ListAuthorsQuery, AuthorDto>
    {
        private readonly BookStoreContext _context;

        public ListAuthorsQueryHandler(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<IPagedList<AuthorDto>> Handle(ListAuthorsQuery request, CancellationToken cancellationToken)
        {
            var authors = _context.Authors
                .Where(x => !x.IsDeleted)
                .Select(x => new AuthorDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).OrderBy(x => x.Name);

            var response = await authors.ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
            return response;
        }
    }
}