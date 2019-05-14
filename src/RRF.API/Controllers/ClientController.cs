using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RRF.API.ViewModels.Identity;
using RRF.EFModels;
using RRF.Identity.AccountManager.Abstract;
using RRF.Identity.Models.BaseModel;
using RRF.IdentityControllerValidator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.API.Controllers
{
    [Route("api/Client/")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> logger;
        private readonly IIdentityControllerValidator registerValidation;

        public ClientController(

            ILogger<ClientController> logger,
            IIdentityControllerValidator registerValidation)
        {
            this.logger = logger;
            this.registerValidation = registerValidation;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register([FromBody]RegisterViewModel model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (await this.registerValidation.RegisterClientValidation(model.Email, model.Email, model.Password))
                    {
                        return Ok("User is created");
                    }
                    else
                    {
                        return BadRequest("Can't register user");
                    }
                }
                catch (Exception ex)
                {
                    this.logger.LogError(ex.Message);

                    return BadRequest("Can't register user");
                }
            }

            // If we got this far, something failed, redisplay form
            return BadRequest("Invalid model parameters!");
        }

       
    }
}