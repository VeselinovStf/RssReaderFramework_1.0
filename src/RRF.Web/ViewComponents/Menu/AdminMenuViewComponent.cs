using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RRF.EFModels;
using RRF.Identity.AccountManager.Abstract;
using RRF.Identity.ManageManager.Abstract;
using RRF.Web.ViewComponents.ViewComponentsModel;
using RRF.WebService.ClientService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRF.Web.ViewComponents.Menu
{
    public class AdminMenuViewComponent : ViewComponent
    {
              
        private readonly IClientService clientService;
        private readonly IConfiguration configuration;

        public AdminMenuViewComponent(
           
            IClientService clientService, IConfiguration configuration)
        {
         
            this.clientService = clientService;
            this.configuration = configuration;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (await this.clientService.IsSignedIn(this.configuration.GetSection("API_Connection:SignInCheck").Get<string>()))
            {

                var client = await this.clientService.RetrieveUserAsync(this.configuration.GetSection("API_Connection:RetrieveUser").Get<string>());
                var role = await this.clientService.GetRolesAsync(client, this.configuration.GetSection("API_Connection:GetUserRole").Get<string>());

                if (role.Contains("Administrator"))
                {
                    return View("AdminMenu");
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
