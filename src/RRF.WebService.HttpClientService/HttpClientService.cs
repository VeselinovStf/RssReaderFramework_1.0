using RRF.HttpClientFactoryWrapper.Abstract;
using RRF.WebService.HttpClientService.Abstract;
using System;
using System.Threading.Tasks;

namespace RRF.WebService.HttpClientService
{
    public class HttpClientService : IHttpClientService
    {
        private readonly IHttpClientFactoryWrapper httpClientFactory;

        public HttpClientService(IHttpClientFactoryWrapper httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<string> GetStringResult(string apiAddress)
        {
            try
            {
                if (this.httpClientFactory.CreateClient())
                {
                    if (this.httpClientFactory.SetBaseAddress(new Uri(apiAddress)))
                    {
                        var apiCall = await this.httpClientFactory.GetStringAsync();

                        return apiCall;
                    }

                    throw new ArgumentException("Cant't set URL");
                }

                throw new ArgumentException("Cant't create Client");
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<bool> RegisterClient(string apiAddress, string email, string username, string password)
        {
            try
            {
                if (this.httpClientFactory.CreateClient())
                {
                    if (this.httpClientFactory.SetBaseAddress(new Uri(apiAddress)))
                    {
                        var apiCall = await this.httpClientFactory.RegisterClient(apiAddress, email, username, password);

                        return apiCall;
                    }

                    throw new ArgumentException("Cant't set URL");
                }

                throw new ArgumentException("Cant't create Client");
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}