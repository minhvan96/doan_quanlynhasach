using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class Staff : Entity
    {
        public Guid UserId { get; private set; }
        public string Position { get; private set; }
        public BookStore? BookStore { get; private set; }
        public Guid BookStoreId { get; private set; }

        protected Staff()
        {
            Position = string.Empty;
        }

        public Staff(Guid userId,
            Guid bookStoreId,
            string position)
        {
            UserId = userId;
            BookStoreId = bookStoreId;
            Position = position;
        }
    }
}