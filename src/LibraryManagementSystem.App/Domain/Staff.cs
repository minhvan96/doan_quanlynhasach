using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class Staff : Entity
    {
        public Guid UserId { get; set; }
        public string Position { get; set; }

        protected Staff()
        {
            Position = string.Empty;
        }

        public Staff(Guid userId,
            string position)
        {
            UserId = userId;
            Position = position;
        }
    }
}