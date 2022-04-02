namespace BookStoreManagementSystem.App.Shared.Entity
{
    public interface IAuditableEntity
    {
        void SetCreatedBy(string? userId);

        string? CreatedBy { get; set; }
        string? UpdatedBy { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        DateTimeOffset UpdatedDate { get; set; }
    }
}
