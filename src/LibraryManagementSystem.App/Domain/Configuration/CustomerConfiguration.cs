using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain.Configuration
{
    public class CustomerConfiguration : Entity
    {
        public bool IsDefault { get; private set; }

        public string Name { get; set; }
        public decimal MaximumDebt { get; set; }

        protected CustomerConfiguration()
        {
            Name = string.Empty;
        }

        public CustomerConfiguration(string name,
            decimal maximumDebt)
        {
            Name = name;
            MaximumDebt = maximumDebt;
        }

        public void SetAsDefault()
        {
            IsDefault = true;
        }
    }
}