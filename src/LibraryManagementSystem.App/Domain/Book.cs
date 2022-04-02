using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class Book : Entity
    {
        public BookType? Type { get; private set; }
        public string? Name { get; private set; }
        public Guid TypeId { get; private set; }
        public Author? Author { get; private set; }
        public Guid AuthorId { get; private set; }

        private readonly List<BookStoreStorage> _bookStoreStorages;
        public IReadOnlyCollection<BookStoreStorage> BookStoreStorages => _bookStoreStorages.AsReadOnly();

        protected Book()
        {
            _bookStoreStorages = new List<BookStoreStorage>();
        }

        public Book(string name,
            Guid typeId,
            Guid authorId)
        {
            _bookStoreStorages = new List<BookStoreStorage>();
            TypeId = typeId;
            Name = name;
            AuthorId = authorId;
        }
    }
}