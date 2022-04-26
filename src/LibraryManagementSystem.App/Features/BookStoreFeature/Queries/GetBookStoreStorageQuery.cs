using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Features.BookStoreFeature.Dtos;

namespace BookStoreManagementSystem.App.Features.BookStoreFeature.Queries
{
    public class GetBookStoreStorageQuery : ListQuery<BookStoreStorageDto>
    {
        public Guid BookStoreId { get; set; }
    }
}