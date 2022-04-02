using BookStoreManagementSystem.App.Shared.Entity;

namespace BookStoreManagementSystem.App.Domain
{
    public class Author : Entity
    {
        public string? Name { get; private set; }

        protected Author()
        {
        }

        public Author(string name)
        {
            Name = name;
        }
    }
}