using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Proje.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL;
using Proje.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL;
using Proje.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Queries;
using Proje.Presentation.Abstraction;

namespace Proje.Presentation.Controller;

public class MainRoleAndRoleRelationshipsController : ApiController
{
    public MainRoleAndRoleRelationshipsController(IMediator mediator) : base(mediator) { }

    [HttpPost("[action]")]
    public async Task<IActionResult> Create(CreateMainRoleAndRoleRLCommand request,CancellationToken cancellationToken)
    {
        CreateMainRoleAndRoleRLCommandResponse response = await _mediator.Send(request,cancellationToken);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> GetAll()
    {
        GetAllMainRoleAndRoleRLQuery request = new GetAllMainRoleAndRoleRLQuery();
        GetAllMainRoleAndRoleRLQueryResponse response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> RemoveById(RemoveByIdMainRoleAndRoleRLCommand request)
    {
        RemoveByIdMainRoleAndRoleRLCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}
