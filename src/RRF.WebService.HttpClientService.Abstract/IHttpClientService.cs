using RRF.EFModels;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.WebService.HttpClientService.Abstract
{
    public interface IHttpClientService
    {
        Task<string> GetStringResult(string apiAddress);

        Task<bool> RegisterClient(string apiAddress, string email, string username, string password);

        void SetClient(string apiAddress, string queryString = "");

        Task<bool> IsSignedIn(string apiAddress);

        Task<IList<string>> GetRoleAsync(Client client, string apiAddress);

        Task<Client> RetrieveUserAsync(string apiAddress);
    }
}