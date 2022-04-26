using BookStoreManagementSystem.App.Domain;
using BookStoreManagementSystem.App.Infrastructure;
using MediatR;

namespace BookStoreManagementSystem.App.Features.BookFeature.Commands
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, bool>
    {
        private readonly BookStoreContext _context;

        public CreateBookCommandHandler(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var newBookCode = "";
            var newBook = new Book(request.Request.Name,
                newBookCode,
                request.Request.TypeId,
                request.Request.AuthorId,
                request.Request.Price);

            _context.Add(newBook);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}