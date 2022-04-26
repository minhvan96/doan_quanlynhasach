using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Features.BookFeature.Dtos;

namespace BookStoreManagementSystem.App.Features.BookFeature.Queries
{
    public class ListBooksQuery : ListQuery<BookDto>
    {
        public string? BookName { get; set; }
        public string? AuthorName { get; set; }
        public QueryBookPriceRange Price { get; set; }
        public string? BookCode { get; set; }
        public Guid BookType { get; set; }
    }

    public enum QueryBookPriceRange
    {
        None,
        LessThan50K,
        From50kTo100K,
        From100kTo500K,
        From500kTo1M,
        GreaterThan1M,
        All
    }
}