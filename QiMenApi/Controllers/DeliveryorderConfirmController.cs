using CustomHttpClient.Request;
using CustomHttpClient.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QiMenApi.Controllers
{
    public class DeliveryorderConfirmController : ApiController
    {
        // GET: api/DeliveryorderConfirm
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DeliveryorderConfirm/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DeliveryorderConfirm
        public DeliveryorderConfirmResponse Post([FromBody]DeliveryorderConfirmRequest value,string customerId)
        {
            DeliveryorderConfirmResponse response = new DeliveryorderConfirmResponse();
            response.Message = "测试通过";
            response.Flag = "success";
            response.Code = "1";
            return response;
        }

        // PUT: api/DeliveryorderConfirm/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DeliveryorderConfirm/5
        public void Delete(int id)
        {
        }
    }
}
