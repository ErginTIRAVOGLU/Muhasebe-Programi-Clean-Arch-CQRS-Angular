using AutoMapper;
using Proje.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using Proje.Application.Services.CompanyServices;
using Proje.Domain;
using Proje.Domain.CompanyEntities;
using Proje.Domain.Repositories.UCAFRepositories;
using Proje.Persistance.Context;

namespace Proje.Persistance.Services.CompanyServices
{
    public sealed class UCAFService : IUCAFService
    {
        private readonly IUCAFCommandRepository _commandRepository;
        private readonly IContextService _contextService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;

        public UCAFService(IUCAFCommandRepository commandRepository, IContextService contextService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _commandRepository = commandRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateUcafAsync(CreateUCAFCommand request)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            
            UniformCartOfAccount uniformCartOfAccount = _mapper.Map<UniformCartOfAccount>(request);
            await _commandRepository.AddAsync(uniformCartOfAccount);

            await _unitOfWork.SaveChangeAsync();

        }
    }
}
