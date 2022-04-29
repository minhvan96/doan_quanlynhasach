namespace BookStoreManagementSystem.App.Features.Configuration.BookStoreConfigurationFeature.Dtos
{
    public class BookStoreConfigurationDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int MaximumStock { get; set; }
        public int MinimumStock { get; set; }
        public int MinimumBookImport { get; set; }
    }
}