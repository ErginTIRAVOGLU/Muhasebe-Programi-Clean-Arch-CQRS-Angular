using Proje.Domain.Abstractions;

namespace Proje.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyDbQueryRepository<T> : ICompanyDbRepository<T>,IQueryGenericRepository<T>
        where T : Entity
    {

       
    }
}
