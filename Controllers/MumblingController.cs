using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace explosive_api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MumblingController : ControllerBase
  {

    // GET api/values
    [HttpGet("{s}")]
    public ActionResult<string> GetMumblingKata(string s)
    {
      return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
    }
  }
}