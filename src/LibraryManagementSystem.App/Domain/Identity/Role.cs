using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain.Identity
{
    public class Role : Entity
    {
        public string Name { get; private set; }
        private readonly List<UserRole> _user = new();
        public IReadOnlyCollection<UserRole> Users => _user.AsReadOnly();

        protected Role()
        {
            Name = string.Empty;
        }

        public Role(string name)
        {
            Name = name;
        }
    }
}