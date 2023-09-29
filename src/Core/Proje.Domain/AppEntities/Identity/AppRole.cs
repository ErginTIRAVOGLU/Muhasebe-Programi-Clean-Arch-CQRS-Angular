using Microsoft.AspNetCore.Identity;

namespace Proje.Domain.AppEntities.Identity
{
    public sealed class AppRole:IdentityRole<string>
    {
        public string Code { get; set; }       
    }
}
