using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzNetTest.Job
{
    public class DumbJob : IJob
    {
        /// <summary>  
        ///  context 可以获取当前Job的各种状态。  
        /// </summary>  
        /// <param name="context"></param>  
        public void Execute(IJobExecutionContext context)
        {

            JobDataMap dataMap = context.JobDetail.JobDataMap;

            string content = dataMap.GetString("jobSays");

            Console.WriteLine("作业执行，jobSays:" + content);
        }
    }
}
