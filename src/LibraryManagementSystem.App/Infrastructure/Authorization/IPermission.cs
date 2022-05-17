namespace BookStoreManagementSystem.App.Infrastructure.Authorization
{
    public interface IPermission
    {
        Guid UserId { get; set; }
        List<string> UserRoles { get; }

        void Reset();
    }
}