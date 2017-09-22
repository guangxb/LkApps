using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Job
{
    public class TestJob:IJob
    {
        //private readonly ILog _logger = LogManager.GetLogger(typeof(TestJob));

        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("TestJob测试");
            //_logger.InfoFormat("TestJob测试");
        }
    }
}
