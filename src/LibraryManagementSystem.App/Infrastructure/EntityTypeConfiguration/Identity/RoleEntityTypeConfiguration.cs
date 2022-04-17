using BookStoreManagementSystem.App.Domain.Identity;

namespace BookStoreManagementSystem.App.Infrastructure.EntityTypeConfiguration.Identity
{
    internal class RoleEntityTypeConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");
        }
    }
}