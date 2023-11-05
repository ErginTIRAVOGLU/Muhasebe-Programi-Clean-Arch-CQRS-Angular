using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Proje.Application.Abstractions;
using Proje.Application.Messaging;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities;
using Proje.Domain.AppEntities.Identity;
using Proje.Domain.Dtos;

namespace Proje.Application.Features.AppFeatures.AuthFeautures.Commands.Login
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;
        private readonly IAuthService _authService;

        public LoginCommandHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager, IAuthService authService)
        {
            _jwtProvider = jwtProvider;
            _userManager = userManager;
            _authService = authService;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            AppUser user = await _authService.GetByEmailOrUserNameAsync(request.EmailOrUsername);
            //_userManager.Users.Where(p => p.Email == request.EmailOrUsername || p.UserName == request.EmailOrUsername).FirstOrDefaultAsync();

            if (user == null)
            {
                throw new Exception("Kullanıcı bulunamadı.");
            }

            var checkUser = await _authService.CheckPasswordAsync(user, request.Password);

            if (!checkUser)
            {
                throw new Exception("Şifre veya kullanıcı hatalı");
            }

            IList<UserAndCompanyRelationship> companies = await _authService.GetCompanyListByUserIdAsync(user.Id);

            if (companies.Count() == 0)
            {
                throw new Exception("Herhangi bir şirkete kayıtlı değilsiniz!");
            }

            IList<CompanyDto> companyDtos = companies.Select(s => new CompanyDto(s.Id, s.Company.Name)).ToList();
            LoginCommandResponse response = new(
                Token: await _jwtProvider.CreateTokenAsync(user),
                Email: user.Email,
                UserId: user.Id,
                Name: user.Name,
                Surname: user.Surname,
                Companies: companyDtos,
                Company: companyDtos[0]
            );
            return response;

        }
    }
}
