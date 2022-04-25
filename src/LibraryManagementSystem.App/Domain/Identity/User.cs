using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain.Identity
{
    public class User : Entity
    {
        public string Name { get; private set; }
        public string FullName { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        private readonly List<UserRole> _roles = new();
        public IReadOnlyCollection<UserRole> Roles => _roles.AsReadOnly();

        protected User()
        {
            Name = string.Empty;
            FullName = string.Empty;
            Password = string.Empty;
            Email = string.Empty;
            PhoneNumber = string.Empty;
        }

        public User(string name,
            string fullName,
            string password,
            string email,
            string phoneNumber)
        {
            Name = name;
            FullName = fullName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public User(Guid id,
            string name,
            string fullName,
            string password,
            string email,
            string phoneNumber,
            DateTime birthDate)
        {
            Id = id;
            Name = name;
            FullName = fullName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
        }
    }
}