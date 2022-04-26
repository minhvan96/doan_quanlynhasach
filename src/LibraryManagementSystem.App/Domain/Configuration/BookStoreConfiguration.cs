using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain.Configuration
{
    public class BookStoreConfiguration : Entity
    {
        public string Name { get; set; }

        /// <summary>
        /// Số lượng tồn kho tối đa của mỗi nhà sách
        /// </summary>
        public int MaximumStock { get; set; }

        /// <summary>
        /// Số lượng nhập sách tối thiểu
        /// </summary>
        public int MinimumBookImport { get; set; }

        protected BookStoreConfiguration()
        {
            Name = string.Empty;
        }

        public BookStoreConfiguration(string name,
            int maximumStock,
            int minimumBookImport)
        {
            Name = name;
            MaximumStock = maximumStock;
            MinimumBookImport = minimumBookImport;
        }
    }
}