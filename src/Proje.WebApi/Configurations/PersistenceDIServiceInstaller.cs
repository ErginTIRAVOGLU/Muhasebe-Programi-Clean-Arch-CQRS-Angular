using Proje.Application.Services.AppServices;
using Proje.Application.Services.CompanyServices;
using Proje.Domain.Repositories.UCAFRepositories;
using Proje.Domain;
using Proje.Persistance.Repositories.UCAFRepositories;
using Proje.Persistance.Services.AppServices;
using Proje.Persistance.Services.CompanyServices;
using Proje.Persistance;

namespace Proje.WebApi.Configurations
{
    public class PersistenceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            #region Context UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IContextService, ContextService>();
            #endregion

            #region Services
            services.AddScoped<ICompanyService, CompanyService>();           
            services.AddScoped<IUCAFService, UCAFService>();
            services.AddScoped<IRoleService,RoleService>();
            #endregion

            #region Repositories
            services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
            services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
            #endregion

        }
    }
}
