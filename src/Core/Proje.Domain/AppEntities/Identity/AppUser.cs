using Microsoft.AspNetCore.Identity;

namespace Proje.Domain.AppEntities.Identity
{
    public sealed class AppUser:IdentityUser<string>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefresTokenExpires { get; set; }

    }
}
