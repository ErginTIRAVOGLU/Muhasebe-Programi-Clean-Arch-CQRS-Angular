using Microsoft.EntityFrameworkCore;

namespace Proje.Domain.UnitOfWorks
{
    public interface ICompanyDbUnitOfWork : IUnitOfWork
    {
        void SetDbContextInstance(DbContext context);

    }
}
