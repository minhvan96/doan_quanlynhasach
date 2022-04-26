using MediatR;

namespace BookStoreManagementSystem.App.Features.BookFeature.Commands
{
    public class CreateBookCommand : IRequest<bool>
    {
        public CreateBookRequest Request { get; set; } = new CreateBookRequest();
    }

    public class CreateBookRequest
    {
        public string Name { get; set; } = string.Empty;
        public Guid TypeId { get; set; }
        public Guid AuthorId { get; set; }
        public decimal Price { get; set; }
    }
}