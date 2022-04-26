using BookStoreManagementSystem.App.Domain;

namespace BookStoreManagementSystem.App.Configuration.Database
{
    public partial class BookStoreContextSeed : DbContextSeed
    {
        private static IEnumerable<Customer> GetPredefinedCustomers(string contentRootPath)
        {
            string csvFileCustomers = Path.Combine(contentRootPath, "Setup", "Customers.csv");
            if (!File.Exists(csvFileCustomers))
            {
                return null;
            }

            using var reader = new StreamReader(csvFileCustomers);
            var customers = new List<Customer>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line?.Split(',');
                var customer = CreateNewCustomer(values[0], values[1], values[2], values[3], values[4], values[5]);
                customers.Add(customer);
            }
            return customers;
        }

        private static Customer CreateNewCustomer(string name, string fullName, string birthDate, string address, string phoneNumber, string email)
        {
            return new Customer(name, fullName, DateTime.Parse(birthDate), address, phoneNumber, email);
        }
    }
}