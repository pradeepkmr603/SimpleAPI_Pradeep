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
           [HttpGet("list")] 
        // GET: api/values
        public IEnumerable<string> Get() 
        {
            return new string[] { "sandeep karan", "papa need your blessing" };
        }
       [HttpGet("lis")]
        // GET: api/values/5
        public string Get(int id)
        {
            return "sandeep";
        }
        //test
        // // GET: api/values
        // [HttpGet("Getdata")]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "pradeep1", "amar" };
        // }

        // //GET: api/values/5
        // [HttpGet("Getname")]
        // public string GetName()
        // {
        //     return "pradeep kumar";
        // }

    }
}