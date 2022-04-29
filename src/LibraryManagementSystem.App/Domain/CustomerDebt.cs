using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class CustomerDebt : Entity
    {
        public Customer? Customer { get; private set; }
        public Guid CustomerId { get; private set; }
        public decimal Debt { get; private set; }

        protected CustomerDebt()
        {
        }

        public CustomerDebt(Guid customerId,
            decimal debt)
        {
            CustomerId = customerId;
            Debt = debt;
        }
    }
}