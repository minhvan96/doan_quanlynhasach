using BookStoreManagementSystem.App.Domain;

namespace BookStoreManagementSystem.App.Infrastructure.EntityTypeConfiguration
{
    internal class ReceiptEntityTypeConfiguration : IEntityTypeConfiguration<Receipt>
    {
        public void Configure(EntityTypeBuilder<Receipt> builder)
        {
            builder.ToTable("Receipts");
            builder.HasOne<Customer>()
                .WithMany()
                .HasForeignKey(x => x.CustomerId);
        }
    }
}