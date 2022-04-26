using BookStoreManagementSystem.App.Domain.Configuration;

namespace BookStoreManagementSystem.App.Infrastructure.EntityTypeConfiguration.Configuration
{
    internal class BookStoreConfigurationEntityTypeConfiguration : IEntityTypeConfiguration<BookStoreConfiguration>
    {
        public void Configure(EntityTypeBuilder<BookStoreConfiguration> builder)
        {
            builder.ToTable("BookStoreConfigurations");
        }
    }
}