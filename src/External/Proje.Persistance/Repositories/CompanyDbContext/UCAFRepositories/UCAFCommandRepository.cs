using Proje.Domain.CompanyEntities;
using Proje.Domain.Repositories.CompanyDbContext.UCAFRepositories;
using Proje.Persistance.Repositories.GenericRepositories.CompanyDbcontext;

namespace Proje.Persistance.Repositories.CompanyDbContext.UCAFRepositories
{
    public sealed class UCAFCommandRepository : CompanyDbCommandRepository<UniformCartOfAccount>, IUCAFCommandRepository
    {

    }
}
