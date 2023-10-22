using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities;
using Proje.Domain.Repositories.AppDbContext.MainRoleRepositories;
using Proje.Domain.UnitOfWorks;

namespace Proje.Persistance.Services.AppServices
{
    public sealed class MainRoleService : IMainRoleService
    {
        private readonly IMainRoleCommandRepository _mainRoleCommandRepository;
        private readonly IMainRoleQueryRepository _mainRoleQueryRepository;
        private readonly IAppUnitOfWork _unitOfWork;

        public MainRoleService(IMainRoleCommandRepository mainRoleRommandRepository, IMainRoleQueryRepository mainRoleQueryRepository, IAppUnitOfWork unitOfWork)
        {
            _mainRoleCommandRepository = mainRoleRommandRepository;
            _mainRoleQueryRepository = mainRoleQueryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken)
        {
            await _mainRoleCommandRepository.AddAsync(mainRole, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task CreateRangeAsync(List<MainRole> mainRoles, CancellationToken cancellationToken)
        {
            await _mainRoleCommandRepository.AddRangeAsync(mainRoles, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken: cancellationToken);
        }

        public IQueryable<MainRole> GetAll()
        {
            return _mainRoleQueryRepository.GetAll();
        }

        public async Task<MainRole> GetByIdAsync(string id)
        {
            return await _mainRoleQueryRepository.GetById(id);
        }

        public async Task<MainRole> GetByTitleAndCompanyId(string title, string companyId, CancellationToken cancellationToken)
        {
            //if (companyId == null) return await _mainRoleQueryRepository.GetFirstByExpiression(p => p.Title == title, cancellationToken,false);

            return await _mainRoleQueryRepository.GetFirstByExpiression(p => p.Title == title && p.CompanyId == companyId, cancellationToken, false);
        }

        public async Task RemoveByIdAsync(string id, CancellationToken cancellationToken)
        {
            await _mainRoleCommandRepository.RemoveById(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(MainRole mainrole)
        {
            _mainRoleCommandRepository.Update(mainrole);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
