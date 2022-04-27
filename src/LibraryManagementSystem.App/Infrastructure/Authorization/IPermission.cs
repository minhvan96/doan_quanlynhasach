namespace BookStoreManagementSystem.App.Infrastructure.Authorization
{
    public interface IPermission
    {
        List<string> UserRoles { get; }
    }
}