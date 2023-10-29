using Proje.Domain.AppEntities;
using Proje.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using Proje.Persistance.Repositories.GenericRepositories.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories
{
    public class UserAndCompanyRelationshipQueryRepository : AppQueryRepository<UserAndCompanyRelationship>, IUserAndCompanyRelationshipQueryRepository
    {
        public UserAndCompanyRelationshipQueryRepository(Context.AppDbContext context) : base(context)
        {
        }

       
    }
}
