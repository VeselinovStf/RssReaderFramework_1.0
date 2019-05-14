using System;
using System.Threading.Tasks;

namespace RRF.WebService.HttpClientService.Abstract
{
    public interface IHttpClientService
    {
        Task<string> GetStringResult(string apiAddress);

        Task<bool> RegisterClient(string apiAddress, string email, string username, string password);

        void SetClient(string apiAddress);
    }
}