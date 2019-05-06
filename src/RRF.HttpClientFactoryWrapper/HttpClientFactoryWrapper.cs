using RRF.HttpClientFactoryWrapper.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RRF.HttpClientFactoryWrapper
{
    /// <summary>
    /// HttpClientFactory concrete wrapper
    /// </summary>
    public class HttpClientFactoryWrapper : IHttpClientFactoryWrapper
    {
        private readonly IHttpClientFactory httpClientFactory;
        public HttpClient HttpClient { get; set; }

        public HttpClientFactoryWrapper(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public bool CreateClient()
        {
            try
            {
                if (this.HttpClient == null)
                {
                    this.HttpClient = this.httpClientFactory.CreateClient();
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

            return true;
        }

        public async Task<string> GetStringAsync()
        {
            try
            {
                return await this.HttpClient.GetStringAsync(this.HttpClient.BaseAddress);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public bool SetBaseAddress(Uri address)
        {
            try
            {
                if (this.HttpClient.BaseAddress == null)
                {
                    this.HttpClient.BaseAddress = address;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

            return true;
        }
    }
}