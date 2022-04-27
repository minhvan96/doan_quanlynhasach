using BookStoreManagementSystem.App.Features.IdentityFeature.Dtos;
using MediatR;

namespace BookStoreManagementSystem.App.Features.IdentityFeature.Commands
{
    public class LoginCommand : IRequest<UserDto>
    {
        public LoginRequest Request { get; set; } = new LoginRequest();
    }

    public class LoginRequest
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}