using Microsoft.EntityFrameworkCore;
using Proje.Domain.Abstractions;

namespace Proje.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyDbRepository<T>:IRepository<T>
        where T : Entity
    {
        void SetDbContextInstance(DbContext context);
       
    }
}
