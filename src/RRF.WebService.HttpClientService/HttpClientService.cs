using Newtonsoft.Json;
using RRF.EFModels;
using RRF.GuardValidator;
using RRF.HttpClientFactoryWrapper.Abstract;
using RRF.JsonWrapper.Abstract;
using RRF.WebService.HttpClientService.Abstract;
using RRF.WebService.JsonDTO.JsonRegisterDTO;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.WebService.HttpClientService
{
    public class HttpClientService : IHttpClientService
    {
        private readonly IHttpClientFactoryWrapper httpClientFactory;
        private readonly IJsonWrapper<JsonRegisterDTO> jsonSerializer;

        public HttpClientService(IHttpClientFactoryWrapper httpClientFactory, IJsonWrapper<JsonRegisterDTO> jsonSerializer)
        {
            this.httpClientFactory = httpClientFactory;
            this.jsonSerializer = jsonSerializer;
        }

        public async Task<IList<string>> GetRoleAsync(Client client, string apiAddress)
        {
            SetClient(apiAddress);

           
            var apiCall = await this.httpClientFactory.GetRoleAsync();

            

            return apiCall;
            //TODO: REMOVE HARD CODED VALUE
       
        }

        public async Task<string> GetStringResult(string apiAddress)
        {
            SetClient(apiAddress);

            var apiCall = await this.httpClientFactory.GetStringAsync();

            return apiCall;

        }

        public async Task<bool> IsSignedIn(string apiAddress)
        {
            SetClient(apiAddress);

            return await this.httpClientFactory.IsSignedIn();
        }

        public async Task<bool> RegisterClient(string apiAddress, string email, string username, string password)
        {
            Validator.StringIsNullOrEmpty(apiAddress);

            SetClient(apiAddress);

            var jsonModel = this.jsonSerializer.SerializeObject(new JsonRegisterDTO()
            {
                email = email,
                confirmPassword = password,
                password = password
            });

            var apiCall = await this.httpClientFactory.RegisterClient(jsonModel);

            return apiCall;
         
        }

        public async Task<Client> RetrieveUserAsync(string apiAddress)
        {
            SetClient(apiAddress);

            var apiCall = await this.httpClientFactory.GetStringAsync();

            Client client = JsonConvert.DeserializeObject<Client>(apiCall);

            return client;
        }

        public void SetClient(string apiAddress, string queryString = "")
        {
            try
            {
                if (this.httpClientFactory.CreateClient())
                {
                    var address = apiAddress + (string.IsNullOrWhiteSpace(queryString) ? "" : $"/{queryString}");


                    if (this.httpClientFactory.SetBaseAddress(new Uri(apiAddress)))
                    {
                        return;
                    }

                    throw new ArgumentException("Cant't set URL");
                }

               // throw new ArgumentException("Cant't create Client");
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}