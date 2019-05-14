using RRF.GuardValidator;
using RRF.HttpClientFactoryWrapper.Abstract;
using RRF.JsonWrapper.Abstract;
using RRF.WebService.HttpClientService.Abstract;
using RRF.WebService.JsonDTO.JsonRegisterDTO;
using System;
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

        public void SetClient(string apiAddress)
        {
            try
            {
                if (this.httpClientFactory.CreateClient())
                {
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