using Proje.Domain.Abstractions;
using Proje.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proje.Domain.AppEntities
{
    public  class MainRoleAndUserRelationship:Entity
    {
        public MainRoleAndUserRelationship()
        {

        }

        public MainRoleAndUserRelationship(string id, string userId, string mainRoleId, string companyId) : base(id)
        {
            UserId = userId;
            CompanyId = companyId;
            MainRoleId = mainRoleId;
        }

        [ForeignKey("AppUser")]
        public string UserId { get; set; }
        public AppUser AppUser{ get; set; }

        [ForeignKey("MainRole")]
        public string MainRoleId { get; set; }
        public MainRole MainRole { get; set; }

        [ForeignKey("Company")]
        public string CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
