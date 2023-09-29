using Proje.Domain.AppEntities.Identity;

namespace Proje.Application.Abstractions
{
    public interface IJwtProvider
    {
        Task<string> CreateTokenAsync(AppUser user, List<string?> roles);
    }
}
