using Proje.Domain.AppEntities.Identity;

namespace Proje.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
    public sealed class GetAllRolesResponse
    {
        public IList<AppRole> Roles { get; set; }
    }
}