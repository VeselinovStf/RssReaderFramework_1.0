using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RRF.EFModels;
using RRF.Identity.AccountManager.Abstract;
using RRF.Identity.ManageManager.Abstract;
using RRF.WebService.ClientService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRF.Web.ViewComponents.Menu
{
    public class ClientMenuViewComponent : ViewComponent
    {
      
        private readonly IClientService clientService;
        private readonly IConfiguration configuration;

        public ClientMenuViewComponent(
           
            IClientService clientService, IConfiguration configuration)
        {
           
            this.clientService = clientService;
            this.configuration = configuration;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (await this.clientService.IsSignedIn(this.configuration.GetSection("API_Connection:SignInCheck").Get<string>()))
            {

                var client = await this.clientService.RetrieveUserAsync();
                var role = await this.clientService.GetRolesAsync(client);           

                if (role.Contains("Client"))
                {
                    return View("ClientMenu");
                }


                return View();
            }
            else
            {
                return View();
            }
        }
    }
}
