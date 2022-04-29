using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain.Identity
{
    public class Role : Entity
    {
        public string Name { get; private set; }
        private readonly List<UserRole> _userRoles;
        public IReadOnlyCollection<UserRole> UserRoles => _userRoles.AsReadOnly();

        protected Role()
        {
            _userRoles = new List<UserRole>();
            Name = string.Empty;
        }

        public Role(string name)
        {
            _userRoles = new List<UserRole>();
            Name = name;
        }

        public Role(Guid id,
            string name)
        {
            _userRoles = new List<UserRole>();
            Id = id;
            Name = name;
        }
    }
}