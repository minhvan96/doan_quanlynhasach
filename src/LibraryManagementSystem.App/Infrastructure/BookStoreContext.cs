using BookStoreManagementSystem.App.Domain;
using BookStoreManagementSystem.App.Domain.Identity;

namespace BookStoreManagementSystem.App.Infrastructure
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<BookType> BookTypes => Set<BookType>();
        public DbSet<BookStore> BookStores => Set<BookStore>();
        public DbSet<BookStoreStorage> BookStoresStorage => Set<BookStoreStorage>();
        public DbSet<Author> Author => Set<Author>();

        public DbSet<Customer> Customer => Set<Customer>();
        public DbSet<Receipt> Receipt => Set<Receipt>();
        public DbSet<ReceiptDetail> ReceiptDetail => Set<ReceiptDetail>();

        public DbSet<Role> Roles => Set<Role>();
        public DbSet<User> Users => Set<User>();
        public DbSet<UserRole> UsersRoles => Set<UserRole>();

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
            //optionsBuilder.UseSqlServer("Data Source=VANNGUYEN;Initial Catalog=BookStore;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookStoreContext).Assembly);
        }
    }
}