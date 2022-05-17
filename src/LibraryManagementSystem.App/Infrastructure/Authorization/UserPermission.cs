namespace BookStoreManagementSystem.App.Infrastructure.Authorization
{
    public class UserPermission : IPermission
    {
        public Guid UserId { get; set; }
        public List<string> UserRoles { get; set; } = new List<string>();

        public void Reset()
        {
            UserId = Guid.Empty;
            UserRoles = new List<string>();
        }
    }
}