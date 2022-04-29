using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain.Configuration
{
    public class BookStoreConfiguration : Entity
    {
        public string Name { get; set; }

        /// <summary>
        /// Số lượng tồn kho tối đa của mỗi nhà sách
        /// </summary>
        public int MaximumStock { get; private set; }

        public int MinimumStock { get; private set; }

        /// <summary>
        /// Số lượng nhập sách tối thiểu
        /// </summary>
        public int MinimumBookImport { get; private set; }

        protected BookStoreConfiguration()
        {
            Name = string.Empty;
        }

        public BookStoreConfiguration(string name,
            int maximumStock,
            int minimumStock,
            int minimumBookImport)
        {
            Name = name;
            MaximumStock = maximumStock;
            MinimumStock = minimumStock;
            MinimumBookImport = minimumBookImport;
        }

        public void Update(string name,
            int maximumStock,
            int minimumStock,
            int minimumBookImport)
        {
            Name = name;
            MaximumStock = maximumStock;
            MinimumStock = minimumStock;
            MinimumBookImport = minimumBookImport;
        }
    }
}