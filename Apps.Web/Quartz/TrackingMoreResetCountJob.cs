using Apps.Models;
using Quartz;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Apps.Web.Quartz
{
    public class TrackingMoreResetCountJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            using (DBContainer dbContext = new DBContainer())
            {
                DateTime resetTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")).AddMinutes(10);
                if (DateTime.Now < resetTime)
                {
                    DbSet<Spm_LastTime> dbSet0 = dbContext.Set<Spm_LastTime>();
                    Spm_LastTime sl0 = dbSet0.Find("Trackingmore0");
                    Spm_LastTime sl1 = dbSet0.Find("Trackingmore1");
                    Spm_LastTime sl2 = dbSet0.Find("Trackingmore2");
                    Spm_LastTime sl3 = dbSet0.Find("Trackingmore3");

                    Spm_LastTime sl4 = dbSet0.Find("Trackingmore4");
                    Spm_LastTime sl5 = dbSet0.Find("Trackingmore5");

                    sl0.ActualShipDateTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                    sl0.Kd100Flag = 200;

                    sl1.ActualShipDateTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                    sl1.Kd100Flag = 500;

                    sl2.ActualShipDateTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                    sl2.Kd100Flag = 500;

                    sl3.ActualShipDateTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                    sl3.Kd100Flag = 500;

                    sl4.ActualShipDateTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                    sl4.Kd100Flag = 500;

                    sl5.ActualShipDateTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                    sl5.Kd100Flag = 500;

                    dbContext.SaveChanges();
                }
            }
        }
    }
}