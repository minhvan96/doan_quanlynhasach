using BookStoreManagementSystem.App.Domain.Configuration;

namespace BookStoreManagementSystem.App.Configuration.Database
{
    public partial class BookStoreContextSeed : DbContextSeed
    {
        private static IEnumerable<CustomerConfiguration> GetPredefinedCustomerConfigurations(string contentRootPath)
        {
            string csvFileCustomerConfigurations = Path.Combine(contentRootPath, "Setup", "CustomerConfigurations.csv");
            if (!File.Exists(csvFileCustomerConfigurations))
            {
                return null;
            }

            using var reader = new StreamReader(csvFileCustomerConfigurations);
            var configurations = new List<CustomerConfiguration>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line?.Split(',');
                var newCustomerConfiguration = CreateNewBookStoreConfiguration(values[0], int.Parse(values[1]));
                newCustomerConfiguration.SetAsDefault();
                configurations.Add(newCustomerConfiguration);
            }
            return configurations;
        }

        private static CustomerConfiguration CreateNewBookStoreConfiguration(string name, int maximumDebt)
        {
            return new CustomerConfiguration(name, maximumDebt);
        }
    }
}