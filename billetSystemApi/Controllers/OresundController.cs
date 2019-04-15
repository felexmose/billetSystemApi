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
        public KoretojDTO Get(int id)
        {
            KoretojDTO mitKoretoj = new KoretojDTO();

            if(id == 1)
            {
                MCØresund minMCØresund = new MCØresund();
                mitKoretoj.pris = minMCØresund.Pris();
                mitKoretoj.type = minMCØresund.KøreTøjType();

                return mitKoretoj;
            }
            if(id == 2)
            {
                BilØreSund minBilØresund = new BilØreSund();
                mitKoretoj.pris = minBilØresund.Pris();
                mitKoretoj.type = minBilØresund.KøreTøjType();

                return mitKoretoj;
            }
            else
            {
                //BilØreSund minBilØresund = new BilØreSund();
                //mitKoretoj.pris = minBilØresund.Pris();
                //mitKoretoj.type = minBilØresund.KøreTøjType();
                return mitKoretoj;
            }
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
