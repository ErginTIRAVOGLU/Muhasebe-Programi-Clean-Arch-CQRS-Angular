using Proje.Domain.AppEntities.Identity;
using Proje.Domain.Dtos;

namespace Proje.Application.Abstractions
{
    public interface IJwtProvider
    {
        Task<TokenRefreshTokenDto> CreateTokenAsync(AppUser user);
    }
}
