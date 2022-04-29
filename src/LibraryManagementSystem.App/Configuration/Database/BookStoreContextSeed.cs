using BookStoreManagementSystem.App.Domain;
using BookStoreManagementSystem.App.Domain.Configuration;
using BookStoreManagementSystem.App.Domain.Identity;
using BookStoreManagementSystem.App.Infrastructure;

namespace BookStoreManagementSystem.App.Configuration.Database
{
    public partial class BookStoreContextSeed : DbContextSeed
    {
        protected BookStoreContextSeed()
        {
        }

        public static async Task SeedAsync(BookStoreContext context)
        {
            var policy = CreatePolicy(nameof(BookStoreContext));
            await policy.ExecuteAsync(async () =>
            {
                var executingFolder = Path.GetDirectoryName(Application.ExecutablePath);

                #region Configuration

                if (!await context.BookStoreConfigurations.AnyAsync())
                {
                    IEnumerable<BookStoreConfiguration> configurations = GetPredefinedBookStoreConfigurations(executingFolder);
                    context.AddRange(configurations);
                }
                if (!await context.CustomerConfigurations.AnyAsync())
                {
                    IEnumerable<CustomerConfiguration> configurations = GetPredefinedCustomerConfigurations(executingFolder);
                    context.AddRange(configurations);
                }

                #endregion Configuration

                #region Identity

                if (!await context.Users.AnyAsync())
                {
                    IEnumerable<User> users = GetPredefinedUsers(executingFolder);
                    context.AddRange(users);
                }
                if (!await context.Roles.AnyAsync())
                {
                    IEnumerable<Role> roles = GetPredefinedRoles(executingFolder);
                    context.AddRange(roles);
                }
                if (!await context.UsersRoles.AnyAsync())
                {
                    IEnumerable<UserRole> userRoles = GetPredefinedUserRoles(executingFolder);
                    context.AddRange(userRoles);
                    await context.SaveChangesAsync();
                }

                #endregion Identity

                if (!await context.Authors.AnyAsync())
                {
                    IEnumerable<Author> authors;
                    authors = GetPredefinedAuthors(executingFolder);
                    context.AddRange(authors);
                    await context.SaveChangesAsync();
                }
                if (!await context.BookTypes.AnyAsync())
                {
                    IEnumerable<BookType> bookTypes = GetPredefinedBookTypes(executingFolder);
                    context.AddRange(bookTypes);
                    await context.SaveChangesAsync();
                }
                if (!await context.Books.AnyAsync())
                {
                    IEnumerable<Book> books = GetPredefinedBooks(executingFolder);
                    context.AddRange(books);
                    await context.SaveChangesAsync();
                }
                if (!await context.BookStores.AnyAsync())
                {
                    IEnumerable<BookStore> bookStores = GetPredefinedBookStores(executingFolder);
                    context.AddRange(bookStores);
                    await context.SaveChangesAsync();
                }
                if (!await context.BookStoresStorage.AnyAsync())
                {
                    IEnumerable<BookStoreStorage> bookStoreStorages = GetPredefinedBookStoreStorages(executingFolder);
                    context.AddRange(bookStoreStorages);
                }
                if (!await context.Staffs.AnyAsync())
                {
                    IEnumerable<Staff> staffs = GetPredefinedStaffs(executingFolder);
                    context.AddRange(staffs);
                }
                if (!await context.Customers.AnyAsync())
                {
                    IEnumerable<Customer> customers = GetPredefinedCustomers(executingFolder);
                    context.AddRange(customers);
                }
                await context.SaveChangesAsync();
            });
        }
    }
}