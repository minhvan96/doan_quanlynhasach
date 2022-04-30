﻿using BookStoreManagementSystem.App.Domain;
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
            var newReceipt = new Receipt(request.Request.CustomerId,
                request.Request.CustomerName,
                request.Request.CustomerPhoneNumber,
                request.Request.CustomerEmail,
                request.Request.CustomerAddress,
                DateTimeOffset.UtcNow,
                request.Request.TotalPrice,
                request.Request.ReceivedMoney,
                request.Request.Debt);

            _context.Add(newReceipt);
            await _context.SaveChangesAsync(cancellationToken);
            return CreateReceiptStatus.Success;
        }
    }
}