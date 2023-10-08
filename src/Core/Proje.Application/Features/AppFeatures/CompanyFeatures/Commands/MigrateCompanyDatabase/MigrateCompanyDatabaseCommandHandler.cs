using Proje.Application.Messaging;
using Proje.Application.Services.AppServices;

namespace Proje.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase
{
    public sealed class MigrateCompanyDatabaseCommandHandler :
        ICommandHandler<MigrateCompanyDatabaseCommand, MigrateCompanyDatabaseCommandResponse>
    {
        private readonly ICompanyService _companyService;

        public MigrateCompanyDatabaseCommandHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<MigrateCompanyDatabaseCommandResponse> Handle(MigrateCompanyDatabaseCommand request, CancellationToken cancellationToken)
        {
            await _companyService.MigrateCompanyDatabase();
            return new();
        }
    }
}
