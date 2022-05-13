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
            var customerConfiguration = await _context.CustomerConfigurations.FirstOrDefaultAsync(x => x.IsDefault, cancellationToken);
            if (request.Request.TotalPrice - request.Request.ReceivedMoney > customerConfiguration?.MaximumDebt)
            {
                return CreateReceiptStatus.DebtExceeded;
            }
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
            if (request.Request.TotalPrice - request.Request.ReceivedMoney > 0)
            {
                var newCustomerDebt = new CustomerDebt(request.Request.CustomerId, request.Request.TotalPrice - request.Request.ReceivedMoney);
                _context.Add(newCustomerDebt);
            }
            var bookSolds = new List<InventoryHistory>();
            foreach (var book in request.Request.Books)
            {
                if (!bookSolds.Any(x => x.BookId == book.Id))
                {
                    var soldNumber = request.Request.Books.Where(x => x.Id == book.Id).Count();
                    var bookSold = new InventoryHistory(DateTime.Today, staff.Id, book.Id, staff.BookStoreId, -soldNumber);
                    bookSolds.Add(bookSold);
                }
            }

            _context.AddRange(bookSolds);
            await _context.SaveChangesAsync(cancellationToken);
            return CreateReceiptStatus.Success;
        }
    }
}