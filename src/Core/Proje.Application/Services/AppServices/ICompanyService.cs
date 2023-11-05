using Proje.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Proje.Domain.AppEntities;

namespace Proje.Application.Services.AppServices
{
    public interface ICompanyService
    {
        Task CreateCompany(CreateCompanyCommand request, CancellationToken cancellationToken);
        Task<Company?> GetCompanyByName(string name);
        Task MigrateCompanyDatabase();
        IQueryable<Company> GetAll();
       
    }
}
