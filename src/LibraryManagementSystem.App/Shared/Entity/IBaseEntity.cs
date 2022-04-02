namespace BookStoreManagementSystem.App.Shared.Entity
{
    public interface IBaseEntity : IDeletableEntity
    {
        Guid Id { get; }
    }
}
