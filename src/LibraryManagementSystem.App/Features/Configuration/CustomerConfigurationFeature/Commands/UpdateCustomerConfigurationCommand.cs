using MediatR;

namespace BookStoreManagementSystem.App.Features.Configuration.CustomerConfigurationFeature.Commands
{
    public class UpdateCustomerConfigurationCommand : IRequest<UpdateCustomerConfigurationCommandStatus>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal MaximumDebt { get; set; }
    }

    public enum UpdateCustomerConfigurationCommandStatus
    {
        ConfigurationNotFound,
        Success
    }
}