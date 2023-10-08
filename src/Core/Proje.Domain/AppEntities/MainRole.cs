using Proje.Domain.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proje.Domain.AppEntities
{
    public sealed class MainRole:Entity
    {
       
        public string Title { get; set; }
        [ForeignKey("Company")]
        public string CompanyId { get; set; }
        public Company? Company { get; set; }
        public bool IsRoleCreatedById { get; set; }
    }
}
