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
    public class ValuesController : ControllerBase
    {
        private readonly IBaseModelAccess baseAccess;

        public ValuesController(IBaseModelAccess baseAccess)
        {
            this.baseAccess = baseAccess;
        }

        // GET api/values/{userId}
        
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await this.baseAccess.GetFeed("baa0d4c2-1589-4378-be1c-238612953ae1"));
        }

    
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}