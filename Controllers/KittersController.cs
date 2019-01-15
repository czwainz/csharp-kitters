using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kitters.Models;
using Microsoft.AspNetCore.Mvc;

namespace kitters.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class KittersController : ControllerBase
  {
    public List<Kitter> Kitters = new List<Kitter>()
    {
      new Kitter("Homegirl", true, 3.5f),
      new Kitter("Homeboy", false, 3.5f)

    };



    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<Kitter>> Get()
    {
      return Kitters;
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