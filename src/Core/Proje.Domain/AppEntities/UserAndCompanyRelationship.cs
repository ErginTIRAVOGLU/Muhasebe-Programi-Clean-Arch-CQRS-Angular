using Proje.Domain.Abstractions;
using Proje.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proje.Domain.AppEntities
{
    public class UserAndCompanyRelationship:Entity
    {
        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        [ForeignKey("Company")]
        public string CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
