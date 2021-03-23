using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.DemoAPI.Models;

namespace Web.DemoAPI.Controllers
{
    public class TestController : ApiController
    {
        [Route("api/GetData")]
        [HttpGet]
        public string GetData()
        {
            return "dhđgfgfg";
        }

        [Route("api/GetDataDetail/{name}")]
        [HttpGet]
        public string GetDataDetail(string name)
        {
            return name;
        }
        [Route("api/PostData/{name}")]
        [HttpPost]
        public Data PostData([FromUri]string name,  Data data)
        {
            return data;
        }
    }
    
}
