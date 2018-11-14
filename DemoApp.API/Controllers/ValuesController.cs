using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApp.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    // http://localhost:5000/api/values
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext context;

        public ValuesController(DataContext context)
        {
            this.context = context;
        }

        // GET api/values
        [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        public IActionResult GetValues()
        {
            // return new string[] { "value1", "value2" };
            var values = context.Values.ToList();
            return Ok(values);
        }


        // GET api/values/5
        [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        public IActionResult GetValue(int id)
        {
            // return "value";
            var value = context.Values.FirstOrDefault(x => x.Id == id);
            return Ok(value);
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
