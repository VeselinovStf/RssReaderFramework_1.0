using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.Identity.ManageManager.Abstract
{
    public interface IManageManager<T>
    {
        Task<IList<string>> GetRolesAsync(T user);

        string GetUserId(ClaimsPrincipal user);
    }
}
