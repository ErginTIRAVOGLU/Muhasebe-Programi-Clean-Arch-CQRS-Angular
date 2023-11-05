using Proje.Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.AuthFeautures.Queries.GetRolesByUserIdAndCompanyId
{
    public sealed record GetRolesByUserIdAndCompanyIdQuery(
        string UserId,
        string CompanyId):IQuery<GetRolesByUserIdAndCompanyIdQueryResponse>;
     
}
