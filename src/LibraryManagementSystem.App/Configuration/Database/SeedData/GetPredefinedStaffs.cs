using BookStoreManagementSystem.App.Domain;

namespace BookStoreManagementSystem.App.Configuration.Database
{
    public partial class BookStoreContextSeed : DbContextSeed
    {
        private static IEnumerable<Staff> GetPredefinedStaffs(string contentRootPath)
        {
            string csvFileStaffs = Path.Combine(contentRootPath, "Setup", "Staffs.csv");
            if (!File.Exists(csvFileStaffs))
            {
                return null;
            }

            using var reader = new StreamReader(csvFileStaffs);
            var staffs = new List<Staff>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line?.Split(',');
                var staff = CreateNewStaff(values[0], values[1]);
                staffs.Add(staff);
            }
            return staffs;
        }

        private static Staff CreateNewStaff(string name, string position)
        {
            return new Staff(new Guid(name), position);
        }
    }
}