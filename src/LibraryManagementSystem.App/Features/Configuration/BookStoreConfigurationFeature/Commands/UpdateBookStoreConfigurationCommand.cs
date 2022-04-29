using MediatR;

namespace BookStoreManagementSystem.App.Features.Configuration.BookStoreConfigurationFeature.Commands
{
    public class UpdateBookStoreConfigurationCommand : IRequest<UpdateBookStoreConfigurationCommandStatus>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int MaximumStock { get; set; }
        public int MinimumStock { get; set; }
        public int MinimumImportBook { get; set; }
    }

    public enum UpdateBookStoreConfigurationCommandStatus
    {
        ConfigurationNotFound,
        Success
    }
}