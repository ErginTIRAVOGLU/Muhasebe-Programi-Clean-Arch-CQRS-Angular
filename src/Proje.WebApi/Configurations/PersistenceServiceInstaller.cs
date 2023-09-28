using Microsoft.EntityFrameworkCore;
using Proje.Domain.AppEntities.Identity;
using Proje.Persistance;
using Proje.Persistance.Context;

namespace Proje.WebApi.Configurations
{
    public class PersistenceServiceInstaller : IServiceInstaller
    {
        private const string SectionName = "SqlServer";
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(SectionName))
            );

            services.AddIdentity<AppUser, AppRole>()
                    .AddEntityFrameworkStores<AppDbContext>();

            services.AddAutoMapper(typeof
                (AssemblyReference).Assembly);

        }
    }
}
