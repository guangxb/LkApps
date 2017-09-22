using Apps.Common;
using Apps.Models;
using Apps.Models.Common.Trackingmore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Apps.WebApi.Areas.Spm.Controllers
{
    public class TrackingInfoController : ApiController
    {
        public void Post(TrackingInfoModel model)
        {
            
            if (model.meta !=null&&model.meta.code == 200)
            {
                if (model.data == null) return;

                if (model.data.origin_info != null && model.data.status != null && model.data.origin_info.trackinfo != null) {
                    using (DBContainer dbContext = new DBContainer())
                    {
                        DbSet<Spm_ExpressInfo> dbSet0 = dbContext.Set<Spm_ExpressInfo>();
                        DbSet<Spm_TracesInfo> dbSet1 = dbContext.Set<Spm_TracesInfo>();

                        Spm_ExpressInfo exInfo = dbSet0.Where(o => o.TrackingNumber == model.data.tracking_number).FirstOrDefault();

                        if (exInfo != null) {
                            switch (model.data.status)
                            {
                                case "notfound": exInfo.State = "0"; break;
                                case "transit": case "pickup": case "undelivered": case "expired": exInfo.State = "2"; break;
                                case "delivered": exInfo.State = "3"; break;
                                case "exception": exInfo.State = "4"; break;
                                default:
                                    break;
                            }
                            IQueryable<Spm_TracesInfo> ti = dbSet1.Where(t => t.ExInfoId == exInfo.Id).OrderByDescending(a => a.AcceptTime);
                            foreach (var item in model.data.origin_info.trackinfo) {
                                if (ti.Count() > 0)
                                {
                                    if ((item.Date > ti.First().AcceptTime))
                                    {
                                        Spm_TracesInfo m = new Spm_TracesInfo()
                                        {
                                            Id = ResultHelper.NewId,
                                            ExInfoId = exInfo.Id,
                                            AcceptTime = item.Date,
                                            AcceptStation = item.StatusDescription + ";" + item.Details,
                                        };
                                        dbSet1.Add(m);
                                    }
                                }
                                else
                                {
                                    Spm_TracesInfo m = new Spm_TracesInfo()
                                    {
                                        Id = ResultHelper.NewId,
                                        ExInfoId = exInfo.Id,
                                        AcceptTime = item.Date,
                                        AcceptStation = item.StatusDescription + ";" + item.Details,
                                    };
                                    dbSet1.Add(m);
                                }
                            }
                        }
                        dbContext.SaveChanges();
                    }
                }
            }
        }

    }
}
