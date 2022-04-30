using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class Receipt : Entity
    {
        public Guid CustomerId { get; private set; }
        public string CustomerName { get; private set; }
        public string CustomerPhoneNumber { get; private set; }
        public string CustomerEmail { get; private set; }
        public string CustomerAddress { get; private set; }
        public string Code { get; private set; }
        public DateTimeOffset SoldDate { get; private set; }
        public decimal TotalPrice { get; private set; }
        private readonly List<ReceiptDetail> _receiptDetail = new();
        public IReadOnlyCollection<ReceiptDetail> ReceiptDetail => _receiptDetail.AsReadOnly();
        public Guid StaffId { get; private set; }
        public Staff? Staff { get; private set; }
        public decimal AmountOfReceivedMoney { get; private set; }
        public decimal Debt { get; private set; }

        protected Receipt()
        {
            CustomerName = string.Empty;
            CustomerPhoneNumber = string.Empty;
            CustomerAddress = string.Empty;
            CustomerEmail = string.Empty;
            Code = string.Empty;
        }

        public Receipt(Guid staffId,
            Guid customerId,
            string customerName,
            string customerPhoneNumber,
            string customerEmail,
            string customerAddress,
            DateTimeOffset soldDate,
            decimal totalPrice,
            decimal receivedMoney,
            decimal debt)
        {
            StaffId = staffId;
            CustomerId = customerId;
            CustomerName = customerName;
            CustomerPhoneNumber = customerPhoneNumber;
            CustomerAddress = customerAddress;
            CustomerEmail = customerEmail;
            Code = customerId.ToString() + DateTime.Now.Date;
            SoldDate = soldDate;
            TotalPrice = totalPrice;
            AmountOfReceivedMoney = receivedMoney;
            Debt = debt;
        }
    }
}