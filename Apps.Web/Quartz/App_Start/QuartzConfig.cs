using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apps.Web.Quartz.App_Start
{
    public class QuartzConfig
    {
        public static void RegisterQuartz()
        {
            //HostFactory.Run(x =>
            //{

            //    x.Service<ServiceRunner>();

            //    x.SetDescription("Quartz定时从SCV中获取运单");
            //    x.SetDisplayName("Quartz获取运单");
            //    x.SetServiceName("Quartz获取运单");

            //    x.EnablePauseAndContinue();
            //});

            //IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            //scheduler.Start();

            ISchedulerFactory schedf = new StdSchedulerFactory();
            IScheduler sched = schedf.GetScheduler();
            //2.创建出来一个具体的作业
            IJobDetail job = JobBuilder.Create<SpmExpressJob>().Build();
            //3.创建并配置一个触发器
            //ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create().WithSimpleSchedule(x => x.WithIntervalInHours(2).
            //WithRepeatCount(int.MaxValue)).Build();

            ITrigger trigger = TriggerBuilder.Create().WithCronSchedule("0 */10 * * * ?").Build();
            //4.加入作业调度池中
            sched.ScheduleJob(job, trigger);
            sched.Start();
        }
    }
}