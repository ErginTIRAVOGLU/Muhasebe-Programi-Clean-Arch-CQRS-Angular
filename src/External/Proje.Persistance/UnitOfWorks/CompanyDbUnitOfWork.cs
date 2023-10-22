using Microsoft.EntityFrameworkCore;
using Proje.Domain.UnitOfWorks;
using Proje.Persistance.Context;

namespace Proje.Persistance.UnitOfWorks
{
    public sealed class CompanyDbUnitOfWork : ICompanyDbUnitOfWork
    {
        private CompanyDbContext _context;

        public void SetDbContextInstance(DbContext context)
        {
            _context = (CompanyDbContext)context;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken=default)
        {
            int count = await _context.SaveChangesAsync(cancellationToken);
            return count;
        }
    }
}
