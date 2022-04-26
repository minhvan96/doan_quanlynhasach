using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class Author : Entity
    {
        public string Name { get; private set; }

        protected Author()
        {
            Name = string.Empty;
        }

        public Author(string name)
        {
            Name = name;
        }

        public Author(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}