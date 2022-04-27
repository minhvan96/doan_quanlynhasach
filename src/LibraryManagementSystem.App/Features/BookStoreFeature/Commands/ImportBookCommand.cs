using MediatR;

namespace BookStoreManagementSystem.App.Features.BookStoreFeature.Commands
{
    public class ImportBookCommand : IRequest<bool>
    {
        public Guid BookStoreId { get; set; }
        public ImportBookRequest Request { get; set; } = new ImportBookRequest();
    }

    public class ImportBookRequest
    {
        public Guid BookId { get; set; }
        public int Quantity { get; set; }
    }
}