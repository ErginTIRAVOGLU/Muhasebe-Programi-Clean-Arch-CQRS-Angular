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
using Proje.Domain.Repositories.AppDbContext.MainRoleRepositories;
using Proje.Persistance.Repositories.AppDbContext.MainRoleRepositories;
using Proje.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using Proje.Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using Proje.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using Proje.Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using Proje.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using Proje.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
//UsingSpot

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
                //CompanyServiceDISpot
                #endregion

                #region AppDbContext
                services.AddScoped<ICompanyService, CompanyService>();
                services.AddScoped<IRoleService, RoleService>();
                services.AddScoped<IMainRoleService, MainRoleService>();
                services.AddScoped<IMainRoleAndRoleRelationshipService, MainRoleAndRoleRelationshipService>();
                services.AddScoped<IUserAndCompanyRelationshipService, UserAndCompanyRelationshipService>();
            services.AddScoped<IMainRoleAndUserRelationshipService, MainRoleAndUserRelationshipService>();
                //AppServiceDISpot
                #endregion
            #endregion


            #region Repositories
                #region CompanyDbContext            
                services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
                services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
                //CompanyRepositoryDISpot
                #endregion

                #region AppDbContext
                services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
                services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
                
                services.AddScoped<IMainRoleCommandRepository, MainRoleCommandRepository>();
                services.AddScoped<IMainRoleQueryRepository, MainRoleQueryRepository>();
            
                services.AddScoped<IMainRoleAndRoleRelationshipCommandRepository, MainRoleAndRoleRelationshipCommandRepository>();
                services.AddScoped<IMainRoleAndRoleRelationshipQueryRepository, MainRoleAndRoleRelationshipQueryRepository>();
                services.AddScoped<IUserAndCompanyRelationshipCommandRepository, UserAndCompanyRelationshipCommandRepository>();
                services.AddScoped<IUserAndCompanyRelationshipQueryRepository, UserAndCompanyRelationshipQueryRepository>();
            services.AddScoped<IMainRoleAndUserRelationshipCommandRepository, MainRoleAndUserRelationshipCommandRepository>();
            services.AddScoped<IMainRoleAndUserRelationshipQueryRepository, MainRoleAndUserRelationshipQueryRepository>();
            //AppRepositoryDISpot
            #endregion
            #endregion

        }
    }
}
