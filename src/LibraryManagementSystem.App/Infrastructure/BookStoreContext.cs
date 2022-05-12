using BookStoreManagementSystem.App.Domain;
using BookStoreManagementSystem.App.Domain.Configuration;
using BookStoreManagementSystem.App.Domain.Identity;

namespace BookStoreManagementSystem.App.Infrastructure
{
    public class BookStoreContext : DbContext
    {
        #region CONFIGURATION

        public DbSet<BookStoreConfiguration> BookStoreConfigurations => Set<BookStoreConfiguration>();
        public DbSet<CustomerConfiguration> CustomerConfigurations => Set<CustomerConfiguration>();

        #endregion CONFIGURATION

        public DbSet<Book> Books => Set<Book>();
        public DbSet<BookType> BookTypes => Set<BookType>();
        public DbSet<BookStore> BookStores => Set<BookStore>();
        public DbSet<BookStoreStorage> BookStoresStorage => Set<BookStoreStorage>();
        public DbSet<BookSellHistory> BookSellHistories => Set<BookSellHistory>();
        public DbSet<Author> Authors => Set<Author>();

        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<CustomerDebt> CustomerDebts => Set<CustomerDebt>();
        public DbSet<Receipt> Receipts => Set<Receipt>();
        public DbSet<ReceiptDetail> ReceiptDetails => Set<ReceiptDetail>();
        public DbSet<Staff> Staffs => Set<Staff>();

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