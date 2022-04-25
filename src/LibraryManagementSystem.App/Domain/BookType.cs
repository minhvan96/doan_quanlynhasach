using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class BookType : Entity
    {
        public string? Name { get; set; }

        public BookType(string name)
        {
            Name = name;
        }

        public BookType(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}