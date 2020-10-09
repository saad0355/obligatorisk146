using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FanOutPut2;

namespace RestService.Controllers
{
    //controller præfikset
    [Route("[controller]")]
    [ApiController]
    public class MålingController : Controller
    {

        private readonly static List<FanOutPut> FanOutPutRecords = new List<FanOutPut>()
        {
            new FanOutPut (1, "koldt", 21, 32),
            new FanOutPut (2, "varmtluft", 22, 34),
            new FanOutPut (3, "frys", 23, 36),
            new FanOutPut (4, "varmt", 24, 38),

        };

        //vi har 4 værdier og derfor skal den tage 5 som den næste efter tallet 4
        //hvis vi have haft 5 værider så skulle der stå 5:
        private static int FanOutPutId = 4;

        // GET: api/Måling
        [HttpGet]
        public IEnumerable<FanOutPut> Get()
        {
            return FanOutPutRecords;
        }


        // GET: api/Måling/5
        [HttpGet("{id}", Name = "Get")]
        public FanOutPut Get(int id)
        {
            return FanOutPutRecords.Find(i=> i.Id==id);
        }

        // POST: api/Måling
        [HttpPost]
        public void Post([FromBody] FanOutPut value)
        {
            //auto increment med ny id hver gang vi tilføjer en ny
            FanOutPutId++;
            value.Id = FanOutPutId;
            FanOutPutRecords.Add(value);
        }

        // PUT: api/Måling/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FanOutPut value)
        {
            FanOutPut fanOutPut = Get(id);
            if (FanOutPutRecords != null)
            {
                fanOutPut.Id = value.Id;
                fanOutPut.Name = value.Name;
                fanOutPut.Temp = value.Temp;
                fanOutPut.Fugt = value.Fugt;
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           FanOutPut fanOutPut = Get(id);
            FanOutPutRecords.Remove(fanOutPut);
            
        }
    }
}
