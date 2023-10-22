using src\Core\Proje.Domain.AppEntities;
using src\External\Proje.Persistence.Repositories.GenericRepositories.AppDbContext;
using src\Core\Proje.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;

namespace src\External\Proje.Persistence.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;

public class UserAndCompanyRelationshipQueryRepository : AppQueryRepository<UserAndCompanyRelationship>, IUserAndCompanyRelationshipQueryRepository
{
    public UserAndCompanyRelationshipQueryRepository(Persistence.Context.AppDbContext context) : base(context){ }
}
