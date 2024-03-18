using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestAPI.Controllers
{
    [RoutePrefix("api/Test")]
    public class TestController : ApiController
    {
        [HttpGet]
        [ActionName("GetData")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Value1", "Values2" };
        }
    }
}
