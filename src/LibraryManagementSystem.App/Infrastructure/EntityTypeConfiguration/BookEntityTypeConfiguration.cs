using BookStoreManagementSystem.App.Domain;

namespace BookStoreManagementSystem.App.Infrastructure.EntityTypeConfiguration
{
    internal class BookEntityTypeConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");

            builder.HasOne(x => x.Type)
                .WithMany()
                .HasForeignKey(x => x.TypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Author)
                .WithMany()
                .HasForeignKey(x => x.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.BookStoreStorages)
                .WithOne()
                .HasForeignKey(x => x.BookId);
        }
    }
}