using Apps.Common;
using Apps.IService;
using Apps.Models.Common;
using Apps.Models.Spm;
using Apps.Web.Core;
using Newtonsoft.Json;
using Quartz;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Apps.Common.Distinct.ext;
using Apps.IService.SCV;
using Apps.Models;
using log4net;
using System.Data.Entity;
using System.Threading.Tasks;
using Apps.Models.Common.Trackingmore;
using System.Threading;

namespace Apps.Web.Quartz
{
    public class SpmExpressJob : IJob
    {
        //ValidationErrors error = new ValidationErrors();

        public void Execute(IJobExecutionContext context)
        {
            //IServiceSession serviceSession = DI.GetObject<IService.IServiceSession>("ServiceSession");
            //ISCVServiceSession sserviceSession = DI.GetObject<IService.SCV.ISCVServiceSession>("SCVServiceSession");


            using (SCVDBContainer _SCVdbContext = new SCVDBContainer())
            using (DBContainer dbContext = new DBContainer())
            {
                DbSet<Spm_ExpressInfo> dbSet = dbContext.Set<Spm_ExpressInfo>();
                DbSet<Spm_LastTime> dbSet0 = dbContext.Set<Spm_LastTime>();
                Spm_LastTime sl = dbSet0.Find("1");
                Spm_LastTime sl0 = dbSet0.Find("Trackingmore0");
                Spm_LastTime sl1 = dbSet0.Find("Trackingmore1");
                Spm_LastTime sl2 = dbSet0.Find("Trackingmore2");
                Spm_LastTime sl3 = dbSet0.Find("Trackingmore3");
                Spm_LastTime sl4 = dbSet0.Find("Trackingmore4");
                Spm_LastTime sl5 = dbSet0.Find("Trackingmore5");

                int num0 = (int)sl0.Kd100Flag;
                int num1 = (int)sl1.Kd100Flag;
                int num2 = (int)sl2.Kd100Flag;
                int num3 = (int)sl3.Kd100Flag;
                int num4 = (int)sl4.Kd100Flag;
                int num5 = (int)sl5.Kd100Flag;

                DateTime lastTime = ((DateTime)sl.ActualShipDateTime).AddMinutes(-5);

                //DateTime lastTime = DateTime.Parse("2017-05-08 00:00:00.000");

                //IQueryable spmContainer;
                //------------------
                //DateTime time1 = DateTime.Now.AddHours(-60);
                //DateTime time2 = DateTime.Now.AddHours(-45);
                //-------------------

                var spmContainer =
                   (
                       from h in _SCVdbContext.SHIPMENT_HEADER
                       join c in _SCVdbContext.SHIPPING_CONTAINER
                       on h.INTERNAL_SHIPMENT_NUM equals c.INTERNAL_SHIPMENT_NUM
                       where h.TRAILING_STS == 900 && h.ACTUAL_SHIP_DATE_TIME >= lastTime
                       && c.PARENT == 0 && c.STATUS == 900
                       select new { h, c }
                             ).Distinct(o => o.c.TRACKING_NUMBER).OrderByDescending(a => a.h.ACTUAL_SHIP_DATE_TIME).ToList();
                //Distinct(o => o.c.TRACKING_NUMBER).

                //var spmContainer = _SCVdbContext.Set<SHIPPING_CONTAINER>().Where(s => s.PARENT == 0 && s.STATUS == 900 && s.OQC_END_DATE_TIME > lastTime).OrderByDescending(o => o.OQC_END_DATE_TIME);
                //var spmContainer = _SCVdbContext.Set<SHIPPING_CONTAINER>().Where(s => s.PARENT == 0 && s.STATUS == 900 && s.OQC_END_DATE_TIME > lastTime).OrderByDescending(o => o.OQC_END_DATE_TIME);
                //KdApiOrderDistinguish orderDistinguish = new KdApiOrderDistinguish();
                //int spmCount = spmContainer.Count();

                List<Spm_ExpressInfo> exInfoList = dbSet.ToList();
                List<Spm_ExpressInfo> addList = new List<Spm_ExpressInfo>();
                List<SubscribeModel> ttList = new List<SubscribeModel>();


                ParallelOptions parallelOptions = new ParallelOptions();
                parallelOptions.MaxDegreeOfParallelism = 6;
                System.Object lockThis = new System.Object();

                Parallel.ForEach(spmContainer, parallelOptions, item =>
                {
                    KdApiSubscribe subscribe = new KdApiSubscribe();
                    //Dictionary<string, string> dic = OrderIdentification.Distinguish(item.h.CARRIER);

                    //if (dic["Code"] != "LK")
                    //{
                    //    try
                    //    {

                    //        KdApiSubscribeModel resultB = JsonConvert.DeserializeObject<KdApiSubscribeModel>(subscribe.orderTracesSubByJson(item.c.TRACKING_NUMBER, dic["Code"]));
                    //        if (resultB.Success)
                    //        {

                    //        }
                    //    }
                    //    catch (Exception ex)
                    //    {

                    //        ILog log = LogManager.GetLogger(typeof(SpmExpressJob));
                    //        log.Error("订阅快递鸟出错", ex);
                    //    }
                    //}

                    //int count;
                    //using (DBContainer tempC = new DBContainer())
                    //{
                    //    count = tempC.Set<Spm_ExpressInfo>().Where(s => s.TrackingNumber == item.c.TRACKING_NUMBER).Count();
                    //}
                    if (exInfoList.Where(s => s.TrackingNumber == item.c.TRACKING_NUMBER).Count() <= 0)
                    //if (count <= 0)
                    {
                        Spm_ExpressInfo eModel = new Spm_ExpressInfo()
                        {
                            Id = ResultHelper.NewId,
                            ActualShipDateTime = (DateTime)item.h.ACTUAL_SHIP_DATE_TIME,
                            TrackingNumber = item.c.TRACKING_NUMBER,
                            Company = item.h.COMPANY,
                            State = item.c.STATUS.ToString(),
                            ShipmentId = item.c.SHIPMENT_ID,
                            DateTimeStamp = item.c.DATE_TIME_STAMP,
                            PushTime = DateTime.Now,
                        };

                        Dictionary<string, string> dic = OrderIdentification.Distinguish(item.h.CARRIER);

                        if (dic["Code"] != "LK")
                        {
                            if (dic["Code"] == "HHTT")
                            {
                                ttList.Add(new SubscribeModel
                                {
                                    tracking_number = item.c.TRACKING_NUMBER
                                    ,
                                    carrier_code = "ttkd"
                                });
                            }
                            try
                            {

                                KdApiSubscribeModel resultB = JsonConvert.DeserializeObject<KdApiSubscribeModel>(subscribe.orderTracesSubByJson(item.c.TRACKING_NUMBER, dic["Code"]));
                                if (resultB.Success)
                                {
                                    eModel.ShipperCode = dic["Code"] + ":" + dic["Name"];
                                }
                                else
                                {
                                    eModel.ShipperCode = dic["Code"] + ":" + dic["Name"];
                                    eModel.State = "-1";
                                }

                            }
                            catch (Exception ex)
                            {
                                eModel.State = "-1";
                                eModel.ShipperCode = dic["Code"] + ":" + dic["Name"];
                                ILog log = LogManager.GetLogger(typeof(SpmExpressJob));
                                log.Error("订阅出错", ex);
                            }
                        }
                        else
                        {
                            eModel.ShipperCode = dic["Code"] + ":" + dic["Name"];
                        }
                        //dbSet.Add(eModel);
                        lock (lockThis)
                        {
                            addList.Add(eModel);
                        }
                        //dbContext.Entry<Spm_ExpressInfo>(eModel).State = EntityState.Added;
                    }
                });



                if (ttList.Count() > 0)
                {
                    int count = ttList.Count() / 40;
                    for (int i = 0; i <= count; i++)
                    {
                        int ct = i * 40;
                        string requestdata;
                        IEnumerable<SubscribeModel> sbData = new List<SubscribeModel>();
                        if (i == count)
                        {
                            int tk = ttList.Count() % 40;
                            sbData = ttList.Skip(ct).Take(tk);
                        }
                        else
                        {
                            sbData = ttList.Skip(ct).Take(40);
                        }

                        try
                        {
                            int requestCount = sbData.Count();
                            //string requestdata = "[{\"tracking_number\": \"1047435554520\",\"carrier_code\":\"china-ems\"},{\"tracking_number\": \"1047435555420\",\"carrier_code\":\"china-ems\"}]";
                            if (requestCount > 0)
                            {
                                requestdata = JsonConvert.SerializeObject(sbData);
                                string result = null;
                                if (num0 >= requestCount)
                                {
                                    num0 -= requestCount;
                                    result = new KdHelper.TrackingMoreHelper0().getOrderTracesByJson(requestdata, null, "batch");
                                }
                                else if (num1 >= requestCount)
                                {
                                    num1 -= requestCount;
                                    result = new KdHelper.TrackingMoreHelper1().getOrderTracesByJson(requestdata, null, "batch");
                                }
                                else if (num2 >= requestCount)
                                {
                                    num2 -= requestCount;
                                    result = new KdHelper.TrackingMoreHelper2().getOrderTracesByJson(requestdata, null, "batch");
                                }
                                else if (num3 >= requestCount)
                                {
                                    num3 -= requestCount;
                                    result = new KdHelper.TrackingMoreHelper3().getOrderTracesByJson(requestdata, null, "batch");
                                }
                                else if (num4 >= requestCount)
                                {
                                    num4 -= requestCount;
                                    result = new KdHelper.TrackingMoreHelper4().getOrderTracesByJson(requestdata, null, "batch");
                                }
                                else if (num5 >= requestCount)
                                {
                                    num5 -= requestCount;
                                    result = new KdHelper.TrackingMoreHelper5().getOrderTracesByJson(requestdata, null, "batch");
                                }
                                if (!string.IsNullOrEmpty(result))
                                {
                                    TrackingBatchModel tbm = JsonConvert.DeserializeObject<TrackingBatchModel>(result);
                                    if (tbm != null && tbm.data.errors != null)
                                    {
                                        foreach (var item in tbm.data.errors)
                                        {
                                            if (item.code != 4016)
                                            {
                                                addList.Where(o => o.TrackingNumber == item.tracking_number).First().State = "-1";
                                                //dbSet.Where(o => o.TrackingNumber == item.tracking_number).First().State = "-1";
                                            }
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
                                addList.Where(o => o.TrackingNumber == item.tracking_number).First().State = "-1";
                                //dbSet.Where(o => o.TrackingNumber == item.tracking_number).First().State = "-1";
                            }
                            Thread.Sleep(200);
                        }
                    }
                }

                if (spmContainer.Count() > 0)
                {
                    //foreach (var item in spmContainer)
                    //{
                    //}
                    dbSet.AddRange(addList);
                    //foreach (var item in addList) {
                    //    dbSet.AddRange(list);
                    //}
                    sl.ActualShipDateTime = (DateTime)spmContainer.First().h.ACTUAL_SHIP_DATE_TIME;
                }


                List<Spm_ExpressInfo> dy0 = dbSet.Where(o => o.State == "-1" && o.ShipperCode == "HHTT:天天快递").ToList();

                //IQueryable<Spm_ExpressInfo> dy0 = dbSet.Where(o => o.State == "-1" && o.ShipperCode == "HHTT:天天快递");
                if (dy0.Count() > 0)
                {
                    List<SubscribeModel> sbData0 = new List<SubscribeModel>();
                    foreach (var item in dy0)
                    {
                        sbData0.Add(new SubscribeModel { tracking_number = item.TrackingNumber, carrier_code = "ttkd" });
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
                            int requestCount = sbData.Count();
                            //string requestdata = "[{\"tracking_number\": \"1047435554520\",\"carrier_code\":\"china-ems\"},{\"tracking_number\": \"1047435555420\",\"carrier_code\":\"china-ems\"}]";
                            if (requestCount > 0)
                            {
                                requestdata = JsonConvert.SerializeObject(sbData);
                                string result = null;
                                if (num0 >= requestCount)
                                {
                                    num0 -= requestCount;
                                    result = new KdHelper.TrackingMoreHelper0().getOrderTracesByJson(requestdata, null, "batch");
                                }
                                else if (num1 >= requestCount)
                                {
                                    num1 -= requestCount;
                                    result = new KdHelper.TrackingMoreHelper1().getOrderTracesByJson(requestdata, null, "batch");
                                }
                                else if (num2 >= requestCount)
                                {
                                    num2 -= requestCount;
                                    result = new KdHelper.TrackingMoreHelper2().getOrderTracesByJson(requestdata, null, "batch");
                                }
                                else if (num3 >= requestCount)
                                {
                                    num3 -= requestCount;
                                    result = new KdHelper.TrackingMoreHelper3().getOrderTracesByJson(requestdata, null, "batch");
                                }
                                else if (num4 >= requestCount)
                                {
                                    num4 -= requestCount;
                                    result = new KdHelper.TrackingMoreHelper4().getOrderTracesByJson(requestdata, null, "batch");
                                }
                                else if (num5 >= requestCount)
                                {
                                    num5 -= requestCount;
                                    result = new KdHelper.TrackingMoreHelper5().getOrderTracesByJson(requestdata, null, "batch");
                                }
                                if (!string.IsNullOrEmpty(result))
                                {
                                    TrackingBatchModel tbm = JsonConvert.DeserializeObject<TrackingBatchModel>(result);
                                    if (tbm != null && tbm.data.errors != null)
                                    {
                                        foreach (var item in tbm.data.errors)
                                        {
                                            if (item.code != 4016)
                                            {
                                                dbSet.Where(o => o.TrackingNumber == item.tracking_number).First().State = "-1";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        foreach (var item in sbData)
                                        {
                                            dbSet.Where(o => o.TrackingNumber == item.tracking_number).First().State = "0";
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
                                dbSet.Where(o => o.TrackingNumber == item.tracking_number).First().State = "1";
                            }
                            Thread.Sleep(200);
                        }

                    }
                }

                sl0.Kd100Flag = num0;
                sl1.Kd100Flag = num1;
                sl2.Kd100Flag = num2;
                sl3.Kd100Flag = num3;
                sl4.Kd100Flag = num4;
                sl5.Kd100Flag = num5;




                IQueryable<Spm_ExpressInfo> dy = dbSet.Where(o => o.State == "-1" && o.ShipperCode != "HHTT:天天快递");

                if (dy.Count() > 0)
                {
                    KdApiSubscribe subscribe = new KdApiSubscribe();
                    foreach (var item in dy)
                    {
                        try
                        {
                            KdApiSubscribeModel resultB = JsonConvert.DeserializeObject<KdApiSubscribeModel>(subscribe.orderTracesSubByJson(item.TrackingNumber, item.ShipperCode.Split(':')[0]));
                            if (resultB.Success)
                            {
                                item.State = "900";
                            }
                            else
                            {
                                item.State = "-1";
                            }

                        }
                        catch (Exception ex)
                        {
                            item.State = "-1";
                            ILog log = LogManager.GetLogger(typeof(SpmExpressJob));
                            log.Error("订阅快递鸟出错", ex);
                        }
                    }
                }

                Spm_ExpressInfo t = dbSet.Where(o => o.Id == "test").First();
                t.DateTimeStamp = DateTime.Now.AddYears(-1);

                DateTime resetTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")).AddMinutes(5);
                if (DateTime.Now < resetTime)
                {
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
                }

                dbContext.SaveChanges();

            }

        }
    }
}