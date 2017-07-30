using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SOAnswer_45164409_3.Models;


namespace SOAnswer_45164409_3.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    { 
        // GET api/values
        [HttpGet]
        [FormatReponseFilter]
        public IActionResult Get()
        {
            TestModel model = new TestModel { Id = 24, Name = "Gareth" };
            return new ObjectResult(model);
        }

      

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
