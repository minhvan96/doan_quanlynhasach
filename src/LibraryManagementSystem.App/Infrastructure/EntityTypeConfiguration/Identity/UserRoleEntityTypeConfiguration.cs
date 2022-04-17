using BookStoreManagementSystem.App.Domain.Identity;

namespace BookStoreManagementSystem.App.Infrastructure.EntityTypeConfiguration.Identity
{
    internal class UserRoleEntityTypeConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRoles");
            builder.HasKey(x => new { x.UserId, x.RoleId });
        }
    }
}