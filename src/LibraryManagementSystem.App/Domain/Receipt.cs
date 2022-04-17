using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class Receipt : Entity
    {
        public Guid CustomerId { get; set; }
        public string Code { get; set; }
        public DateTimeOffset SoldDate { get; set; }
        public decimal TotalPrice { get; set; }
        private readonly List<ReceiptDetail> _receiptDetail = new();
        public IReadOnlyCollection<ReceiptDetail> ReceiptDetail => _receiptDetail.AsReadOnly();

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