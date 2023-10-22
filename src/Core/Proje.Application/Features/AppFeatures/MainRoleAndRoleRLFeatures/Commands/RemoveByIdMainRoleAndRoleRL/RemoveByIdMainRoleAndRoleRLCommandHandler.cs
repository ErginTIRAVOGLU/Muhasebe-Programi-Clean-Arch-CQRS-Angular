using Proje.Application.Messaging;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL
{
    public sealed class RemoveByIdMainRoleAndRoleRLCommandHandler : ICommandHandler<RemoveByIdMainRoleAndRoleRLCommand,
        RemoveByIdMainRoleAndRoleRLCommandResponse>
    {
        private readonly IMainRoleAndRoleRelationshipService _mainRoleAndRoleRelationshipService;

        public RemoveByIdMainRoleAndRoleRLCommandHandler(IMainRoleAndRoleRelationshipService mainRoleAndRoleRelationshipService)
        {
            _mainRoleAndRoleRelationshipService = mainRoleAndRoleRelationshipService;
        }

        public async Task<RemoveByIdMainRoleAndRoleRLCommandResponse> Handle(RemoveByIdMainRoleAndRoleRLCommand request, CancellationToken cancellationToken)
        {
            MainRoleAndRoleRelationship entity = await _mainRoleAndRoleRelationshipService.GetByIdAsync(request.id);
            if(entity == null)
            {
                throw new Exception("Belirtilen Ana Rol ve Rol bağlantısı bulunamadı.");
            }
            await _mainRoleAndRoleRelationshipService.RemoveByIdAsync(request.id);
            return new();
        }
    }
}
