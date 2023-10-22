using Proje.Application.Messaging;
using Proje.Application.Services.AppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole
{
    public sealed class RemoveByIdMainRoleCommandHandler : ICommandHandler<RemoveByIdMainRoleCommand, RemoveByIdMainRoleCommandResponse>
    {

        private readonly IMainRoleService _mainRoleService;

        public RemoveByIdMainRoleCommandHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<RemoveByIdMainRoleCommandResponse> Handle(RemoveByIdMainRoleCommand request, CancellationToken cancellationToken)
        {
            await _mainRoleService.RemoveByIdAsync(request.Id, cancellationToken);
            return new ();
        }
    }
}
