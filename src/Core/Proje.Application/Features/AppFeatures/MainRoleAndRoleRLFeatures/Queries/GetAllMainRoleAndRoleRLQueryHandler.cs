using Microsoft.EntityFrameworkCore;
using Proje.Application.Messaging;
using Proje.Application.Services.AppServices;
using Proje.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Queries
{
    public sealed class GetAllMainRoleAndRoleRLQueryHandler : IQueryHandler<GetAllMainRoleAndRoleRLQuery, GetAllMainRoleAndRoleRLQueryResponse>
    {
        private readonly IMainRoleAndRoleRelationshipService _roleRelationshipService;

        public GetAllMainRoleAndRoleRLQueryHandler(IMainRoleAndRoleRelationshipService roleRelationshipService)
        {
            _roleRelationshipService = roleRelationshipService;
        }

        public async Task<GetAllMainRoleAndRoleRLQueryResponse> Handle(GetAllMainRoleAndRoleRLQuery request, CancellationToken cancellationToken)
        {
            return new(await _roleRelationshipService
                .GetAll()
                .Include("AppRole")
                .Include("MainRole")
                .ToListAsync());
        }
    }
}
