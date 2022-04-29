using BookStoreManagementSystem.App.Domain;

namespace BookStoreManagementSystem.App.Infrastructure.EntityTypeConfiguration
{
    internal class CustomerDebtEntityTypeConfiguration : IEntityTypeConfiguration<CustomerDebt>
    {
        public void Configure(EntityTypeBuilder<CustomerDebt> builder)
        {
            builder.ToTable("CustomerDebts");
        }
    }
}