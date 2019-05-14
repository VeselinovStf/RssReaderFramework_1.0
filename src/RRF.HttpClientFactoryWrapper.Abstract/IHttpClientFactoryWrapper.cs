using RRF.EFModels;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.HttpClientFactoryWrapper.Abstract
{
    public interface IHttpClientFactoryWrapper
    {
        bool CreateClient();

        bool SetBaseAddress(Uri address);

        Task<string> GetStringAsync();

        Task<bool> RegisterClient(string model);

        Task<bool> IsSignedIn();

        Task<IList<string>> GetRoleAsync();
    }
}