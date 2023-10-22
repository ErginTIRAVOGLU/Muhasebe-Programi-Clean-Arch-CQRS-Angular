using Proje.Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Queries
{
    public sealed record GetAllMainRoleAndRoleRLQuery():IQuery<GetAllMainRoleAndRoleRLQueryResponse>;
    
}
