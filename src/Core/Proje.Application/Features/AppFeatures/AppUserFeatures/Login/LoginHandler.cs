using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Proje.Application.Abstractions;
using Proje.Domain.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;

        public LoginHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager)
        {
            _jwtProvider = jwtProvider;
            _userManager = userManager;
        }

        public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            AppUser user = await _userManager.Users
                .Where(p => p.Email == request.EmailOrUsername ||
                 p.UserName == request.EmailOrUsername).FirstOrDefaultAsync();

            if(user== null)
            {
                throw new Exception("Kullanıcı bulunamadı.");
            }

            var checkUser = await _userManager.CheckPasswordAsync(user, request.Password);
            if(!checkUser)
            {
                throw new Exception("Şifre veya kullanıcı hatalı");
            }

            List<string> roles = new();
            LoginResponse response = new()
            {
                Email = user.Email,
                Name = user.Name,
                Surname = user.Surname,
                UserId = user.Id,
                Token = await _jwtProvider.CreateTokenAsync(user, roles)
            };
            return response;
         
        }
    }
}
