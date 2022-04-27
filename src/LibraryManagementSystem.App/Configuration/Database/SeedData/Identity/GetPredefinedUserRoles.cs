using BookStoreManagementSystem.App.Domain.Identity;

namespace BookStoreManagementSystem.App.Configuration.Database
{
    public partial class BookStoreContextSeed : DbContextSeed
    {
        private static IEnumerable<UserRole> GetPredefinedUserRoles(string contentRootPath)
        {
            string csvFileUserRoles = Path.Combine(contentRootPath, "Setup", "UserRoles.csv");
            if (!File.Exists(csvFileUserRoles))
            {
                return null;
            }

            using var reader = new StreamReader(csvFileUserRoles);
            var userRoles = new List<UserRole>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line?.Split(',');
                var userRole = CreateNewUserRole(values[0], values[1]);
                userRoles.Add(userRole);
            }
            return userRoles;
        }

        private static UserRole CreateNewUserRole(string userId, string roleId)
        {
            return new UserRole(new Guid(userId), new Guid(roleId));
        }
    }
}