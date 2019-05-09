using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RRF.API.ViewModels.Identity;
using RRF.EFModels;
using RRF.Identity.AccountManager.Abstract;
using RRF.Identity.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRF.API.Controllers
{
    [Route("api/Client/")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IAccountManager<Client> accountManager;
        private readonly ILogger<ClientController> logger;

        public ClientController(
            IAccountManager<Client> accountManager,
            ILogger<ClientController> logger)
        {
            this.accountManager = accountManager;
            this.logger = logger;
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]      
        public async Task<IActionResult> Register([FromBody]RegisterViewModel model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = await this.accountManager.Register(model.Email, model.Email, model.Password);

                    await this.accountManager.AddToRoleAsync(user, "Client");

                    this.logger.LogInformation("User created a new account with password.");

                    var signUser = await this.accountManager.SignInAsync(user, isPersistent: false);

                    return Ok(user);
                }
                catch (Exception ex)
                {
                    this.logger.LogInformation("Register model is not valid!");

                    return BadRequest(ex.Message);
                }
            }
            else
            {
                this.logger.LogInformation("Register model is not valid!");

                return BadRequest(model);
            }
        }
    }
}