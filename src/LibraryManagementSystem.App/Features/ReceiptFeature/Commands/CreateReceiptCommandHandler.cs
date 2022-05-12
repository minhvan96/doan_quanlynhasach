using BookStoreManagementSystem.App.Domain;
using BookStoreManagementSystem.App.Infrastructure;
using MediatR;

namespace BookStoreManagementSystem.App.Features.ReceiptFeature.Commands
{
    public class CreateReceiptCommandHandler : IRequestHandler<CreateReceiptCommand, CreateReceiptStatus>
    {
        private readonly BookStoreContext _context;

        public CreateReceiptCommandHandler(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<CreateReceiptStatus> Handle(CreateReceiptCommand request, CancellationToken cancellationToken)
        {
            var staff = await _context.Staffs.FirstOrDefaultAsync(x => x.UserId == request.Request.StaffId, cancellationToken);
            var newReceipt = new Receipt(staff.Id,
                request.Request.CustomerId,
                request.Request.CustomerName,
                request.Request.CustomerPhoneNumber,
                request.Request.CustomerEmail,
                request.Request.CustomerAddress,
                DateTimeOffset.UtcNow,
                request.Request.TotalPrice,
                request.Request.ReceivedMoney,
                request.Request.Debt);

            _context.Add(newReceipt);

            foreach (var book in request.Request.Books)
            {
                var bookSold = new BookSellHistory(DateTime.Today, staff.Id, book.Id, staff.BookStoreId, book.SoldNumber);
            }
            await _context.SaveChangesAsync(cancellationToken);
            return CreateReceiptStatus.Success;
        }
    }
}