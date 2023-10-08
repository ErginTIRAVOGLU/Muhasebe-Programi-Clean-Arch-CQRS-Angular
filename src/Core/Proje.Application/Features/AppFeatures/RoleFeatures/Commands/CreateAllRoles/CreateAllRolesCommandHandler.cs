using Proje.Application.Messaging;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities.Identity;
using Proje.Domain.Roles;

namespace Proje.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles
{
    public sealed class CreateAllRolesCommandHandler : ICommandHandler<CreateAllRolesCommand, CreateAllRolesCommandResponse>
    {
        private readonly IRoleService _roleService;

        public CreateAllRolesCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<CreateAllRolesCommandResponse> Handle(CreateAllRolesCommand request, CancellationToken cancellationToken)
        {
            IList<AppRole> originalRoleList = RoleList.GetStaticRoles();
            IList<AppRole> currentRoleList =new List<AppRole>();

            foreach (var item in originalRoleList)
            {
                AppRole checkRole = await _roleService.GetByCode(item.Code);
                if(checkRole == null) { currentRoleList.Add(item); }
            }

            await _roleService.AddRangeAsync(currentRoleList);
            return new();
        }
    }
}
