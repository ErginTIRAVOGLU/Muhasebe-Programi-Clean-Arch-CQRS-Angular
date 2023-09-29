using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Proje.Application.Abstractions;
using Proje.Domain.AppEntities.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Proje.Infrastructure.Authentication
{
    public sealed class JwtProvider : IJwtProvider
    {
        private readonly JwtOptions _jwtOptions;
        private readonly UserManager<AppUser> _userManager;

        public JwtProvider(IOptions<JwtOptions> jwtOptions, UserManager<AppUser> userManager)
        {
            _jwtOptions = jwtOptions.Value;
            _userManager = userManager;
        }

        public async Task<string> CreateTokenAsync(AppUser user, List<string> roles)
        {
            var claims = new Claim[]{
                new Claim(JwtRegisteredClaimNames.Sub, $"{user.Name} {user.Surname}"),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(ClaimTypes.Authentication, user.Id),
                new Claim(ClaimTypes.Role, string.Join(",",roles))

            };

            JwtSecurityToken jwtSecurityToken = new(
                issuer: _jwtOptions.Issuer,
                audience: _jwtOptions.Audience,
                claims: claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey)),SecurityAlgorithms.HmacSha256));

            string token=new JwtSecurityTokenHandler()
                            .WriteToken(jwtSecurityToken);

            string refreshToken = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
            user.RefreshToken = refreshToken;
            user.RefresTokenExpires = DateTime.Now.AddDays(30);
            await _userManager.UpdateAsync(user);

            return token;
        }
    }
}
