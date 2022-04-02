using BookStoreManagementSystem.App.Domain;

namespace BookStoreManagementSystem.App.Infrastructure.EntityTypeConfiguration
{
    internal class BookStoreEntityTypeConfiguration : IEntityTypeConfiguration<BookStore>
    {
        public void Configure(EntityTypeBuilder<BookStore> builder)
        {
            builder.ToTable("BookStores");

            builder.HasMany<BookStoreStorage>()
                .WithOne()
                .HasForeignKey(x => x.BookStoreId);
        }
    }
}