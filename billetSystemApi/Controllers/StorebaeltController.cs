using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BilletLibrary;
using billetSystemApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace billetSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorebaeltController : ControllerBase
    {
        // GET: api/Storebaelt
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Storebaelt/5
        [HttpGet("{id}", Name = "GetS")]
        public KoretojDTO Get(int id)
        {
            KoretojDTO mitKoretoj = new KoretojDTO();

            if(id == 1)
            {
                MC minMCStorebaelt = new MC();
                mitKoretoj.pris = minMCStorebaelt.Pris();
                mitKoretoj.type = minMCStorebaelt.KøreTøjType();

                return mitKoretoj;
            }
            if(id == 2)
            {
                Bil minBilStorebaelt = new Bil();
                mitKoretoj.pris = minBilStorebaelt.Pris();
                mitKoretoj.type = minBilStorebaelt.KøreTøjType();

                return mitKoretoj;
            }
            else
            {
                return mitKoretoj;
            }
        }

        // POST: api/Storebaelt
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Storebaelt/5
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
