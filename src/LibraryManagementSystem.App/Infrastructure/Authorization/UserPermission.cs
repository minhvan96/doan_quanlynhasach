namespace BookStoreManagementSystem.App.Infrastructure.Authorization
{
    public class UserPermission : IPermission
    {
        public List<string> UserRoles { get; set; } = new List<string>();
    }
}