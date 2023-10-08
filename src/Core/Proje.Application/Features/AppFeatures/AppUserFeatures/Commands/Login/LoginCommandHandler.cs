using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Proje.Application.Abstractions;
using Proje.Application.Messaging;
using Proje.Domain.AppEntities.Identity;

namespace Proje.Application.Features.AppFeatures.AppUserFeatures.Commands.Login
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;

        public LoginCommandHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager)
        {
            _jwtProvider = jwtProvider;
            _userManager = userManager;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            AppUser user = await _userManager.Users
                .Where(p => p.Email == request.EmailOrUsername ||
                 p.UserName == request.EmailOrUsername).FirstOrDefaultAsync();

            if (user == null)
            {
                throw new Exception("Kullanıcı bulunamadı.");
            }

            var checkUser = await _userManager.CheckPasswordAsync(user, request.Password);
            if (!checkUser)
            {
                throw new Exception("Şifre veya kullanıcı hatalı");
            }

            List<string> roles = new();
            LoginCommandResponse response = new(
                user.Email,
                user.Name,
                user.Surname,
                user.Id,
                await _jwtProvider.CreateTokenAsync(user, roles)
            );
            return response;

        }
    }
}
