using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        protected Customer()
        {
            Name = string.Empty;
            FullName = string.Empty;
            Address = string.Empty;
            PhoneNumber = string.Empty;
            Email = string.Empty;
        }

        public Customer(string name,
            string fullName,
            DateTime birthDate,
            string address,
            string phoneNumber,
            string email)
        {
            Name = name;
            FullName = fullName;
            BirthDate = birthDate;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}