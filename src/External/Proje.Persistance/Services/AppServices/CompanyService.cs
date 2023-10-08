using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Proje.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities;
using Proje.Domain.Repositories.AppDbContext.CompanyRepositories;
using Proje.Domain.UnitOfWorks;
using Proje.Persistance.Context;

namespace Proje.Persistance.Services.AppServices
{
    public sealed class CompanyService : ICompanyService
    {

        private readonly ICompanyCommandRepository _companyCommandRepository;
        private readonly ICompanyQueryRepository _companyQueryRepository;
        private readonly IAppUnitOfWork _appUnitOfWork;
        private readonly IMapper _mapper;

        public CompanyService(IMapper mapper, ICompanyCommandRepository companyCommandRepository, ICompanyQueryRepository companyQueryRepository, IAppUnitOfWork appUnitOfWork)
        {

            _mapper = mapper;
            _companyCommandRepository = companyCommandRepository;
            _companyQueryRepository = companyQueryRepository;
            _appUnitOfWork = appUnitOfWork;
        }

        public async Task CreateCompany(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            Company company = _mapper.Map<Company>(request);
            await _companyCommandRepository.AddAsync(company, cancellationToken);
            await _appUnitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<Company?> GetCompanyByName(string name)
        {
            return await _companyQueryRepository.GetFirstByExpiression(p => p.Name == name);
        }

        public async Task MigrateCompanyDatabase()
        {
            var companies = await _companyQueryRepository.GetAll().ToListAsync();

            foreach (var company in companies)
            {
                var db = new CompanyDbContext(company);
                db.Database.Migrate();
            }
        }
    }
}
