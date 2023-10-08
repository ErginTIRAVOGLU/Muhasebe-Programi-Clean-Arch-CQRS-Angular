using AutoMapper;
using Proje.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using Proje.Application.Services.CompanyServices;
using Proje.Domain;
using Proje.Domain.CompanyEntities;
using Proje.Domain.Repositories.CompanyDbContext.UCAFRepositories;
using Proje.Domain.UnitOfWorks;
using Proje.Persistance.Context;

namespace Proje.Persistance.Services.CompanyServices
{
    public sealed class UCAFService : IUCAFService
    {
        private readonly IUCAFCommandRepository _commandRepository;
        private readonly IUCAFQueryRepository _queryRepository;
        private readonly IContextService _contextService;
        private readonly ICompanyDbUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;

        public UCAFService(IUCAFCommandRepository commandRepository, IContextService contextService, ICompanyDbUnitOfWork unitOfWork, IMapper mapper, IUCAFQueryRepository queryRepository)
        {
            _commandRepository = commandRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _queryRepository = queryRepository;
        }

        public async Task CreateUcafAsync(CreateUCAFCommand request, CancellationToken cancellationToken)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            
            UniformCartOfAccount uniformCartOfAccount = _mapper.Map<UniformCartOfAccount>(request);
            await _commandRepository.AddAsync(uniformCartOfAccount,cancellationToken);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

        }

        public async Task<UniformCartOfAccount> GetByCode(string code)
        {
            return await _queryRepository.GetFirstByExpiression(m => m.Code == code);
        }
    }
}
