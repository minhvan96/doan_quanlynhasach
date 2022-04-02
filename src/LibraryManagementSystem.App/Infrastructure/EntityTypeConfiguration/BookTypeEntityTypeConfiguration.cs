using BookStoreManagementSystem.App.Domain;

namespace BookStoreManagementSystem.App.Infrastructure.EntityTypeConfiguration
{
    internal class BookTypeEntityTypeConfiguration : IEntityTypeConfiguration<BookType>
    {
        public void Configure(EntityTypeBuilder<BookType> builder)
        {
            builder.ToTable("BookTypes");
        }
    }
}