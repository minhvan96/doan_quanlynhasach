using BookStoreManagementSystem.App.Domain;

namespace BookStoreManagementSystem.App.Infrastructure.EntityTypeConfiguration
{
    internal class BookStoreStoragentityTypeConfiguration : IEntityTypeConfiguration<BookStoreStorage>
    {
        public void Configure(EntityTypeBuilder<BookStoreStorage> builder)
        {
            builder.ToTable("BookStoreStorages");

            builder.HasKey(x => new { x.BookId, x.BookStoreId });
        }
    }
}