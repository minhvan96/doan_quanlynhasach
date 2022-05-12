using MediatR;

namespace BookStoreManagementSystem.App.Features.ReceiptFeature.Commands
{
    public class CreateReceiptCommand : IRequest<CreateReceiptStatus>
    {
        public CreateReceiptRequest Request { get; set; } = new CreateReceiptRequest();
    }

    public class CreateReceiptRequest
    {
        public Guid StaffId { get; set; }
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerPhoneNumber { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string CustomerAddress { get; set; } = string.Empty;
        public decimal ReceivedMoney { get; set; }
        public decimal Debt { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<BookInfo> Books { get; set; } = new List<BookInfo>();
    }

    public class BookInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int SoldNumber { get; set; }
    }

    public enum CreateReceiptStatus
    {
        Success
    }
}