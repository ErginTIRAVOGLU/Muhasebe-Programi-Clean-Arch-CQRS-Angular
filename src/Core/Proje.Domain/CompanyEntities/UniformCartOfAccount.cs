using Proje.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.CompanyEntities
{
    public sealed class UniformCartOfAccount:Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; } //AnaGrup,Grup,Muavin
        public string CompanyId { get; set; }
    }
}
