namespace BookStoreManagementSystem.App.Features.CustomerFeature.Dtos
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public IReadOnlyCollection<CustomerDebtDto> Debts { get; set; } = new List<CustomerDebtDto>();
    }

    public class CustomerDebtDto
    {
        public decimal Debt { get; set; }
    }
}