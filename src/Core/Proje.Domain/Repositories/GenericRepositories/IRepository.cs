using Microsoft.EntityFrameworkCore;
using Proje.Domain.Abstractions;

namespace Proje.Domain.Repositories.GenericRepositories
{
    public interface IRepository<T>  where T:Entity
    {
        DbSet<T> Entity { get; set; }
    }
}
