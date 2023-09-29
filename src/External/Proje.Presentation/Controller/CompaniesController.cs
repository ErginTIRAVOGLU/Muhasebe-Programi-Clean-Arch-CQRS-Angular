using MediatR;
using Microsoft.AspNetCore.Mvc;
using Proje.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Proje.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase;
using Proje.Presentation.Abstraction;

namespace Proje.Presentation.Controller
{
    public class CompaniesController : ApiController
    {
        public CompaniesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCompany(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            CreateCompanyCommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> MigrateCompanyDatabases()
        {
            MigrateCompanyDatabaseCommand request = new();
            MigrateCompanyDatabaseCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        /*
        [HttpGet("[action]")]
        public async Task<IActionResult> CheckCancellationToken(CancellationToken cancellationToken)
        {
            try
            {
                await Task.Delay(10000,cancellationToken);
                Console.WriteLine("Cancellation Token çalışmadı. İşlem tamamlandı");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cancellation Token çalıştı. İşlem iptal edildi.");
                throw;
            }
            
            
            return NoContent();
        }
        */
    }
}
