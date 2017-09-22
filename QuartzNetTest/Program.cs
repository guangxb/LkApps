using Common.Logging.Configuration;
using Quartz;
using Quartz.Impl;
using QuartzNetTest.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuartzNetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 基本实例
            ////从工厂中获取一个调度器实例化  
            //IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            ////开启调度器
            //scheduler.Start();

            //IJobDetail job1 = JobBuilder.Create<HelloJob>()  //创建一个作业  
            //  .WithIdentity("作业名称", "作业组")
            //  .Build();

            //ITrigger trigger1 = TriggerBuilder.Create()
            //                          .WithIdentity("触发器名称", "触发器组")
            //                          .StartNow()                        //现在开始  
            //                          .WithSimpleSchedule(x => x         //触发时间，5秒一次。  
            //                              .WithIntervalInSeconds(5)
            //                              .RepeatForever())              //不间断重复执行  
            //                          .Build();

            //scheduler.ScheduleJob(job1, trigger1);      //把作业，触发器加入调度器。 

            ////==========例子2 (执行时 作业数据传递，时间表达式使用)===========  

            //IJobDetail job2 = JobBuilder.Create<DumbJob>()
            //                            .WithIdentity("myJob", "group1")
            //                            .UsingJobData("jobSays", "Hello World!")
            //                            .Build();


            //ITrigger trigger2 = TriggerBuilder.Create()
            //                            .WithIdentity("mytrigger", "group1")
            //                            .StartNow()
            //                            .WithCronSchedule("/5 * * ? * *")    //时间表达式，5秒一次       
            //                            .Build();


            //scheduler.ScheduleJob(job2, trigger2);

            ////scheduler.Shutdown();         //关闭调度器。 
            #endregion

            #region 简单插件案例和Listener
            var properties = new System.Collections.Specialized.NameValueCollection();
            //MyPlugin 自定义名称。    "命名空间.类名,程序名称"  
            properties["quartz.plugin.MyPlugin.type"] = "QuartzNetTest.Plugin.MyPlugin,QuartzNetTest";

            var schedulerFactory = new StdSchedulerFactory(properties);
            var scheduler = schedulerFactory.GetScheduler();

            var job = JobBuilder.Create<HelloJob>()
                .WithIdentity("myJob", "group1")
                .Build();

            var trigger = TriggerBuilder.Create()
                                .WithIdentity("mytrigger", "group1")
                                .WithCronSchedule("/2 * * ? * *")
                                .Build();

            scheduler.ScheduleJob(job, trigger);
            //添加监听器到指定的trigger  
            //scheduler.ListenerManager.AddTriggerListener(myJobListener, KeyMatcher<TriggerKey>.KeyEquals(new TriggerKey("mytrigger", "group1")));

            ////添加监听器到指定分类的所有监听器。  
            //scheduler.ListenerManager.AddTriggerListener(myJobListener, GroupMatcher<TriggerKey>.GroupEquals("myJobGroup"));  

            ////添加监听器到指定分类的所有监听器。  
            //scheduler.ListenerManager.AddTriggerListener(myJobListener, GroupMatcher<TriggerKey>.GroupEquals("myJobGroup"));  

            ////添加监听器到指定的2个分组。  
            //scheduler.ListenerManager.AddTriggerListener(myJobListener, GroupMatcher<TriggerKey>.GroupEquals("myJobGroup"), GroupMatcher<TriggerKey>.GroupEquals("myJobGroup2"));  

            ////添加监听器到所有的触发器上。  
            //scheduler.ListenerManager.AddTriggerListener(myJobListener, GroupMatcher<TriggerKey>.AnyGroup());  

            scheduler.Start();

            scheduler.Start();
            Thread.Sleep(6000);
            scheduler.Shutdown(true);
            Console.ReadLine();
            #endregion


        }
    }
}
