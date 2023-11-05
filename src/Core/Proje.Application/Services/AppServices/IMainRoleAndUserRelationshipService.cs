
using Proje.Domain.AppEntities;

namespace Proje.Application.Services.AppServices;

public interface IMainRoleAndUserRelationshipService
{
    Task CreateAsync(MainRoleAndUserRelationship mainRoleAndRoleRelationship, CancellationToken cancellationToken);
    Task RemoveByIdAsync(string id);
    Task<MainRoleAndUserRelationship> GetByUserIdCompanyIdAndMainRoleIdAsync(string userId, string companyId, string mainRoleId, CancellationToken cancellationToken);
    Task<MainRoleAndUserRelationship> GetByIdAsync(string id, bool tracking);
    Task<MainRoleAndUserRelationship> GetRolesByUserIdAndCompanyId(string userId, string companyId);
}
