using BookStoreManagementSystem.App.Domain;
using BookStoreManagementSystem.App.Domain.Configuration;

namespace BookStoreManagementSystem.App.Configuration.Database
{
    public partial class BookStoreContextSeed : DbContextSeed
    {
        private static IEnumerable<BookStoreConfiguration> GetPredefinedBookStoreConfigurations(string contentRootPath)
        {
            string csvFileBookStoreConfigurations = Path.Combine(contentRootPath, "Setup", "BookStoreConfigurations.csv");
            if (!File.Exists(csvFileBookStoreConfigurations))
            {
                return null;
            }

            using var reader = new StreamReader(csvFileBookStoreConfigurations);
            var configurations = new List<BookStoreConfiguration>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line?.Split(',');
                var author = CreateNewBookStoreConfiguration(values[0], int.Parse(values[1]), int.Parse(values[2]));
                configurations.Add(author);
            }
            return configurations;
        }

        private static BookStoreConfiguration CreateNewBookStoreConfiguration(string name, int maximumStock, int minimumImportBook)
        {
            return new BookStoreConfiguration(name, maximumStock, minimumImportBook);
        }
    }
}