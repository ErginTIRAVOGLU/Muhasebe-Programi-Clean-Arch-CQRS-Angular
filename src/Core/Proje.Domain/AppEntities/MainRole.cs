using Proje.Domain.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proje.Domain.AppEntities
{
    public sealed class MainRole : Entity
    {
        public MainRole()
        {
            
        }
        public MainRole(string id, string title, string companyId = null, bool isRoleCreatedByAdmin = false) : base(id)
        {
            Title = title;
            CompanyId = companyId;
            IsRoleCreatedByAdmin = isRoleCreatedByAdmin;
        }

        public string Title { get; set; }
        [ForeignKey("Company")]
        public string CompanyId { get; set; }
        public Company? Company { get; set; }
        public bool IsRoleCreatedByAdmin { get; set; }
    }
}
