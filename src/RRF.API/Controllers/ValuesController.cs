using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        [Route("api/[controller]/{userId}")]
        [HttpGet]
        public async Task<ActionResult> Get(string userId)
        {
            return Ok(await this.baseAccess.GetFeed(userId));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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