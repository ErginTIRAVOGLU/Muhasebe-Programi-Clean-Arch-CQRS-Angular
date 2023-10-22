using src\Core\Proje.Domain.AppEntities;
using src\External\Proje.Persistence.Repositories.GenericRepositories.AppDbContext;
using src\Core\Proje.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;

namespace src\External\Proje.Persistence.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;

public class MainRoleAndUserRelationshipQueryRepository : AppQueryRepository<MainRoleAndUserRelationship>, IMainRoleAndUserRelationshipQueryRepository
{
    public MainRoleAndUserRelationshipQueryRepository(Persistence.Context.AppDbContext context) : base(context){ }
}
