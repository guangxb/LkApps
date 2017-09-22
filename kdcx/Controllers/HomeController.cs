using kdcx.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kdcx.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SendPost()
        {
            //KdApiOrderDistinguish api = new KdApiOrderDistinguish();

            //string result = api.orderTracesSubByJson();
            //string urlStr = "?page=1&limit=25&created_at_min=1441314361&created_at_max=1477308420";
            string urlStr = "/ttkd/667585640475";
            //string requestData = null;
            //string urlStr = "/wishpost/885163857817158799";
            //string requestData = null;
            //https://api.trackingmore.com/v2/trackings/{carrier_code}/{tracking_number}


            List<SubscribeModel> list = new List<SubscribeModel>();

            list.Add(new SubscribeModel { tracking_number = "667575410805" ,carrier_code ="ttkd"});
            list.Add(new SubscribeModel { tracking_number = "885163857817158799", carrier_code = "yto" });
            //string requestdata = "[{\"tracking_number\": \"1047435554520\",\"carrier_code\":\"china-ems\"},{\"tracking_number\": \"1047435555420\",\"carrier_code\":\"china-ems\"}]";
            string requestdata = JsonConvert.SerializeObject(list);
            //string requestData = "{\"tracking_number\": \"667575410805\",\"carrier_code\":\"ttkd\"}";
            string result = new TrackingMoreHelper().getOrderTracesByJson(null, urlStr, "codeNumberGet");
            return View();
        }
    }

    public class SubscribeModel
    {
        public string tracking_number { get; set; }
        public string carrier_code { get; set; }
    }
}