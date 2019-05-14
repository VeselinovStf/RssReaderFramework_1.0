using RRF.EFModels;
using RRF.IdentityUtility.UserManagerUtility.Abstract;
using RRF.WebService.ClientService.Abstract;
using RRF.WebService.HttpClientService.Abstract;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.WebService.ClientService
{
    public class ClientService : IClientService
    {      
        private readonly IHttpClientService httpClientService;

        public ClientService(IHttpClientService httpClientService)
        {
           
            this.httpClientService = httpClientService;
        }

        public Task<IList<string>> GetRolesAsync(Client client)
        {
            throw new NotImplementedException();
        }

        public bool IsSignedIn(ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public Task<Client> RetrieveUserAsync(ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }
    }
}
