using QiMenApi.Common;
using QiMenApi.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Routing;

namespace QiMenApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        //http://localhost:62215/api/QiMenApi
        //private const string DummyPageUrl = "http://10.10.10.100:62215/api/QiMenApi";
        //private const string DummyCacheItemKey = "QiMenApi";
        protected void Application_Start()
        {
           
            //var xml = GlobalConfiguration.Configuration.Formatters.XmlFormatter;
            //GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerSelector), new CustomHttpControllerSelector());
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //System.Timers.Timer t = new System.Timers.Timer(600000);
            //t.Elapsed += (o, e) => new QimenApiConfirm().Excute();
            //t.Start();
        }

        private void RegisterCacheEntry()
        {
            //if (null != HttpContext.Current.Cache[DummyCacheItemKey]) return;
            //HttpContext.Current.Cache.Add(DummyCacheItemKey, "QiMenObj", null, DateTime.MaxValue,
            //    TimeSpan.FromMinutes(13), CacheItemPriority.NotRemovable,
            //    new CacheItemRemovedCallback(CacheItemRemovedCallback));
        }

        //public void CacheItemRemovedCallback(string key, object value, CacheItemRemovedReason reason)
        //{
        //    HitPage();
        //}

        //private void HitPage()
        //{
        //    System.Net.WebClient client = new System.Net.WebClient();
        //    client.DownloadData(DummyPageUrl);
        //}
        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            //if (HttpContext.Current.Request.Url.ToString() == DummyPageUrl)
            //{
            //    RegisterCacheEntry();
            //}
        }

        protected void Application_End() {

        }
        
    }
}
