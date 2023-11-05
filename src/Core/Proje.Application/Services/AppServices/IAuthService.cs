using Proje.Domain.AppEntities;
using Proje.Domain.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Services.AppServices
{
    public interface IAuthService
    {
        Task<AppUser> GetByEmailOrUserNameAsync(string emailOrUsername);
        Task<bool> CheckPasswordAsync(AppUser user, string password);
        Task<IList<UserAndCompanyRelationship>> GetCompanyListByUserIdAsync(string userId);
        Task<IList<string>> GetRolesByUserIdAndCompanyId(string userId, string companyId);
    }
}
