using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class BookStore : Entity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        private readonly List<BookStoreStorage> _bookStoreStorages;
        public IReadOnlyCollection<BookStoreStorage> BookStoreStorages => _bookStoreStorages.AsReadOnly();

        protected BookStore()
        {
            _bookStoreStorages = new List<BookStoreStorage>();
        }

        public BookStore(string name,
            string address = "")
        {
            _bookStoreStorages = new List<BookStoreStorage>();
            Name = name;
            Address = address;
        }
    }
}