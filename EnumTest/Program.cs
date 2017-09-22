using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Days today = Days.Monday;
            int dayNumber = (int)today;
            Console.WriteLine("{0} is day number #{1}.", today, dayNumber);
            Console.WriteLine(Days.Monday.ToString());

            Months thisMonth = Months.Dec;
            byte monthNumber = (byte)thisMonth;
            Console.WriteLine("{0} is month number #{1}.", thisMonth, monthNumber);
            Console.WriteLine(Months.Dec.ToString());
            Console.ReadKey();
        }
    }

    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    enum Months : byte { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
}
