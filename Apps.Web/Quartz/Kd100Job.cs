using Apps.Common;
using Apps.Models;
using Apps.Models.Common;
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
    public class Kd100Job : IJob
    {


        public void Execute(IJobExecutionContext context)
        {
            using (DBContainer dbContext = new DBContainer())
            {
                DbSet<Spm_ExpressInfo> dbSet0 = dbContext.Set<Spm_ExpressInfo>();
                DbSet<Spm_TracesInfo> dbSet1 = dbContext.Set<Spm_TracesInfo>();
                DbSet<Spm_LastTime> dbSet2 = dbContext.Set<Spm_LastTime>();
                DateTime time0 = DateTime.Now.AddDays(-7);

                Spm_LastTime sl = dbSet2.Find("Kd100");
                DateTime time1 = (DateTime)sl.ActualShipDateTime;
                if (sl.Kd100Flag == 0)
                {
                    sl.Kd100Flag = 1;
                }
                else {
                    sl.Kd100Flag = 0;
                    time0 = time1;
                }
                //time0 = sl.Kd100Flag == 0 ? time0 : time1;
                //int num = (int)sl.Kd100Flag;
                //if (num < 1980)
                //{
                //    sl.Kd100Flag = num + 495;
                //}
                //else {
                //    num = 0;
                //    sl.Kd100Flag = 495;
                //}


                List<Spm_ExpressInfo> eiContainer = dbSet0.Where(e => e.ShipperCode == "HHTT:天天快递" && e.ActualShipDateTime >= time0 && (e.State == "900" || e.State == "0" || e.State == "1" || e.State == "2")).OrderBy(e => e.ActualShipDateTime).Take(950).ToList();
                sl.ActualShipDateTime = eiContainer.Last().ActualShipDateTime;
                int count = eiContainer.Count();
                foreach (var item in eiContainer)
                {
                    try
                    {
                        Kd100Model result = JsonConvert.DeserializeObject<Apps.Models.Common.Kd100Model>(Kd100Helper.orderTracesSubByJson("tiantian", item.TrackingNumber));
                        if (result.status == 1)
                        {
                            switch (result.state)
                            {
                                case 0: case 5: item.State = "2"; break;
                                case 1: item.State = "1"; break;
                                case 3: item.State = "3"; break;
                                case 2: case 4: case 6: item.State = "4"; break;
                                default:
                                    break;
                            }

                            if (result.data.Count > 0)
                            {
                                IQueryable<Spm_TracesInfo> ti = dbSet1.Where(t => t.ExInfoId == item.Id).OrderByDescending(a => a.AcceptTime);
                                foreach (var tc in result.data)
                                {
                                    if (ti.Count() > 0)
                                    {
                                        if ((tc.time > ti.First().AcceptTime))
                                        {
                                            Spm_TracesInfo m = new Spm_TracesInfo()
                                            {
                                                Id = ResultHelper.NewId,
                                                ExInfoId = item.Id,
                                                AcceptTime = tc.time,
                                                AcceptStation = tc.context,
                                            };
                                            dbSet1.Add(m);
                                        }
                                    }
                                    else
                                    {
                                        Spm_TracesInfo m = new Spm_TracesInfo()
                                        {
                                            Id = ResultHelper.NewId,
                                            ExInfoId = item.Id,
                                            AcceptTime = tc.time,
                                            AcceptStation = tc.context,
                                        };
                                        dbSet1.Add(m);
                                    }
                                }
                            }
                        }
                        else
                        {
                            
                            //int r = result.status;
                        }
                        Thread.Sleep(300);
                    }
                    catch(Exception e)
                    {
                        Thread.Sleep(300);
                        string ex = e.Message;
                        continue;
                    }
                }
                
                dbContext.SaveChanges();

            }
        }
    }
}