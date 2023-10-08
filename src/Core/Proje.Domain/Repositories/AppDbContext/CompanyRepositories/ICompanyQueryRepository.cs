using Proje.Domain.AppEntities;
using Proje.Domain.Repositories.GenericRepositories.AppDbContext;

namespace Proje.Domain.Repositories.AppDbContext.CompanyRepositories
{
    public interface ICompanyQueryRepository : IAppQueryRepository<Company> 
    {
    }
}
