using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class Receipt : Entity
    {
        public Guid CustomerId { get; private set; }
        public string Code { get; private set; }
        public DateTimeOffset SoldDate { get; private set; }
        public decimal TotalPrice { get; private set; }
        private readonly List<ReceiptDetail> _receiptDetail = new();
        public IReadOnlyCollection<ReceiptDetail> ReceiptDetail => _receiptDetail.AsReadOnly();
        public Guid StaffId { get; private set; }
        public Staff? Staff { get; private set; }
        public decimal AmountOfReceivedMoney { get; private set; }

        protected Receipt()
        {
            Code = string.Empty;
        }

        public Receipt(Guid customerId,
            string code,
            DateTimeOffset soldDate,
            decimal totalPrice)
        {
            CustomerId = customerId;
            Code = code;
            SoldDate = soldDate;
            TotalPrice = totalPrice;
        }
    }
}