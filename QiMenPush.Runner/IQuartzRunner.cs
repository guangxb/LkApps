using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiMenPush.Runner
{
    public interface IQuartzRunner
    {
        string Name { get; }
        IScheduler Run();
    }
}
