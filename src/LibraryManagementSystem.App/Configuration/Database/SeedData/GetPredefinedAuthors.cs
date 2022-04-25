using BookStoreManagementSystem.App.Domain;

namespace BookStoreManagementSystem.App.Configuration.Database
{
    public partial class BookStoreContextSeed : DbContextSeed
    {
        private static IEnumerable<Author> GetPredefinedAuthors(string contentRootPath)
        {
            string csvFileAuthors = Path.Combine(contentRootPath, "Setup", "Authors.csv");
            if (!File.Exists(csvFileAuthors))
            {
                return null;
            }

            using var reader = new StreamReader(csvFileAuthors);
            var brands = new List<Author>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line?.Split(',');
                var author = CreateNewAuthor(values[0], values[1]);
                brands.Add(author);
            }
            return brands;
        }

        private static Author CreateNewAuthor(string id, string name)
        {
            return new Author(new Guid(id), name);
        }
    }
}