using Common.Logging;
using QiMenPush.Jobs;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Matchers;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiMenPush.Runner
{
    public class AdoJobStoreRunner : IQuartzRunner
    {
        private static ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public string Name
        {
            get
            {
                return this.GetType().Name;
            }
        }

        /// <summary>
        /// delete job data from db
        /// </summary>
        /// <param name="scheduler"></param>
        public virtual void CleanUp(IScheduler scheduler)
        {
            _log.Warn("*************Deleting existing jobs/triggers " + DateTime.Now + "**************");
            IList<string> groups = scheduler.GetTriggerGroupNames();
            for (int i = 0; i < groups.Count; i++)
            {
                Quartz.Collection.ISet<TriggerKey> triggerKeys = scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.GroupEquals(groups[i]));
                foreach (TriggerKey key in triggerKeys)
                {
                    scheduler.UnscheduleJob(key);
                }
            }
            groups = scheduler.GetJobGroupNames();
            for (int i = 0; i < groups.Count; i++)
            {
                Quartz.Collection.ISet<JobKey> jobKeys = scheduler.GetJobKeys(GroupMatcher<JobKey>.GroupEquals(groups[i]));
                foreach (JobKey key in jobKeys)
                {
                    scheduler.DeleteJob(key);
                }
            }
        }
        public virtual IScheduler Run(bool clearJobs, bool schedulerJobs)
        {
            NameValueCollection properties = new NameValueCollection();

            //properties["quartz.scheduler.instanceName"] = "ServerScheduler";
            //properties["quartz.scheduler.instanceId"] = "instance_one";
            //properties["quartz.threadPool.type"] = "Quartz.Simpl.SimpleThreadPool, Quartz";
            //properties["quartz.threadPool.threadCount"] = "5";
            //properties["quartz.threadPool.threadPriority"] = "Normal";
            //properties["quartz.jobStore.misfireThreshold"] = "60000";
            //properties["quartz.jobStore.type"] = "Quartz.Impl.AdoJobStore.JobStoreTX, Quartz";
            //properties["quartz.jobStore.driverDelegateType"] = "Quartz.Impl.AdoJobStore.StdAdoDelegate, Quartz";
            //properties["quartz.jobStore.useProperties"] = "false";
            //properties["quartz.jobStore.dataSource"] = "default";
            //properties["quartz.jobStore.tablePrefix"] = "QRTZ_";
            //properties["quartz.jobStore.clustered"] = "true";
            //// if running MS SQL Server we need this
            //properties["quartz.jobStore.selectWithLockSQL"] = "SELECT * FROM {0}LOCKS UPDLOCK WHERE LOCK_NAME = @lockName";

            //properties["quartz.dataSource.default.connectionString"] = @"Server=V-LOZHU02;Database=JobSchedule;Trusted_Connection=True;User ID=sa; Password=!1@2$4qaz;";
            //properties["quartz.dataSource.default.provider"] = "SqlServer-20";

            ISchedulerFactory sf = new StdSchedulerFactory(properties);//根据属性获取一个调度器工厂
            IScheduler scheduler = sf.GetScheduler();//从工厂中获取一个调度器

            if (clearJobs)
            {
                CleanUp(scheduler);
            }
            _log.Info("*****************Initialization Complete " + DateTime.Now + "***************");
            if (schedulerJobs)
            {
                _log.Info("****************Scheduling jobs " + DateTime.Now + "****************");
                string schedulerId = scheduler.SchedulerInstanceId;
                //int count = 1;
                IJobDetail jobDetail0 = JobBuilder.Create<DeliveryorderConfirmJob>().WithIdentity("job_QiMenDeliveryorderConfirm", schedulerId).RequestRecovery(true).Build();
                IJobDetail jobDetail1 = JobBuilder.Create<StockoutConfirmJob>().WithIdentity("job_QiMenStockoutConfirm", schedulerId).RequestRecovery(true).Build();
                IJobDetail jobDetail2 = JobBuilder.Create<EntryorderConfirmJob>().WithIdentity("job_QiMenEntryorderConfirm", schedulerId).RequestRecovery(true).Build();
                IJobDetail jobDetail3 = JobBuilder.Create<ReturnorderConfirmJob>().WithIdentity("job_QiMenReturnorderConfirm", schedulerId).RequestRecovery(true).Build();
                //ITrigger trigger = TriggerBuilder.Create().WithIdentity("trigger_" + count, schedulerId).StartNow().WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever()).Build();//现在开始,触发时间，5秒一次,不间断重复执行 
                ITrigger trigger0 = TriggerBuilder.Create().WithIdentity("trigger_QiMenDeliveryorderConfirm", schedulerId).StartNow().WithCronSchedule("0 0/10 * * * ?").Build();  
                ITrigger trigger1 = TriggerBuilder.Create().WithIdentity("trigger_QiMenStockoutConfirm", schedulerId).StartNow().WithCronSchedule("0 0/15 * * * ?").Build();
                ITrigger trigger2 = TriggerBuilder.Create().WithIdentity("trigger_QiMenEntryorderConfirm", schedulerId).StartNow().WithCronSchedule("0 0/10 * * * ?").Build();
                ITrigger trigger3 = TriggerBuilder.Create().WithIdentity("trigger_QiMenReturnorderConfirm", schedulerId).StartNow().WithCronSchedule("0 0/15 * * * ?").Build();
                scheduler.ScheduleJob(jobDetail0, trigger0);//加入到执行计划
                scheduler.ScheduleJob(jobDetail1, trigger1);
                scheduler.ScheduleJob(jobDetail2, trigger2);
                scheduler.ScheduleJob(jobDetail3, trigger3);

                //count++;
            }
            //scheduler.Start();//开启调度器
            return scheduler;
        }

        public IScheduler Run()
        {
            bool clearJobs = true;
            bool scheduleJobs = true;
            return this.Run(clearJobs, scheduleJobs);
        }
    }
}
