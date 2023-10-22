using src\Core\Proje.Domain.AppEntities;
using src\External\Proje.Persistence.Repositories.GenericRepositories.AppDbContext;
using src\Core\Proje.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;

namespace src\External\Proje.Persistence.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;

public class UserAndCompanyRelationshipCommandRepository : AppCommandRepository<UserAndCompanyRelationship>, IUserAndCompanyRelationshipCommandRepository
{
    public UserAndCompanyRelationshipCommandRepository(Persistence.Context.AppDbContext context) : base(context){ }
}
