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
        public async Task<IActionResult> CreateRole(CreateRoleRequest request)
        {
            CreateRoleResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllRoles()
        {
            GetAllRolesRequest request = new();
            GetAllRolesResponse response= await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateRole(UpdateRoleRequest request)
        {
            UpdateRoleResponse response= await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            DeleteRoleRequest request = new()
            {
                Id = id
            };
            
            DeleteRoleResponse response= await _mediator.Send(request);
            return Ok(response);
        }
    }
}
