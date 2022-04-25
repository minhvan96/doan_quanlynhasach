using BookStoreManagementSystem.App.Domain;

namespace BookStoreManagementSystem.App.Configuration.Database
{
    public partial class BookStoreContextSeed : DbContextSeed
    {
        private static IEnumerable<BookType> GetPredefinedBookTypes(string contentRootPath)
        {
            string csvFileBookTypes = Path.Combine(contentRootPath, "Setup", "BookTypes.csv");
            if (!File.Exists(csvFileBookTypes))
            {
                return null;
            }

            using var reader = new StreamReader(csvFileBookTypes);
            var bookTypes = new List<BookType>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line?.Split(',');
                var bookType = CreateBookType(values[0], values[1]);
                bookTypes.Add(bookType);
            }
            return bookTypes;
        }

        private static BookType CreateBookType(string id, string name)
        {
            return new BookType(new Guid(id), name);
        }
    }
}