using Apps.Common.WeightHelp;
using Apps.Core;
using Apps.Web.Core;
using Apps.Web.Quartz;
using Apps.Web.Quartz.App_Start;
using log4net;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Apps.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //IScheduler sched0;
        IScheduler sched;
        private const string DummyPageUrl = "http://10.10.10.100:62214/";
        private const string DummyCacheItemKey = "LinKongAdmin";

        public override void Init()
        {
            base.Init();
            this.AcquireRequestState += Global_AcquireRequestState;
        }

        private void RegisterCacheEntry()
        {
            if (null != HttpContext.Current.Cache[DummyCacheItemKey]) return;
            HttpContext.Current.Cache.Add(DummyCacheItemKey, "AdminObj", null, DateTime.MaxValue,
                TimeSpan.FromMinutes(13), CacheItemPriority.NotRemovable,
                new CacheItemRemovedCallback(CacheItemRemovedCallback));
        }

        public void CacheItemRemovedCallback(string key, object value, CacheItemRemovedReason reason)
        {
            HitPage();
        }

        private void HitPage()
        {
            System.Net.WebClient client = new System.Net.WebClient();
            client.DownloadData(DummyPageUrl);
        }

        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.Url.ToString() == DummyPageUrl)
            {
                RegisterCacheEntry();
            }
        }

        private void Global_AcquireRequestState(object sender, EventArgs e)
        {
            OperationContext OpeCur = OperationContext.Current;
            if (HttpContext.Current.Session == null)
            {
                return;
            }
            
            if (OpeCur.AccountNow == null|| OpeCur.AccountNow.UserName == null)
            {
                return;
            }
            string userName = OpeCur.AccountNow.UserName;
            using (var client = RedisManager.ClientManager.GetClient())
            {
                string redisSessionId = client.Get<string>(OperationContext.USERNAME_SESSIONID + userName);
                if (redisSessionId != null && redisSessionId != Session.SessionID)
                {
                    Session.Clear();
                    Session.Abandon();
                    //HttpContext.Current.Response.Redirect("/Account/Index");
                }
            }
           
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            //UnityConfig.RegisterComponents();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            log4net.Config.XmlConfigurator.Configure();
            ISchedulerFactory schedf = new StdSchedulerFactory();
            sched = schedf.GetScheduler();
            IJobDetail job1 = JobBuilder.Create<TrackingMoreResetCountJob>().Build();
            IJobDetail job0 = JobBuilder.Create<KdSearchJob>().Build();//"0 0 0,12 * * ?" //"0 */30 * * * ?"
            IJobDetail job = JobBuilder.Create<SpmExpressJob>().Build();//0 0 0,12,18,21 * * ? //"0 7 7,8 * * ?"//0 17 8 * * ?
            ITrigger trigger1 = TriggerBuilder.Create().WithCronSchedule("0 2 0 * * ?").Build();//0 */15 * * * ?"
            ITrigger trigger0 = TriggerBuilder.Create().WithCronSchedule("0 2 8 * * ?").Build();
            ITrigger trigger = TriggerBuilder.Create().WithCronSchedule("0 */15 * * * ?").Build();
            sched.ScheduleJob(job1, trigger1);
            sched.ScheduleJob(job0, trigger0);
            sched.ScheduleJob(job, trigger);
            //sched.Start();
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //ILog log = LogManager.GetLogger(typeof(Global));

            ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            log.Error("系统发生未处理异常", Context.Error);
        }

        protected void Application_End(object sender, EventArgs e)
        {
            //   在应用程序关闭时运行的代码
            if (sched != null)
            {
                sched.Shutdown(true);
            }
        }

    }
}
