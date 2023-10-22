using Proje.Domain.UnitOfWorks;
using Proje.Persistance.Context;

namespace Proje.Persistance.UnitOfWorks
{
    public class AppUnitOfWork : IAppUnitOfWork
    {
        private readonly AppDbContext _context;

        public AppUnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            int count=await _context.SaveChangesAsync(cancellationToken);
            return count;
        }
    }
}
