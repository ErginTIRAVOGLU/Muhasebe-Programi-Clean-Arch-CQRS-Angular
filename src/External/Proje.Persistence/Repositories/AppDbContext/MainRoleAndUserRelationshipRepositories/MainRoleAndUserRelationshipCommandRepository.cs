using src\Core\Proje.Domain.AppEntities;
using src\External\Proje.Persistence.Repositories.GenericRepositories.AppDbContext;
using src\Core\Proje.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;

namespace src\External\Proje.Persistence.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;

public class MainRoleAndUserRelationshipCommandRepository : AppCommandRepository<MainRoleAndUserRelationship>, IMainRoleAndUserRelationshipCommandRepository
{
    public MainRoleAndUserRelationshipCommandRepository(Persistence.Context.AppDbContext context) : base(context){ }
}
