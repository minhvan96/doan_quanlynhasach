using BookStoreManagementSystem.App.Domain.Identity;

namespace BookStoreManagementSystem.App.Infrastructure.EntityTypeConfiguration.Identity
{
    internal class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
        }
    }
}