using Microsoft.EntityFrameworkCore;
using Proje.Domain;
using Proje.Domain.AppEntities;
using Proje.Persistance.Context;

namespace Proje.Persistance
{
    public sealed class ContextService:IContextService
    {
        private readonly AppDbContext _appContext;

        public ContextService(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public DbContext CreateDbContextInstance(string companyId)
        {
            Company company = _appContext.Set<Company>().Find(companyId);
            return new CompanyDbContext(company);
        }
    }
}
