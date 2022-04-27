using BookStoreManagementSystem.App.Domain.Identity;

namespace BookStoreManagementSystem.App.Configuration.Database
{
    public partial class BookStoreContextSeed : DbContextSeed
    {
        private static IEnumerable<User> GetPredefinedUsers(string contentRootPath)
        {
            string csvFileUsers = Path.Combine(contentRootPath, "Setup", "Users.csv");
            if (!File.Exists(csvFileUsers))
            {
                return null;
            }

            using var reader = new StreamReader(csvFileUsers);
            var users = new List<User>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line?.Split(',');
                var user = CreateNewUser(values[0], values[1], values[2], values[3], values[4], values[5], values[6]);
                users.Add(user);
            }
            return users;
        }

        private static User CreateNewUser(string id, string name, string fullName, string password, string email, string phoneNumber, string birthDate)
        {
            return new User(new Guid(id), name, fullName, password, email, phoneNumber, DateTime.Parse(birthDate));
        }
    }
}