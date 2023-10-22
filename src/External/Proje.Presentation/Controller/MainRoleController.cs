using MediatR;
using Microsoft.AspNetCore.Mvc;
using Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;
using Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;
using Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;
using Proje.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRole;
using Proje.Presentation.Abstraction;

namespace Proje.Presentation.Controller
{
    public class MainRoleController : ApiController
    {
        public MainRoleController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateMainRoleCommand request,CancellationToken cancellationToken)
        {
            CreateMainRoleCommandResponse response = await _mediator.Send(request,cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateStaticMainRoles(CancellationToken cancellationToken)
        {
            CreateStaticMainRolesCommand request = new (null);
            CreateStaticMainRolesCommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetAll(GetAllMainRoleQuery request)
        {
            GetAllMainRoleQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RemoveById(RemoveByIdMainRoleCommand request)
        {
            RemoveByIdMainRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UpdateMainRoleCommand request)
        {
            UpdateMainRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}