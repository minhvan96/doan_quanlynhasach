using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class Book : Entity
    {
        public BookType? Type { get; private set; }
        public string Code { get; private set; }
        public string Name { get; private set; }
        public Guid TypeId { get; private set; }
        public Author? Author { get; private set; }
        public Guid AuthorId { get; private set; }
        public decimal Price { get; private set; }

        private readonly List<BookStoreStorage> _bookStoreStorages;
        public IReadOnlyCollection<BookStoreStorage> BookStoreStorages => _bookStoreStorages.AsReadOnly();

        protected Book()
        {
            _bookStoreStorages = new List<BookStoreStorage>();
            Code = string.Empty;
        }

        public Book(string name,
            string code,
            Guid typeId,
            Guid authorId,
            decimal price)
        {
            _bookStoreStorages = new List<BookStoreStorage>();
            Code = code;
            TypeId = typeId;
            Name = name;
            AuthorId = authorId;
            Price = price;
        }
    }
}