namespace BookStoreManagementSystem.App.Shared.Entity
{
    public interface IDeletableEntity
    {
        bool IsDeleted { get; set; }

        void SoftDelete();
    }
}
