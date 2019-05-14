using RRF.EFModels;
using RRF.Identity.ManageManager.Abstract;
using RRF.IdentityUtility.UserManagerUtility.Abstract;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.Identity.ManageManager
{
    public class ManageManager : IManageManager<Client>
    {
        private readonly IUserManagerUtility<Client> userManagerUtility;

        public ManageManager(IUserManagerUtility<Client> userManagerUtility)
        {
            this.userManagerUtility = userManagerUtility;
        }

        public async Task<IList<string>> GetRolesAsync(Client user)
        {
            return await this.userManagerUtility.GetRolesAsync(user);
        }

        public string GetUserId(ClaimsPrincipal user)
        {
            return this.userManagerUtility.GetUserId(user);
        }
    }
}
