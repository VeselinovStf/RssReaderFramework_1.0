using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RRF.API.ViewModels.Identity;
using RRF.Identity.AccountManager.Abstract;
using RRF.Identity.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRF.API.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly IAccountManager<BaseIdentityModel> accountManager;
        private readonly ILogger<AccountController> logger;

        public AccountController(
            IAccountManager<BaseIdentityModel> accountManager,
            ILogger<AccountController> logger)
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

                    return Ok(model);
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