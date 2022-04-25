using BookStoreManagementSystem.App.Domain;

namespace BookStoreManagementSystem.App.Configuration.Database
{
    public partial class BookStoreContextSeed : DbContextSeed
    {
        private static IEnumerable<BookStore> GetPredefinedBookStores(string contentRootPath)
        {
            string csvFileBookStores = Path.Combine(contentRootPath, "Setup", "Books.csv");
            if (!File.Exists(csvFileBookStores))
            {
                return null;
            }

            using var reader = new StreamReader(csvFileBookStores);
            var bookStores = new List<BookStore>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line?.Split(',');
                var bookStore = CreateBookStore(values[0], values[1]);
                bookStores.Add(bookStore);
            }
            return bookStores;
        }

        private static BookStore CreateBookStore(string name, string address)
        {
            return new BookStore(name, address);
        }
    }
}