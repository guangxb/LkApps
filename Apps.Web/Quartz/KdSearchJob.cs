using Apps.Common;
using Apps.Models;
using Newtonsoft.Json;
using Quartz;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Apps.Web.Quartz
{
    public class KdSearchJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            using (DBContainer dbContext = new DBContainer())
            {
                DbSet<Spm_ExpressInfo> dbSet0 = dbContext.Set<Spm_ExpressInfo>();
                DbSet<Spm_TracesInfo> dbSet1 = dbContext.Set<Spm_TracesInfo>();
                KdApiSearchHelper search = new KdApiSearchHelper();
                DateTime searchTime0 = DateTime.Now.AddDays(-3);
                DateTime searchTime1 = DateTime.Now.AddDays(-14);
                DateTime searchTime = DateTime.Now.AddDays(-1);
                DateTime searchTime2 = DateTime.Now.AddDays(-14);
                //DateTime searchTime = DateTime.Now.AddDays(-15);
                //DateTime searchTime2 = DateTime.Now.AddDays(-16);
                //spmContainer
                //var eiContainer = dbSet0.Where(e => e.ShipperCode != "HHTT:天天快递" && !e.ShipperCode.Contains("LK:") && (e.ActualShipDateTime < searchTime && e.ActualShipDateTime > searchTime2 && (e.State == "0" || e.State == "900")));
                var eiContainer = dbSet0.Where(e => e.ShipperCode != "HHTT:天天快递" && !e.ShipperCode.Contains("LK:") && ((e.ActualShipDateTime < searchTime && e.ActualShipDateTime > searchTime2 && (e.State == "0" || e.State == "900")) || (e.ActualShipDateTime < searchTime0 && e.ActualShipDateTime > searchTime1 && (e.State == "2"))));
                //var eiContainer = dbSet0.Where(e => e.ShipperCode != "HHTT:天天快递" && !e.ShipperCode.Contains("LK:") && ((e.ActualShipDateTime < searchTime && e.ActualShipDateTime > searchTime2 && (e.State == "0" || e.State == "900")) || (e.ActualShipDateTime < searchTime0 && e.ActualShipDateTime > searchTime1 && (e.State == "2"))));
                //var eiContainer = dbSet0.Where(e => e.TrackingNumber == "884997150832865860" || e.TrackingNumber == "884997154424198193" || e.TrackingNumber == "884997139039592133" || e.TrackingNumber == "884997158451108294");
                int count = eiContainer.Count();
                List<Spm_TracesInfo> addList = new List<Spm_TracesInfo>();
                List<Spm_ExpressInfo> modifyList = new List<Spm_ExpressInfo>();
                List<Spm_TracesInfo> traceList = dbSet1.ToList();

                ParallelOptions parallelOptions = new ParallelOptions();
                parallelOptions.MaxDegreeOfParallelism = 6;

                Parallel.ForEach(eiContainer, parallelOptions, item =>
                {
                    //foreach (var item in eiContainer) {
                    try
                    {
                        Apps.Models.Common.KdSearchModel result = JsonConvert.DeserializeObject<Apps.Models.Common.KdSearchModel>(search.getOrderTracesByJson(item.TrackingNumber, item.ShipperCode.Split(':')[0]));
                        if (result.Success)
                        {
                            //Spm_ExpressInfo exInfo = dbContext.Set<Spm_ExpressInfo>().Where(e=>e.TrackingNumber == item.TrackingNumber).FirstOrDefault();

                            modifyList.Add(new Spm_ExpressInfo() { Id = item.Id, State = result.State });
                            //if (exInfo != null)
                            //{
                            //exInfo.State = result.State;
                            //    exInfo.EBusinessID = result.EBusinessID;
                            //    exInfo.OrderCode = result.OrderCode;
                            //    exInfo.Reason = result.Reason;
                            //    exInfo.Success = result.Success;

                            //dbContext.Entry<Spm_ExpressInfo>(exInfo).State = EntityState.Modified;

                            if (result.Traces.Count() > 0)
                            {

                                List<Spm_TracesInfo> ti = traceList.Where(t => t.ExInfoId == item.Id).OrderByDescending(a => a.AcceptTime).ToList();
                                //List<Spm_TracesInfoModel> ti = serviceSession.Spm_TracesInfo.GetList(t => t.ExInfoId == exInfo.Id).OrderByDescending(a => a.AcceptTime).ToList();
                                foreach (var tc in result.Traces)
                                {
                                    if (ti.Count() > 0)
                                    {
                                        if ((tc.AcceptTime > ti.First().AcceptTime))
                                        {
                                            Spm_TracesInfo m = new Spm_TracesInfo()
                                            {
                                                Id = ResultHelper.NewId,
                                                ExInfoId = item.Id,
                                                AcceptTime = tc.AcceptTime,
                                                AcceptStation = tc.AcceptStation,
                                            };
                                            addList.Add(m);
                                            //dbContext.Entry<Spm_TracesInfo>(m).State = EntityState.Added;
                                        }
                                    }
                                    else
                                    {
                                        Spm_TracesInfo m = new Spm_TracesInfo()
                                        {
                                            Id = ResultHelper.NewId,
                                            ExInfoId = item.Id,
                                            AcceptTime = tc.AcceptTime,
                                            AcceptStation = tc.AcceptStation,
                                        };
                                        addList.Add(m);
                                        //dbContext.Entry<Spm_TracesInfo>(m).State = EntityState.Added;
                                    }
                                }
                            }
                        }
                        //}
                    }
                    catch
                    {
                    }

                });
                if (modifyList.Count() > 0)
                {
                    foreach (var item in modifyList)
                    {
                        dbSet0.Where(e => e.Id == item.Id).First().State = item.State;
                    }
                }
                if (addList.Count() > 0)
                {
                    dbSet1.AddRange(addList);
                }
                dbContext.SaveChanges();
                //dbContext.SaveChanges();
            }
        }
    }
}