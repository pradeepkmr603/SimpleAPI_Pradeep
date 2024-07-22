using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   public class ValuesController : ControllerBase
    {
        // GET: api/values
        [HttpGet("Getdata")]
        public IEnumerable<string> Get()
        {
            return new string[] { "pradeep1", "amar" };
        }

        //GET: api/values/5
        [HttpGet("Getname")]
        public string GetName()
        {
            return "pradeep kumar";
        }

    }
}