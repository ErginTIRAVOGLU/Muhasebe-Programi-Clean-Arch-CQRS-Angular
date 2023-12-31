﻿using Proje.Application.Messaging;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL
{
    public sealed class CreateMainRoleAndRoleRLCommandHandler : ICommandHandler<CreateMainRoleAndRoleRLCommand, CreateMainRoleAndRoleRLCommandResponse>
    {
        private readonly IMainRoleAndRoleRelationshipService _mainRoleAndRoleRelationshipService;

        public CreateMainRoleAndRoleRLCommandHandler(IMainRoleAndRoleRelationshipService mainRoleAndRoleRelationshipService)
        {
            _mainRoleAndRoleRelationshipService = mainRoleAndRoleRelationshipService;
        }

        public async Task<CreateMainRoleAndRoleRLCommandResponse> Handle(CreateMainRoleAndRoleRLCommand request, CancellationToken cancellationToken)
        {
            MainRoleAndRoleRelationship checkRoleAndMainRoleIsRelated = await _mainRoleAndRoleRelationshipService.GetByRoleIdAndMainRoleId(request.RoleId, request.MainRoleId, cancellationToken);
            
            if(checkRoleAndMainRoleIsRelated != null)
            {
                throw new Exception("Bu rol ilişkisi daha önce kurulmuş");
            }

            MainRoleAndRoleRelationship mainRoleAndRoleRelationship = new(
                Guid.NewGuid().ToString(),
                request.RoleId,
                request.MainRoleId);

            await _mainRoleAndRoleRelationshipService.CreateAsync(mainRoleAndRoleRelationship, cancellationToken);
            return new();
        }
    }
}
