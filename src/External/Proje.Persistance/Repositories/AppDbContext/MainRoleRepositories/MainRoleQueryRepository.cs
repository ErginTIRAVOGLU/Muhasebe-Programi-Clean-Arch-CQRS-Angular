using Proje.Domain.AppEntities;
using Proje.Domain.Repositories.AppDbContext.MainRoleRepositories;
using Proje.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace Proje.Persistance.Repositories.AppDbContext.MainRoleRepositories
{
    public sealed class MainRoleQueryRepository : AppQueryRepository<MainRole>,
        IMainRoleQueryRepository
    {
        public MainRoleQueryRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}