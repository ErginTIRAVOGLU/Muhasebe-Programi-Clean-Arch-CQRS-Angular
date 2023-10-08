using Proje.Application.Services.AppServices;
using Proje.Application.Services.CompanyServices;
using Proje.Domain;
using Proje.Persistance.Services.AppServices;
using Proje.Persistance.Services.CompanyServices;
using Proje.Persistance;
using Proje.Domain.Repositories.CompanyDbContext.UCAFRepositories;
using Proje.Persistance.Repositories.CompanyDbContext.UCAFRepositories;
using Proje.Domain.Repositories.AppDbContext.CompanyRepositories;
using Proje.Persistance.Repositories.AppDbContext.CompanyRepositories;
using Proje.Domain.UnitOfWorks;
using Proje.Persistance.UnitOfWorks;

namespace Proje.WebApi.Configurations
{
    public class PersistenceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            #region Context UnitOfWork
            services.AddScoped<ICompanyDbUnitOfWork, CompanyDbUnitOfWork>();
            services.AddScoped<IContextService, ContextService>();
            services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
            #endregion

            #region Services
                #region CompanyDbContext
                services.AddScoped<IUCAFService, UCAFService>();
                #endregion
            
                #region AppDbContext
                services.AddScoped<ICompanyService, CompanyService>();
                services.AddScoped<IRoleService, RoleService>();
                #endregion
            #endregion


            #region Repositories
            #region CompanyDbContext            
            services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
                services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
                #endregion

                #region AppDbContext
                services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
                services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
                #endregion
            #endregion

        }
    }
}
