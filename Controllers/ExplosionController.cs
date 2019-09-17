using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace explosive_api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExplosionController : ControllerBase
  {

    // GET api/values
    [HttpGet("{s}")]
    public ActionResult<string> GetExplosionKata(string s)
    {
      return String.Join("", s.Select((letter, index) => String.Join("", Enumerable.Repeat(letter, (int)Char.GetNumericValue(letter)))));
    }
  }
}