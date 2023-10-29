using Proje.Application.Messaging;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.RemoveByIdMainRoleAndUserRL
{
    public sealed class RemoveByIdMainRoleAndUserRLCommandHandler:ICommandHandler<RemoveByIdMainRoleAndUserRLCommand, RemoveByIdMainRoleAndUserRLCommandResponse>
    {
        private readonly IMainRoleAndUserRelationshipService _service;

        public RemoveByIdMainRoleAndUserRLCommandHandler(IMainRoleAndUserRelationshipService service)
        {
            _service = service;
        }

        public async Task<RemoveByIdMainRoleAndUserRLCommandResponse> Handle(RemoveByIdMainRoleAndUserRLCommand request, CancellationToken cancellationToken)
        {
            MainRoleAndUserRelationship checkEntity = await _service.GetByIdAsync(request.Id, false);
            if (checkEntity == null)
            {
                throw new Exception("Kullanıcı bu role zaten sahip değil.");
            }
            await _service.RemoveByIdAsync(request.Id);
            return new();
        }
    }
}
