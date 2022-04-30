using MediatR;

namespace BookStoreManagementSystem.App.Features.ReceiptFeature.Commands
{
    public class CreateReceiptCommand : IRequest<CreateReceiptStatus>
    {
        public CreateReceiptRequest Request { get; set; } = new CreateReceiptRequest();
    }

    public class CreateReceiptRequest
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerPhoneNumber { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string CustomerAddress { get; set; } = string.Empty;
        public decimal ReceivedMoney { get; set; }
        public decimal Debt { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public enum CreateReceiptStatus
    {
        Success
    }
}