using RRF.EFModels;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.IdentityControllerValidator.Abstract
{
    public interface IIdentityControllerValidator
    {
        Task<bool> RegisterClientValidation(string email, string userName, string password);

        bool IsSignIn(ClaimsPrincipal user);

        Task<Client> RetrieveUserAsync(ClaimsPrincipal user);
        Task<IList<string>> GetRolesAsync(ClaimsPrincipal user);
    }
}