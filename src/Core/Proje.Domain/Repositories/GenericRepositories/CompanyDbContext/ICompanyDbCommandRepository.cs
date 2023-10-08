using Proje.Domain.Abstractions;

namespace Proje.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyDbCommandRepository<T> : ICompanyDbRepository<T>,ICommandGenericRepository<T>
        where T : Entity
    {

       
    }
}
