using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using RRF.BaseModelAccess.Abstract;

namespace RRF.API.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class RssController : ControllerBase
    {
        private readonly IBaseModelAccess baseAccess;

        public RssController(IBaseModelAccess baseAccess)
        {
            this.baseAccess = baseAccess;
        }

        // GET api/values/{userId}       
        [HttpGet]      
      
        public async Task<ActionResult> Get(string apiKey)
        {
            try
            {
                var callModel = await this.baseAccess.GetFeed(apiKey);

                return Ok(callModel);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            
        }

    
      
    }
}