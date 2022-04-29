using BookStoreManagementSystem.App.Domain.Configuration;

namespace BookStoreManagementSystem.App.Infrastructure.EntityTypeConfiguration.Configuration
{
    internal class CustomerConfigurationEntityTypeConfiguration : IEntityTypeConfiguration<CustomerConfiguration>
    {
        public void Configure(EntityTypeBuilder<CustomerConfiguration> builder)
        {
            builder.ToTable("CustomerConfigurations");
        }
    }
}