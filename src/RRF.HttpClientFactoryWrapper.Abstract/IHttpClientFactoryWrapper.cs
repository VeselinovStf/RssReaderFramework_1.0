using System;
using System.Threading.Tasks;

namespace RRF.HttpClientFactoryWrapper.Abstract
{
    public interface IHttpClientFactoryWrapper
    {
        bool CreateClient();

        bool SetBaseAddress(Uri address);

        Task<string> GetStringAsync();

        Task<bool> RegisterClient(string apiAddress, string email, string username, string password);
    }
}