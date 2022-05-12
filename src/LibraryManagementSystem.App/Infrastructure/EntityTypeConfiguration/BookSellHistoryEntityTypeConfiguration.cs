using BookStoreManagementSystem.App.Domain;

namespace BookStoreManagementSystem.App.Infrastructure.EntityTypeConfiguration
{
    internal class BookSellHistoryEntityTypeConfiguration : IEntityTypeConfiguration<BookSellHistory>
    {
        public void Configure(EntityTypeBuilder<BookSellHistory> builder)
        {
            builder.ToTable("BookSellHistories");
        }
    }
}