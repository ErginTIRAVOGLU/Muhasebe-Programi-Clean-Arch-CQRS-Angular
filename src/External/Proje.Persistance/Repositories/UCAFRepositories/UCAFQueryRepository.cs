using Proje.Domain.CompanyEntities;
using Proje.Domain.Repositories.UCAFRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Persistance.Repositories.UCAFRepositories
{
    public sealed class UCAFQueryRepository:QueryRepository<UniformCartOfAccount>,IUCAFQueryRepository
    {
    }
}
