using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Features.AuthorFeature.Dtos;

namespace BookStoreManagementSystem.App.Features.AuthorFeature.Queries
{
    public class ListAuthorsQuery : ListQuery<AuthorDto>
    {
        public string? Name { get; set; }
    }
}