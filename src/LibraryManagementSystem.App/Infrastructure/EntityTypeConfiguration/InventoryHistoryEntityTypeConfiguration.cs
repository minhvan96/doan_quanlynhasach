using BookStoreManagementSystem.App.Domain;

namespace BookStoreManagementSystem.App.Infrastructure.EntityTypeConfiguration
{
    internal class InventoryHistoryEntityTypeConfiguration : IEntityTypeConfiguration<InventoryHistory>
    {
        public void Configure(EntityTypeBuilder<InventoryHistory> builder)
        {
            builder.ToTable("InventoryHistories");

            builder.HasOne(x => x.Staff)
                .WithMany()
                .HasForeignKey(x => x.StaffId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}