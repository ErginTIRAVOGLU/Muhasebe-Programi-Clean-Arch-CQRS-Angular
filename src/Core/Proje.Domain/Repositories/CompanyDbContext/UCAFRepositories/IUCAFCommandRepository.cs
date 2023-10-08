using Proje.Domain.CompanyEntities;
using Proje.Domain.Repositories.GenericRepositories.CompanyDbContext;

namespace Proje.Domain.Repositories.CompanyDbContext.UCAFRepositories
{
    public interface IUCAFCommandRepository : ICompanyDbCommandRepository<UniformCartOfAccount>
    {
    }
}
