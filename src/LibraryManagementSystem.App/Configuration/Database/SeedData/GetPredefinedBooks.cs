using BookStoreManagementSystem.App.Domain;

namespace BookStoreManagementSystem.App.Configuration.Database
{
    public partial class BookStoreContextSeed : DbContextSeed
    {
        private static IEnumerable<Book> GetPredefinedBooks(string contentRootPath)
        {
            string csvFileBooks = Path.Combine(contentRootPath, "Setup", "Books.csv");
            if (!File.Exists(csvFileBooks))
            {
                return null;
            }

            using var reader = new StreamReader(csvFileBooks);
            var bookTypes = new List<Book>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line?.Split(',');
                var bookType = CreateBook(values[0], values[1], values[2]);
                bookTypes.Add(bookType);
            }
            return bookTypes;
        }

        private static Book CreateBook(string name, string typeId, string authorId)
        {
            return new Book(name, new Guid(typeId), new Guid(authorId));
        }
    }
}