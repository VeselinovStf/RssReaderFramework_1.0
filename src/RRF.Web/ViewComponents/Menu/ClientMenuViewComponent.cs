using Microsoft.AspNetCore.Mvc;
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

        public ClientMenuViewComponent(
           
            IClientService clientService)
        {
           
            this.clientService = clientService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (this.clientService.IsSignedIn(HttpContext.User))
            {

                var client = await this.clientService.RetrieveUserAsync(HttpContext.User);
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
