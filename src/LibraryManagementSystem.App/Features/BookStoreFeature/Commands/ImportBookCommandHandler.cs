using BookStoreManagementSystem.App.Domain;
using BookStoreManagementSystem.App.Infrastructure;
using MediatR;

namespace BookStoreManagementSystem.App.Features.BookStoreFeature.Commands
{
    public class ImportBookCommandHandler : IRequestHandler<ImportBookCommand, bool>
    {
        private readonly BookStoreContext _context;

        public ImportBookCommandHandler(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(ImportBookCommand request, CancellationToken cancellationToken)
        {
            var bookStoreStorage = await _context.BookStoresStorage
                .Where(x => x.BookId == request.Request.BookId && x.BookStoreId == request.BookStoreId)
                .FirstOrDefaultAsync(cancellationToken);

            if (bookStoreStorage == null)
            {
                var newBookStoreStorage = new BookStoreStorage(request.Request.BookId, request.BookStoreId, request.Request.Quantity);
                _context.Add(newBookStoreStorage);
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }
            bookStoreStorage.Import(request.Request.Quantity);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}