using Proje.Domain.AppEntities;
using Proje.Persistance.Repositories.GenericRepositories.AppDbContext;
using Proje.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;

namespace Proje.Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;

public class MainRoleAndRoleRelationshipQueryRepository : AppQueryRepository<MainRoleAndRoleRelationship>, IMainRoleAndRoleRelationshipQueryRepository
{
    public MainRoleAndRoleRelationshipQueryRepository(Persistance.Context.AppDbContext context) : base(context){ }
}
