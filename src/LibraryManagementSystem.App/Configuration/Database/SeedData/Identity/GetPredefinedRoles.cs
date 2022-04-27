using BookStoreManagementSystem.App.Domain.Identity;

namespace BookStoreManagementSystem.App.Configuration.Database
{
    public partial class BookStoreContextSeed : DbContextSeed
    {
        private static IEnumerable<Role> GetPredefinedRoles(string contentRootPath)
        {
            string csvFileRoles = Path.Combine(contentRootPath, "Setup", "Roles.csv");
            if (!File.Exists(csvFileRoles))
            {
                return null;
            }

            using var reader = new StreamReader(csvFileRoles);
            var roles = new List<Role>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line?.Split(',');
                var role = CreateNewRole(values[0], values[1]);
                roles.Add(role);
            }
            return roles;
        }

        private static Role CreateNewRole(string id, string name)
        {
            return new Role(new Guid(id), name);
        }
    }
}