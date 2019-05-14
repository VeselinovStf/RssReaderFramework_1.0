using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RRF.WebService.ClientService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRF.Web.ViewComponents.Menu
{
    public class GuestMenuViewComponent : ViewComponent
    {
        private readonly IClientService clientService;
        private readonly IConfiguration configuration;

        public GuestMenuViewComponent(
            IClientService clientService, IConfiguration configuration)
        {

            this.clientService = clientService;
            this.configuration = configuration;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (await this.clientService.IsSignedIn(this.configuration.GetSection("API_Connection:SignInCheck").Get<string>()))
            {              
                return View();
            }
            else
            {
                return View("GuestMenu");
            }
        }
    }
}
