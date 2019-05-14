using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RRF.IdentityControllerValidator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRF.API.Controllers
{
    [Route("api/ClientRole/")]
    [ApiController]
    public class ClientRoleController : ControllerBase
    {
        private readonly ILogger<ClientRoleController> logger;
        private readonly IIdentityControllerValidator registerValidation;

        public ClientRoleController(

            ILogger<ClientRoleController> logger,
            IIdentityControllerValidator registerValidation)
        {
            this.logger = logger;
            this.registerValidation = registerValidation;
        }

        [HttpGet]
        
        public async Task<IActionResult> GetRolesAsync()
        {
            //TODO: REFORMAT HERE !!! why from register validator??
            var userRole = await this.registerValidation.GetRolesAsync(HttpContext.User);

            return Ok(userRole);
        }

    }
}