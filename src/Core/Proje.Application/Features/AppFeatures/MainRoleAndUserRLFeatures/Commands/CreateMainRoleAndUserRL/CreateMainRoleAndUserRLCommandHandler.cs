using Proje.Application.Messaging;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.CreateMainRoleAndUserRL
{
    public sealed class CreateMainRoleAndUserRLCommandHandler : 
        ICommandHandler<CreateMainRoleAndUserRLCommand, CreateMainRoleAndUserRLCommandResponse>
    {
        private readonly IMainRoleAndUserRelationshipService _service;

        public CreateMainRoleAndUserRLCommandHandler(IMainRoleAndUserRelationshipService service)
        {
            _service = service;
        }

        public async Task<CreateMainRoleAndUserRLCommandResponse> Handle(CreateMainRoleAndUserRLCommand request, CancellationToken cancellationToken)
        {
            MainRoleAndUserRelationship mainRoleAndUserRelationship = await _service.GetByUserIdCompanyIdAndMainRoleIdAsync(request.UserId, request.CompanyId, request.MainRoleId, cancellationToken);

            if(mainRoleAndUserRelationship != null)
            {
                throw new Exception("Kullanıcı bu role zaten sahip!");
            }

            MainRoleAndUserRelationship relationship = new(
                Guid.NewGuid().ToString(),
                request.UserId,
                request.MainRoleId,
                request.CompanyId);
            await _service.CreateAsync(relationship, cancellationToken);

            return new();

        }
    }
}
