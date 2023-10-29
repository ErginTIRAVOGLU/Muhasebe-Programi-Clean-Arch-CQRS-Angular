using Proje.Domain.AppEntities;
using Proje.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using Proje.Persistance.Repositories.GenericRepositories.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories
{
    public class MainRoleAndUserRelationshipCommandRepository : AppCommandRepository<MainRoleAndUserRelationship>, IMainRoleAndUserRelationshipCommandRepository
    {
        public MainRoleAndUserRelationshipCommandRepository(Persistance.Context.AppDbContext context) : base(context) { }
    }
}
