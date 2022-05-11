using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class BookSellHistory : Entity
    {
        public DateTime Date { get; private set; }
        public Guid StaffId { get; private set; }
        public Guid BookId { get; private set; }
        public Guid BookStoreId { get; private set; }
        public int SoldNumber { get; private set; }
    }
}