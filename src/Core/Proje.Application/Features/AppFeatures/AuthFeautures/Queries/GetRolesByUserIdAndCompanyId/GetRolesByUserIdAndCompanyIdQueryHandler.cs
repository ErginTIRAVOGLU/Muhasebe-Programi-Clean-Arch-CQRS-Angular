using Proje.Application.Messaging;
using Proje.Application.Services.AppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.AuthFeautures.Queries.GetRolesByUserIdAndCompanyId
{
    public sealed class GetRolesByUserIdAndCompanyIdQueryHandler : IQueryHandler<GetRolesByUserIdAndCompanyIdQuery,
        GetRolesByUserIdAndCompanyIdQueryResponse>
    {
        private readonly IAuthService _authService;

        public GetRolesByUserIdAndCompanyIdQueryHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<GetRolesByUserIdAndCompanyIdQueryResponse> Handle(GetRolesByUserIdAndCompanyIdQuery request, CancellationToken cancellationToken)
        {
            IList<string> roles=await _authService.GetRolesByUserIdAndCompanyId(request.UserId,request.CompanyId);

            return new(roles);
        }
    }
}
