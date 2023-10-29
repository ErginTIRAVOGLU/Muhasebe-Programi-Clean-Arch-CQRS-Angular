using Proje.Domain.AppEntities;
using Proje.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using Proje.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using Proje.Persistance.Repositories.GenericRepositories.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories
{
    public class UserAndCompanyRelationshipCommandRepository : AppCommandRepository<UserAndCompanyRelationship>, IUserAndCompanyRelationshipCommandRepository
    {
        public UserAndCompanyRelationshipCommandRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
