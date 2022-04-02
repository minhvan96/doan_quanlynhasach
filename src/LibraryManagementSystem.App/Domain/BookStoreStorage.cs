namespace BookStoreManagementSystem.App.Domain
{
    public class BookStoreStorage
    {
        public Book? Book { get; private set; }
        public Guid BookId { get; private set; }
        public Guid? BookStoreId { get; private set; }
        public int Availability { get; private set; }

        protected BookStoreStorage()
        {
        }

        public BookStoreStorage(Guid bookId,
            Guid bookStoreId)
        {
            BookId = bookId;
            BookStoreId = bookStoreId;
        }

        public void Import(int number)
        {
            Availability += number;
        }

        public void Export(int number)
        {
            Availability -= number;
        }
    }
}