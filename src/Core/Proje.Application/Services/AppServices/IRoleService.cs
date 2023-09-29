using Proje.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using Proje.Domain.AppEntities.Identity;

namespace Proje.Application.Services.AppServices
{
    public interface IRoleService
    {
        Task AddAsync(CreateRoleCommand request);
        Task UpdateAsync(AppRole appRole);
        Task DeleteAsync(AppRole appRole);
        Task<IList<AppRole>> GetAllRolesAsync();
        Task<AppRole> GetById(string id);
        Task<AppRole> GetByCode(string code);

    }
}
