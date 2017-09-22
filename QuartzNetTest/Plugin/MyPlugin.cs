using Quartz;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzNetTest.Plugin
{
    public class MyPlugin : ISchedulerPlugin
    {
        public void Initialize(string pluginName, IScheduler sched)
        {
            Console.WriteLine("实例化");
        }
        public void Start()
        {
            Console.WriteLine("启动");
        }
        public void Shutdown()
        {
            Console.WriteLine("关闭");
        }
    }
}
