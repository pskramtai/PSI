using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebService.Base_Classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        // GET: api/<Main>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { JsonSerializer.Serialize(new Bar("Kartusis", "Jogailos 13")) };//new string[] { "value1", "value2" };
        }

        // GET api/<Main>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Main>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Main>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Main>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
