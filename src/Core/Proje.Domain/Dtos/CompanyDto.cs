using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Dtos
{
    public sealed record CompanyDto(
        string CompanyId,
        string CompanyName);
}
