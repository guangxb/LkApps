using Apps.Models;
using QiMenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Xml;

namespace Apps.WebApi.Areas.QiMen.Controllers
{
    public class QiMenApiController : ApiController
    {
        // GET: api/LkApi
        public IEnumerable<string> Get()
        {
            //using (DBContainer context = new DBContainer())
            //{
            //    QiMen_ResponseLog log = new QiMen_ResponseLog();

            //    string result = await Request.Content.ReadAsStringAsync();

            //    log.HttpContent = result;
            //    context.QiMen_ResponseLog.Add(log);
            //    context.SaveChanges();
            //}
            return new string[] { "value1", "value2" };
        }


        // GET: api/LkApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LkApi
        public string Post()
        {
            //using (DBContainer context = new DBContainer())
            //{
            //    QiMen_RequestLog log = new QiMen_RequestLog();

            //    string body = await Request.Content.ReadAsStringAsync();
            //    string ip = ((System.Web.HttpContextWrapper)Request.Properties["MS_HttpContext"]).Request.UserHostAddress;

            //    log.Url = Request.RequestUri.AbsoluteUri;
            //    log.Ip = ip;
            //    log.CustomerId = customerId;
            //    log.RequestBody = body;
            //    context.QiMen_RequestLog.Add(log);
            //    context.SaveChanges();
            //}

            return "无匹配的 HTTP 资源";
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
