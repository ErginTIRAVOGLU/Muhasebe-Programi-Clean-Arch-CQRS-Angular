using Microsoft.EntityFrameworkCore;

namespace Proje.Domain
{
    public interface IContextService
    {
        DbContext CreateDbContextInstance(string companyId);
    }
}
