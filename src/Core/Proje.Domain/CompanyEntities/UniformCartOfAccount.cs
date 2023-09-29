using Proje.Domain.Abstractions;

namespace Proje.Domain.CompanyEntities
{
    public sealed class UniformCartOfAccount:Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; } //AnaGrup,Grup,Muavin
         
    }
}
