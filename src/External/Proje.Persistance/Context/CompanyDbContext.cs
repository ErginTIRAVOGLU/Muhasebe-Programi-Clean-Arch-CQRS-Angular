using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Proje.Domain.Abstractions;
using Proje.Domain.AppEntities;

namespace Proje.Persistance.Context
{
    public sealed class CompanyDbContext:DbContext
    {
        private string ConnectionString = "";

        public CompanyDbContext(Company company=null)
        {               
            if(company !=null)
            { 
                if(company .UserName=="")
                {
                    ConnectionString = $"" +
                        $"Data Source={company.ServerName};" +
                        $"Initial Catalog={company.ServerName};" +   
                        $"Integrated Security=True;"+
                        $"Connect Timeout=30;" +
                        $"Encrypt=False;" +
                        $"Trust Server Certificate=False;" +
                        $"Application Intent=ReadWrite;" +
                        $"Multi Subnet Failover=False";
                }
                else
                {
                    ConnectionString = $"" + 
                        $"Data Source={company.ServerName};" +
                        $"Initial Catalog={company.DatabaseName};" +
                        $"User ID={company.UserName};" +
                        $"Password={company.ServerPassword};" +
                        $"Connect Timeout=30;" +
                        $"Encrypt=False;" +
                        $"Trust Server Certificate=False;" +
                        $"Application Intent=ReadWrite;" +
                        $"Multi Subnet Failover=False";
                }
            }

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly); 
        }

        public class CompanyDbContextFactory : IDesignTimeDbContextFactory<CompanyDbContext>
        {
            public CompanyDbContext CreateDbContext(string[] args)
            {
                return new CompanyDbContext();
            }
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<Entity>();
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property(p => p.CreatedDate)
                        .CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property(p => p.UpdatedDate)
                        .CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
