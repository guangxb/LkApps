using Apps.Common;
using Apps.Models;
using Apps.Models.Common.Trackingmore;
using Apps.WebApi.Areas.Spm.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Apps.WebApi.Areas.Spm.Controllers
{
    public class ExpressInfoController : ApiController
    {
        // GET: api/ExpressInfo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ExpressInfo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ExpressInfo
        public Root Post([FromBody]Datas model)
        {
            if (model.RequestData != null)
            {
                var requestData = JsonConvert.DeserializeObject<RequestData>(model.RequestData);

                if (requestData.Data.Count() > 0)
                {
                    //Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;

                    using (DBContainer dbContext = new DBContainer())
                    {
                        DbSet<Spm_ExpressInfo> dbSet0 = dbContext.Set<Spm_ExpressInfo>();
                        DbSet<Spm_TracesInfo> dbSet1 = dbContext.Set<Spm_TracesInfo>();

                        DateTime pushTime = requestData.PushTime;
                        //ValidationErrors error = new ValidationErrors();
                        foreach (var item in requestData.Data)
                        {
                            Spm_ExpressInfo exInfo = dbSet0.Where(o => o.TrackingNumber == item.LogisticCode).FirstOrDefault();
                            //var exInfo = serviceSession.Spm_ExpressInfo.GetList(o => o.TrackingNumber == item.LogisticCode).FirstOrDefault();
                            //if (exInfo == null)
                            //{
                            //    string newId = ResultHelper.NewId;
                            //    Spm_ExpressInfoModel eModel = new Spm_ExpressInfoModel()
                            //    {
                            //        Id = newId,
                            //        TrackingNumber = item.LogisticCode,
                            //        State = item.State,
                            //        ShipperCode = item.ShipperCode,
                            //        CallBack = item.CallBack,
                            //        EBusinessID = item.EBusinessID,
                            //        OrderCode = item.OrderCode,
                            //        Reason = item.Reason,
                            //        Success = item.Success,
                            //        PushTime = pushTime,
                            //    };
                            //    serviceSession.Spm_ExpressInfo.Create(ref error, eModel);

                            //    if (item.Traces.Count() > 0)
                            //    {

                            //        List<Spm_TracesInfoModel> ti = serviceSession.Spm_TracesInfo.GetList(t => t.ExInfoId == newId).OrderByDescending(a => a.AcceptTime).ToList();
                            //        foreach (var tc in item.Traces)
                            //        {
                            //            if (ti.Count > 0)
                            //            {
                            //                if ((tc.AcceptTime > ti.First().AcceptTime))
                            //                {
                            //                    Spm_TracesInfoModel m = new Spm_TracesInfoModel()
                            //                    {
                            //                        Id = ResultHelper.NewId,
                            //                        ExInfoId = newId,
                            //                        AcceptTime = tc.AcceptTime,
                            //                        AcceptStation = tc.AcceptStation,
                            //                    };
                            //                    serviceSession.Spm_TracesInfo.Create(ref error, m);
                            //                }
                            //            }
                            //            else
                            //            {
                            //                Spm_TracesInfoModel m = new Spm_TracesInfoModel()
                            //                {
                            //                    Id = ResultHelper.NewId,
                            //                    ExInfoId = newId,
                            //                    AcceptTime = tc.AcceptTime,
                            //                    AcceptStation = tc.AcceptStation,
                            //                };
                            //                serviceSession.Spm_TracesInfo.Create(ref error, m);
                            //            }
                            //        }
                            //    }
                            //}
                            if (exInfo != null)
                            {
                                //Spm_ExpressInfoModel eModel = new Spm_ExpressInfoModel()
                                //{
                                //    Id = exInfo.Id,
                                //    State = item.State,

                                //    //ShipperCode = item.ShipperCode,
                                //    CallBack = item.CallBack,
                                //    EBusinessID = item.EBusinessID,
                                //    OrderCode = item.OrderCode,
                                //    Reason = item.Reason,
                                //    Success = item.Success,
                                //    PushTime = pushTime,
                                //};

                                exInfo.State = item.State;
                                exInfo.CallBack = item.CallBack;
                                exInfo.EBusinessID = item.EBusinessID;
                                exInfo.OrderCode = item.OrderCode;
                                exInfo.Reason = item.Reason;
                                exInfo.Success = item.Success;
                                exInfo.PushTime = pushTime;


                                //if (exInfo.ShipperCode.IsNullOrEmpty())
                                //{
                                //    exInfo.ShipperCode = item.ShipperCode;
                                //serviceSession.Spm_ExpressInfo.Modify(ref error, eModel, "State", "CallBack", "ShipperCode", "EBusinessID", "OrderCode", "Reason", "Success", "PushTime");
                                //}
                                //else {
                                //    serviceSession.Spm_ExpressInfo.Modify(ref error, eModel, "State", "CallBack", "EBusinessID", "OrderCode", "Reason", "Success", "PushTime");
                                //}

                                dbContext.Entry<Spm_ExpressInfo>(exInfo).State = EntityState.Modified;

                                if (item.Traces.Count() > 0)
                                {
                                    IQueryable<Spm_TracesInfo> ti = dbSet1.Where(t => t.ExInfoId == exInfo.Id).OrderByDescending(a => a.AcceptTime);
                                    //List<Spm_TracesInfoModel> ti = serviceSession.Spm_TracesInfo.GetList(t => t.ExInfoId == exInfo.Id).OrderByDescending(a => a.AcceptTime).ToList();
                                    foreach (var tc in item.Traces)
                                    {
                                        if (ti.Count() > 0)
                                        {
                                            if ((tc.AcceptTime > ti.First().AcceptTime))
                                            {
                                                Spm_TracesInfo m = new Spm_TracesInfo()
                                                {
                                                    Id = ResultHelper.NewId,
                                                    ExInfoId = exInfo.Id,
                                                    AcceptTime = tc.AcceptTime,
                                                    AcceptStation = tc.AcceptStation,
                                                };
                                                //dbContext.Entry<Spm_TracesInfo>(m).State = EntityState.Added;
                                                dbSet1.Add(m);
                                                //serviceSession.Spm_TracesInfo.Create(ref error, m);
                                            }
                                        }
                                        else
                                        {
                                            Spm_TracesInfo m = new Spm_TracesInfo()
                                            {
                                                Id = ResultHelper.NewId,
                                                ExInfoId = exInfo.Id,
                                                AcceptTime = tc.AcceptTime,
                                                AcceptStation = tc.AcceptStation,
                                            };
                                            //dbContext.Entry<Spm_TracesInfo>(m).State = EntityState.Added;
                                            dbSet1.Add(m);
                                            //serviceSession.Spm_TracesInfo.Create(ref error, m);
                                        }
                                    }
                                }
                            }
                            //serviceSession.SaveChange();
                        }
                        if (dbContext.SaveChanges() >= 0)
                        {
                            return new Root()
                            {
                                EBusinessID = "1281577",
                                UpdateTime = "",
                                Success = true,
                                Reason = "",
                            };

                        }
                        else
                        {

                            return new Root()
                            {
                                EBusinessID = "1281577",
                                UpdateTime = DateTime.Now.ToString(),
                                Success = false,
                                Reason = "获取数据失败",
                            };
                        }
                    }
                }
            }


            Root root = new Root()
            {
                EBusinessID = "1281577",
                UpdateTime = "",
                Success = true,
                Reason = "",
            };

            return root;

        }

        // PUT: api/ExpressInfo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ExpressInfo/5
        public void Delete(int id)
        {
        }
    }
}
