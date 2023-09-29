using Microsoft.EntityFrameworkCore;

namespace Proje.Domain
{
    public interface IUnitOfWork
    {
        void SetDbContextInstance(DbContext context);
        Task<int> SaveChangeAsync();
    }
}
