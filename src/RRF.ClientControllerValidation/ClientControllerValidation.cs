using Microsoft.Extensions.Logging;
using RRF.EFModels;
using RRF.Identity.AccountManager.Abstract;
using RRF.IdentityControllerValidator.Abstract;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.ClientControllerValidation
{
    public class ClientControllerValidation : IIdentityControllerValidator
    {
        private readonly IAccountManager<Client> accountManager;
        private readonly ILogger<ClientControllerValidation> logger;

        public ClientControllerValidation(
            IAccountManager<Client> accountManager,
            ILogger<ClientControllerValidation> logger)
        {
            this.accountManager = accountManager;
            this.logger = logger;
        }

        public async Task<bool> RegisterClientValidation(string email, string userName, string password)
        {
            try
            {
                var registeredClient = await this.accountManager.Register(email, userName, password);

                //TODO: Remove the string for role
                if (await this.accountManager.AddToRoleAsync(registeredClient, "Client"))
                {
                    this.logger.LogInformation("User created a new account with password.");

                    if (await this.accountManager.SignInAsync(registeredClient, false))
                    {
                        this.logger.LogInformation("User is created and is succesfull logged in.");

                        return true;
                    }
                    else
                    {
                        this.logger.LogInformation("User is created, but can't log in.");

                        return false;
                    }
                }
                else
                {
                    this.logger.LogInformation("Fail on adding user role.");

                    return false;
                }
            }
            catch (Exception ex)
            {
                this.logger.LogError("Can't register client : {0}", ex.Message);

                throw new AccessViolationException(ex.Message);
            }
        }

        public bool IsSignIn(ClaimsPrincipal user)
        {
            return this.accountManager.IsSignedIn(user);
        }

        public async Task<Client> RetrieveUserAsync(ClaimsPrincipal user)
        {
            return await this.accountManager.RetrieveUserAsync(user);
        }

    
        public  async Task<IList<string>> GetRolesAsync(ClaimsPrincipal user)
        {
            return await this.accountManager.GetRolesAsync(await this.accountManager.RetrieveUserAsync(user));
        }
    }
}