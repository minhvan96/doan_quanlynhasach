using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class InventoryHistory : Entity
    {
        public DateTime Date { get; private set; }
        public Staff? Staff { get; private set; }
        public Guid StaffId { get; private set; }
        public Book? Book { get; private set; }
        public Guid BookId { get; private set; }
        public BookStore? BookStore { get; private set; }
        public Guid BookStoreId { get; private set; }
        public int ChangeNumber { get; private set; }

        protected InventoryHistory()
        {
        }

        public InventoryHistory(DateTime date,
            Guid staffId,
            Guid bookId,
            Guid bookStoreId,
            int soldNumber)
        {
            Date = date;
            StaffId = staffId;
            BookId = bookId;
            BookStoreId = bookStoreId;
            ChangeNumber = soldNumber;
        }
    }
}