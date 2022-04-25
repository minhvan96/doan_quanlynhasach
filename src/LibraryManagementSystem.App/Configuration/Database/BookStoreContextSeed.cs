using BookStoreManagementSystem.App.Domain;
using BookStoreManagementSystem.App.Infrastructure;
using System.Reflection;

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
                if (!await context.Author.AnyAsync())
                {
                    IEnumerable<Author> authors;
                    authors = GetPredefinedAuthors(executingFolder);
                    context.AddRange(authors);
                }
                if (!await context.BookTypes.AnyAsync())
                {
                    IEnumerable<BookType> bookTypes = GetPredefinedBookTypes(executingFolder);
                    context.AddRange(bookTypes);
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

                await context.SaveChangesAsync();
            });
        }
    }
}