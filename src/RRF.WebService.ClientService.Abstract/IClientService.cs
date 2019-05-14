using RRF.EFModels;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.WebService.ClientService.Abstract
{
    public interface IClientService
    {
        Task<bool> IsSignedIn(string apiAddress);

        Task<Client> RetrieveUserAsync();

        Task<IList<string>> GetRolesAsync(Client client);
    }
}
