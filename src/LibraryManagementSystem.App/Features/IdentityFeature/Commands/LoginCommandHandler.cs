using BookStoreManagementSystem.App.Features.IdentityFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;
using MediatR;

namespace BookStoreManagementSystem.App.Features.IdentityFeature.Commands
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, UserDto>
    {
        private readonly BookStoreContext _context;

        public LoginCommandHandler(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<UserDto> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users
                .AsNoTracking()
                .Include(x => x.UserRoles)
                .Where(x => x.Name == request.Request.UserName && x.Password == request.Request.Password)
                .Select(x => new UserDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Roles = x.UserRoles.Select(x => x.Role.Name).ToList()
                })
                .FirstOrDefaultAsync(cancellationToken);

            return user;
        }
    }
}