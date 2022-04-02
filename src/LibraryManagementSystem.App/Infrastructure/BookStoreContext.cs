using BookStoreManagementSystem.App.Domain;
using Microsoft.Extensions.Options;

namespace BookStoreManagementSystem.App.Infrastructure
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<BookType> BookTypes => Set<BookType>();
        public DbSet<BookStore> BookStores => Set<BookStore>();
        public DbSet<BookStoreStorage> BookStoresStorage => Set<BookStoreStorage>();
        public DbSet<Author> Author => Set<Author>();
        public string DbPath { get; }

        public BookStoreContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "bookstore.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookStoreContext).Assembly);
        }
    }
}