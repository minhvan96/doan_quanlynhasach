using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class ReceiptDetail : Entity
    {
        public Guid BookId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}