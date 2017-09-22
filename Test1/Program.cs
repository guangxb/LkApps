using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));
            HostFactory.Run(x =>
            {
                //x.UseLog4Net();

                //x.Service<ServiceRunner>();

                //x.SetDescription("QuartzDemo1服务描述");
                //x.SetDisplayName("QuartzDemo1服务显示名称");
                //x.SetServiceName("QuartzDemo1服务名称");

                //x.EnablePauseAndContinue();



            });
        }
    }
}
