using Newtonsoft.Json;
using RRF.HttpClientFactoryWrapper.Abstract;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
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

        public async Task<bool> RegisterClient(string apiAddress, string email, string username, string password)
        {
            try
            {
                //var content = new Dictionary<string, string>()
                //{
                //    { "email", email },
                //    { "password", password},
                //    { "confirmPassword" , password }
                //};

                //this.HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //var response = await this.HttpClient.PostAsync(apiAddress, new FormUrlEncodedContent(content));

                var MyObject = new JsonRegister()
                {
                    email = email,
                    password = password,
                    confirmPassword = password
                };

                HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
                var stringified = JsonConvert.SerializeObject(MyObject);
                var result = await this.HttpClient.PostAsync(apiAddress, new StringContent(stringified, Encoding.UTF8, "application/json"));

                //TODO: RETURN PROPER THING!!
                return result.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

    public class JsonRegister
    {
        public string email { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
    }
}