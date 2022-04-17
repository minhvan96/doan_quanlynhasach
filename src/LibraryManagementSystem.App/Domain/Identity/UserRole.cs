namespace BookStoreManagementSystem.App.Domain.Identity
{
    public class UserRole
    {
        public User? User { get; private set; }
        public Guid UserId { get; private set; }
        public Role? Role { get; private set; }
        public Guid RoleId { get; private set; }

        protected UserRole()
        {
        }

        public UserRole(Guid userId,
            Guid roleId)
        {
            UserId = userId;
            RoleId = roleId;
        }
    }
}