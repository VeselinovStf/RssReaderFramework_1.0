using Microsoft.Extensions.Configuration;
using RRF.WebService.AccountControllerService.Abstract;
using RRF.WebService.HttpClientService.Abstract;
using System;
using System.Threading.Tasks;

namespace RRF.WebService.AccountControllerService
{
    public class AccountControllerService : IAccountControllerService
    {
        private readonly IConfiguration configuration;
        private readonly IHttpClientService httpClientService;

        public AccountControllerService(IConfiguration configuration, IHttpClientService httpClientService)
        {
            this.configuration = configuration;
            this.httpClientService = httpClientService;
        }

        public async Task<bool> RegistarPostCall(string email, string userName, string password)
        {
            try
            {
                var apiAddress = this.configuration.GetSection("API_Connection:RegisterClientPage").Value;

                var result = await this.httpClientService.RegisterClient(apiAddress, email, userName, password);

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}