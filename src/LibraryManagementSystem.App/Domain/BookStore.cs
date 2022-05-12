using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class BookStore : Entity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        private readonly List<BookStoreStorage> _bookStoreStorages;
        public IReadOnlyCollection<BookStoreStorage> BookStoreStorages => _bookStoreStorages.AsReadOnly();
        private readonly List<Staff> _staffs;
        public IReadOnlyCollection<Staff> Staffs => _staffs.AsReadOnly();

        protected BookStore()
        {
            _bookStoreStorages = new List<BookStoreStorage>();
            _staffs = new List<Staff>();
        }

        public BookStore(string name,
            string address = "")
        {
            _bookStoreStorages = new List<BookStoreStorage>();
            _staffs = new List<Staff>();
            Name = name;
            Address = address;
        }

        public BookStore(Guid id,
            string name,
            string address = "")
        {
            Id = id;
            _bookStoreStorages = new List<BookStoreStorage>();
            _staffs = new List<Staff>();
            Name = name;
            Address = address;
        }
    }
}