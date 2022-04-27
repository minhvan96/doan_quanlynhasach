using BookStoreManagementSystem.App.Domain;
using System.Globalization;

namespace BookStoreManagementSystem.App.Configuration.Database
{
    public partial class BookStoreContextSeed : DbContextSeed
    {
        private static IEnumerable<BookStoreStorage> GetPredefinedBookStoreStorages(string contentRootPath)
        {
            string csvFileBooks = Path.Combine(contentRootPath, "Setup", "BookStoreStorages.csv");
            if (!File.Exists(csvFileBooks))
            {
                return null;
            }

            using var reader = new StreamReader(csvFileBooks);
            var bookStoreStorages = new List<BookStoreStorage>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line?.Split(',');
                var bookStoreStorage = CreateBookStoreStorage(values[0], values[1], values[2]);
                bookStoreStorages.Add(bookStoreStorage);
            }
            return bookStoreStorages;
        }

        private static BookStoreStorage CreateBookStoreStorage(string bookId, string bookStoreId, string availability)
        {
            return new BookStoreStorage(new Guid(bookId), new Guid(bookStoreId), int.Parse(availability));
        }
    }
}