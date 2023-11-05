using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities;
using Proje.Domain.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Persistance.Services.AppServices
{
    public sealed class AuthService : IAuthService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserAndCompanyRelationshipService _companyRLService;
        private readonly IMainRoleAndUserRelationshipService _mainRoleAndUserRelationshipService;
        private readonly IMainRoleAndRoleRelationshipService _mainRoleAndRoleRelationshipService;

        public AuthService(UserManager<AppUser> userManager, IUserAndCompanyRelationshipService companyRLService, IMainRoleAndUserRelationshipService mainRoleAndUserRelationshipService, IMainRoleAndRoleRelationshipService mainRoleAndRoleRelationshipService)
        {
            _userManager = userManager;
            _companyRLService = companyRLService;
            _mainRoleAndUserRelationshipService = mainRoleAndUserRelationshipService;
            _mainRoleAndRoleRelationshipService = mainRoleAndRoleRelationshipService;
        }

        public async Task<bool> CheckPasswordAsync(AppUser user, string password)
        {
            return await _userManager.CheckPasswordAsync(user, password);
        }

        public async Task<AppUser> GetByEmailOrUserNameAsync(string emailOrUsername)
        {
            return await _userManager.Users.Where(p => p.Email == emailOrUsername || p.UserName == emailOrUsername).FirstOrDefaultAsync();
        }

        public async Task<IList<UserAndCompanyRelationship>> GetCompanyListByUserIdAsync(string userId)
        {
            return await _companyRLService.GetListByUserIdAsync(userId);
        }

        public async Task<IList<string>> GetRolesByUserIdAndCompanyId(string userId, string companyId)
        {
            MainRoleAndUserRelationship mainRoleAndRoleRelationship = await _mainRoleAndUserRelationshipService.GetRolesByUserIdAndCompanyId(userId, companyId);

            IList<MainRoleAndRoleRelationship> getMainRole = await _mainRoleAndRoleRelationshipService.GetListByMainRoleIdForGetRolesAsync(mainRoleAndRoleRelationship.MainRoleId);
            IList<string> roles = getMainRole.Select(s => s.AppRole.Name).ToList();
            return roles;
        }
    }
}
