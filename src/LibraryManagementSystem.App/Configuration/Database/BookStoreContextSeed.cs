using BookStoreManagementSystem.App.Domain;
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

                #region Identity

                if (!await context.Users.AnyAsync())
                {
                    IEnumerable<User> users = GetPredefineUsers(executingFolder);
                    context.AddRange(users);
                }

                #endregion Identity

                if (!await context.Author.AnyAsync())
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
                }
                if (!await context.BookStores.AnyAsync())
                {
                    IEnumerable<BookStore> bookStores = GetPredefinedBookStores(executingFolder);
                    context.AddRange(bookStores);
                }
                if (!await context.Staffs.AnyAsync())
                {
                    IEnumerable<Staff> staffs = GetPredefinedStaffs(executingFolder);
                    context.AddRange(staffs);
                }
                await context.SaveChangesAsync();
            });
        }
    }
}