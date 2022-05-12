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

        protected BookSellHistory()
        {
        }

        public BookSellHistory(DateTime date,
            Guid staffId,
            Guid bookId,
            Guid bookStoreId,
            int soldNumber)
        {
            Date = date;
            StaffId = staffId;
            BookId = bookId;
            BookStoreId = bookStoreId;
            SoldNumber = soldNumber;
        }
    }
}