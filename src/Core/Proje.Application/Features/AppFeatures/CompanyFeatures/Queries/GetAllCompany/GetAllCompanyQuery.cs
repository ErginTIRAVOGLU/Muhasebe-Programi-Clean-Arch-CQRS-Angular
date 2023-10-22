using Proje.Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompany
{
    public sealed record GetAllCompanyQuery():IQuery<GetAllCompanyQueryResponse>;
}
