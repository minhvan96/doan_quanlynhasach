namespace BookStoreManagementSystem.App.Features.Configuration.CustomerConfigurationFeature.Dtos
{
    public class CustomerConfigurationDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal MaximumDebt { get; set; }
        public bool IsDefault { get; set; }
    }
}