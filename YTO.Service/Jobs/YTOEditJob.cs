using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YTO.Service.Models;

namespace YTO.Service.Jobs
{
    public class YTOEditJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            using (var ctx = new SCVEntities()) {
                var headers = ctx.SHIPMENT_HEADER.Where(s => s.CARRIER == "YTO" && s.SHIPMENT_CATEGORY5 == null && s.TRAILING_STS != 900).ToList();

                foreach (var item in headers) {
                    string matchValue = regexMatchString(item.USER_DEF6);
                    if (!string.IsNullOrEmpty(matchValue)) {
                        item.SHIPMENT_CATEGORY5 = matchValue;
                    }
                    
                }
                ctx.SaveChanges();
            }
        }

        private static string regexMatchString(string input) {

            if (string.IsNullOrEmpty(input)) {
                return null;
            }

            //Regex rx1 = new Regex(@"^[\u4e00-\u9fa5]+$", RegexOptions.Compiled);
            Regex rx2 = new Regex(@"^\d{3}-(\d{3}) \d{3}$", RegexOptions.Compiled);
            Regex rx3 = new Regex(@"^\d{3}-(\d{3})-\d{3}$", RegexOptions.Compiled);
            //Regex rx4 = new Regex(@"^\d{3}$", RegexOptions.Compiled);

            //if (rx1.IsMatch(input) || rx4.IsMatch(input))
            //{
            //    return input;
            //}

            if (rx2.IsMatch(input))
            {
                return rx2.Match(input).Groups[1].Value;
            }

            if (rx3.IsMatch(input))
            {
                return rx3.Match(input).Groups[1].Value;
            }

            return "";
        }

    }
}
