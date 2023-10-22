using Proje.Application.Messaging;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities.Identity;
using Proje.Domain.Roles;

namespace Proje.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles
{
    public sealed class CreateStaticRolesCommandHandler : ICommandHandler<CreateStaticRolesCommand, CreateStaticRolesCommandResponse>
    {
        private readonly IRoleService _roleService;

        public CreateStaticRolesCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<CreateStaticRolesCommandResponse> Handle(CreateStaticRolesCommand request, CancellationToken cancellationToken)
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
