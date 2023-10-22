using MediatR;
using Proje.Domain.AppEntities;
using System.Threading;

namespace Proje.Application.Services.AppServices
{
    public interface IMainRoleService
    {
        Task<MainRole> GetByTitleAndCompanyId(string title, string companyId, CancellationToken cancellationToken);
        Task CreateAsync(MainRole mainRole,CancellationToken cancellationToken);

        Task CreateRangeAsync(List<MainRole> mainRoles,CancellationToken cancellationToken);

        IQueryable<MainRole> GetAll();

        Task RemoveByIdAsync(string id, CancellationToken cancellationToken);

        Task<MainRole> GetByIdAsync(string id);
        Task UpdateAsync(MainRole mainrole);
    }
}
