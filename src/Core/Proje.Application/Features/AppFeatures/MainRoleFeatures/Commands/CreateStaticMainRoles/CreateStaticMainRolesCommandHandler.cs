using Proje.Application.Messaging;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities;
using Proje.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles
{
    public sealed class CreateStaticMainRolesCommandHandler : ICommandHandler<CreateStaticMainRolesCommand, CreateStaticMainRolesCommandResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public CreateStaticMainRolesCommandHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<CreateStaticMainRolesCommandResponse> Handle(CreateStaticMainRolesCommand request, CancellationToken cancellationToken)
        {
            List<MainRole> mainRoles = RoleList.GetStaticMainRoles();
            List<MainRole> newMainRoles = new List<MainRole>();

            foreach (var mainRole in mainRoles)
            {
                MainRole checkMainRole = await _mainRoleService.GetByTitleAndCompanyId(mainRole.Title, mainRole.CompanyId, cancellationToken);
                if (checkMainRole != null)
                {
                    newMainRoles.Add(checkMainRole);
                }
            }

            await _mainRoleService.CreateRangeAsync(newMainRoles,cancellationToken);
            return new();
        }
    }
}
