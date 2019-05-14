using RRF.EFModels;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.WebService.ClientService.Abstract
{
    public interface IClientService
    {
        bool IsSignedIn(ClaimsPrincipal user);

        Task<Client> RetrieveUserAsync(ClaimsPrincipal user);

        Task<IList<string>> GetRolesAsync(Client client);
    }
}
