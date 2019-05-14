using Newtonsoft.Json;
using RRF.EFModels;
using RRF.HttpClientFactoryWrapper.Abstract;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
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
                //if (this.HttpClient == null)
                //{
                    this.HttpClient = this.httpClientFactory.CreateClient();
                //}
                //else
                //{

                //    return false;
                //}
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
               
                    this.HttpClient.BaseAddress = address;

                return true;
                
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

            
        }

        public async Task<bool> RegisterClient(string model)
        {
            try
            {
                
                var result = await this.HttpClient.PostAsync(this.HttpClient.BaseAddress, new StringContent(model, Encoding.UTF8, "application/json"));

                return result.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> IsSignedIn()
        {
            try
            {
                var model = await this.HttpClient.GetStringAsync(this.HttpClient.BaseAddress);

                return Boolean.Parse(model);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<IList<string>> GetRoleAsync()
        {
            try
            {

               var call = await this.HttpClient.GetStringAsync(this.HttpClient.BaseAddress);

                var deserializeModel =  JsonConvert.DeserializeObject<IList<string>>(call);

                return deserializeModel;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}