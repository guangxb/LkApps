using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzNetTest.Listener
{
    public class MyTriggerListener : ITriggerListener
    {
        private string name;

        public void TriggerComplete(ITrigger trigger, IJobExecutionContext context, SchedulerInstruction triggerInstructionCode)
        {
            Console.WriteLine("job完成时调用");
        }
        public void TriggerFired(ITrigger trigger, IJobExecutionContext context)
        {
            Console.WriteLine("job执行时调用");
        }
        public void TriggerMisfired(ITrigger trigger)
        {
            Console.WriteLine("错过触发时调用(例：线程不够用的情况下)");
        }
        public bool VetoJobExecution(ITrigger trigger, IJobExecutionContext context)
        {
            //Trigger触发后，job执行时调用本方法。true即否决，job后面不执行。  
            return false;
        }
        public string Name { get { return name; } set { name = value; } }
    }
}
