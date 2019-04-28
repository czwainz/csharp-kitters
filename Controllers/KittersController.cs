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
      new Kitter("Homeboy", false, 3.5f),
      new Kitter("Bill", false, 10f)
    };

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<Kitter>> Get()
    {
      return Kitters;
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Kitter> Get(int id)
    {
      try
      {
        return Kitters[id];
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"No such kitter exists!\"}");
      }
    }

    // POST api/values/5
    [HttpPost]
    public ActionResult<List<Kitter>> Post(int id, [FromBody] Kitter kitter)
    {
      Kitters.Add(kitter);
      return Kitters;
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public ActionResult<List<Kitter>> Put(int id, [FromBody] Kitter kitter)
    {
      try
      {
        Kitters[id] = kitter;
        return Kitters;

      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"No such kitter!\"}");
      }
    }


    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult<List<Kitter>> Delete(int id)
    {
      try
      {
        Kitters.Remove(Kitters[id]);
        return Kitters;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"No such kitter!\"}");
      }
    }
  }
}