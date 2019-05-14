using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RRF.EFModels;
using RRF.IdentityControllerValidator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.API.Controllers
{
    [Route("api/ClientStatus/")]
    [ApiController]
    public class ClientStatusController : ControllerBase
    {
        private readonly ILogger<ClientStatusController> logger;
        private readonly IIdentityControllerValidator registerValidation;

        public ClientStatusController(

            ILogger<ClientStatusController> logger,
            IIdentityControllerValidator registerValidation)
        {
            this.logger = logger;
            this.registerValidation = registerValidation;
        }

       

        [HttpGet]       
        public bool IsSignedIn()
        {
            return this.registerValidation.IsSignIn(HttpContext.User);
        }

        //[HttpGet]

        //public async Task<IActionResult> RetrieveUserAsync()
        //{
        //    return Ok();
        //}
    }
}
