using Microsoft.EntityFrameworkCore;
using Proje.Domain.Abstractions;

namespace Proje.Domain.Repositories
{
    public interface IRepository<T> 
        where T : Entity
    {
        void SetDbContextInstance(DbContext context);
        DbSet<T> Entity { get; set; }
    }
}
