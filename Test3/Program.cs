using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            DateTime time1 = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")).AddMinutes(5);
            DateTime time = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
            Console.WriteLine(time);
            Console.WriteLine(time1);
            Console.ReadKey();
        }
    }
}
