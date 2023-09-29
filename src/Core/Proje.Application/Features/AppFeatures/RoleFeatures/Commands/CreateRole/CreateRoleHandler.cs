using MediatR;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities.Identity;

namespace Proje.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public sealed class CreateRoleHandler : IRequestHandler<CreateRoleRequest, CreateRoleResponse>
    {
        private readonly IRoleService _roleService;

        public CreateRoleHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<CreateRoleResponse> Handle(CreateRoleRequest request, CancellationToken cancellationToken)
        {
            AppRole role = await _roleService.GetByCode(request.Code);
            if (role != null) { throw new Exception("Bu rol kayıtlı."); }

          
            await _roleService.AddAsync(request);
            return new();
        }
    }
}
