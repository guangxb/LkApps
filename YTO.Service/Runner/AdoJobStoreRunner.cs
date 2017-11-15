using Common.Logging;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Matchers;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTO.Service.Jobs;

namespace YTO.Service.Runner
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
                IJobDetail jobDetail0 = JobBuilder.Create<YTOEditJob>().WithIdentity("job_YTOEdit", schedulerId).RequestRecovery(true).Build();
               
                ITrigger trigger0 = TriggerBuilder.Create().WithIdentity("trigger_YTOEdit", schedulerId).StartNow().WithCronSchedule("0 0/5 * * * ?").Build();
               
                scheduler.ScheduleJob(jobDetail0, trigger0);//加入到执行计划

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
