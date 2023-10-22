using Proje.Domain.AppEntities;
using Proje.Domain.Repositories.AppDbContext.MainRoleRepositories;
using Proje.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace Proje.Persistance.Repositories.AppDbContext.MainRoleRepositories
{
    public sealed class MainRoleCommandRepository : AppCommandRepository<MainRole>,
        IMainRoleCommandRepository
    {
        public MainRoleCommandRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}