using Apps.Models;
using Apps.Models.Common.Trackingmore;
using Newtonsoft.Json;
using Quartz;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Web;

namespace Apps.Web.Quartz
{
    public class TrackingMoreSearchJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            using (DBContainer dbContext = new DBContainer())
            {
                DbSet<Spm_ExpressInfo> dbSet0 = dbContext.Set<Spm_ExpressInfo>();
                DbSet<Spm_TracesInfo> dbSet1 = dbContext.Set<Spm_TracesInfo>();
                DbSet<Spm_LastTime> dbSet2 = dbContext.Set<Spm_LastTime>();

                //DateTime time = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                //if (dbSet2.Find("Trackingmore0").ActualShipDateTime == time)
                //{
                //}
                //else {
                //}
                

                DateTime time0 = DateTime.Now.AddDays(-1);

                List<Spm_ExpressInfo> eiContainer = dbSet0.Where(e => e.ShipperCode == "HHTT:天天快递" && e.ActualShipDateTime >= time0 && (e.State == "900" || e.State == "-1" || e.State == "0" || e.State == "1")).OrderByDescending(e => e.ActualShipDateTime).Take(111).ToList();

                List<SubscribeModel> sbData0 = new List<SubscribeModel>();
                foreach (var item in eiContainer) {
                    sbData0.Add(new SubscribeModel { tracking_number = item.TrackingNumber,carrier_code ="ttkd" });
                }

                int count = sbData0.Count() / 40;
                for (int i = 0; i <= count; i++)
                {
                    int ct = i * 40;
                    string requestdata;
                    IEnumerable<SubscribeModel> sbData = new List<SubscribeModel>();
                    if (i == count)
                    {
                        int tk = sbData0.Count() % 40;
                        sbData = sbData0.Skip(ct).Take(tk);
                    }
                    else
                    {
                        sbData = sbData0.Skip(ct).Take(40);
                    }

                    try
                    {
                        //string requestdata = "[{\"tracking_number\": \"1047435554520\",\"carrier_code\":\"china-ems\"},{\"tracking_number\": \"1047435555420\",\"carrier_code\":\"china-ems\"}]";
                        if (sbData.Count() > 0)
                        {
                            requestdata = JsonConvert.SerializeObject(sbData);

                            string result = new KdHelper.TrackingMoreHelper1().getOrderTracesByJson(requestdata, null, "batch");

                            TrackingBatchModel tbm = JsonConvert.DeserializeObject<TrackingBatchModel>(result);
                            if (tbm != null && tbm.data.errors != null)
                            {
                                foreach (var item in tbm.data.errors)
                                {
                                    if (item.code != 4016)
                                    {
                                        dbSet0.Where(o => o.TrackingNumber == item.tracking_number).First().State = "-1";
                                    }
                                }
                            }
                        }
                        Thread.Sleep(200);
                    }
                    catch
                    {
                        foreach (var item in sbData)
                        {
                            dbSet0.Where(o => o.TrackingNumber == item.tracking_number).First().State = "-1";
                        }
                        Thread.Sleep(200);
                    }
                }
            }
        }

    }
}