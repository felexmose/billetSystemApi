using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace billetSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OresundController : ControllerBase
    {
        // GET: api/Oresund
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Oresund/5
        [HttpGet("{id}", Name = "GetO")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Oresund
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Oresund/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
