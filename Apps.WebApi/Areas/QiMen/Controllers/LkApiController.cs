using Apps.WebApi.Areas.QiMen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;

namespace Apps.WebApi.Areas.QiMen.Controllers
{
    public class LkApiController : ApiController
    {
        // GET: api/LkApi
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET: api/LkApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LkApi
        public response Post([FromBody]string value)
        {
            response result = new response() {code="123",entryOrderId="123",flag="success",message="123" };
            return result;
        }

        // PUT: api/LkApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LkApi/5
        public void Delete(int id)
        {
        }
    }
}
