using MediatR;
using Microsoft.AspNetCore.Mvc;
using Proje.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using Proje.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;
using Proje.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
using Proje.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles;
using Proje.Presentation.Abstraction;

namespace Proje.Presentation.Controller
{
    public class RolesController : ApiController
    {
        public RolesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateRole(CreateRoleCommand request)
        {
            CreateRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllRoles()
        {
            GetAllRolesQuery request = new();
            GetAllRolesQueryResponse response= await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateRole(UpdateRoleCommand request)
        {
            UpdateRoleCommandResponse response= await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            DeleteRoleCommand request = new()
            {
                Id = id
            };
            
            DeleteRoleCommandResponse response= await _mediator.Send(request);
            return Ok(response);
        }
    }
}
