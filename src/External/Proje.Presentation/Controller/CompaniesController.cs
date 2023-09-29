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
        public async Task<IActionResult> CreateCompany(CreateCompanyRequest request)
        {
            CreateCompanyResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> MigrateCompanyDatabases()
        {
            MigrateCompanyDatabaseRequest request = new();
            MigrateCompanyDatabaseResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
