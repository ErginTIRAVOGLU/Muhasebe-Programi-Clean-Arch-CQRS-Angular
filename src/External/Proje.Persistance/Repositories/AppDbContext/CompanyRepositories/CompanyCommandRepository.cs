using Proje.Domain.AppEntities;
using Proje.Domain.Repositories.AppDbContext.CompanyRepositories;
using Proje.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace Proje.Persistance.Repositories.AppDbContext.CompanyRepositories
{
    public sealed class CompanyCommandRepository : AppCommandRepository<Company>, ICompanyCommandRepository
    {
        public CompanyCommandRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
