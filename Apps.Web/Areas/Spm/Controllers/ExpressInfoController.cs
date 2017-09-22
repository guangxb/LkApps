using Apps.Common;
using Apps.Models;
using Apps.Models.SCV.Sys;
using Apps.Models.Spm;
using Apps.Web.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Apps.Web.Areas.Spm.Controllers
{
    public class ExpressInfoController : BaseController
    {
        // GET: Spm/ExpressInfo
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetList(GridPager pager, string queryStr)
        {
            List<Apps.Models.Spm.ExViewModel> list;

            list = OpeCur.ServiceSession.Spm_ExpressInfo.GetViewList(ref pager, queryStr, LambdaHelper.CreateEquals<Spm_ExpressInfo>("Company", OpeCur.AccountNow.AllMerchant, OpeCur.UsrHasMerchantCode));

            if (list == null)
            {
                return OpeCur.AjaxMsgNOOK("没有符合条件的数据！");
            }

            GridRows<Apps.Models.Spm.ExViewModel> grs = new GridRows<Apps.Models.Spm.ExViewModel>();
            grs.rows = list;
            grs.total = pager.totalRows;

            return Json(grs);
        }
        [HttpPost]
        public JsonResult GetComboxData()
        {
            //List<COMPANY_MODEL> list = OpeCur.SCVServiceSession.COMPANY.GetList();
            var json = (from r in OpeCur.UsrHasMerchantCode
                        select new COMPANY_COMBO_VIEW_MODEL()
                        {
                            Id = r,
                            Name = r
                        }).ToArray();

            return Json(json);
        }

        [HttpPost]
        public JsonResult GetStateComboxData()
        {
            List<object> list = new List<object>();
            list.Add(new { Id = "-1", Name = "订阅失败" });
            list.Add(new { Id = "900", Name = "暂无状态" });
            list.Add(new { Id = "0", Name = "无轨迹" });
            list.Add(new { Id = "1", Name = "已揽收" });
            list.Add(new { Id = "2", Name = "在途中" });
            list.Add(new { Id = "3", Name = "签收" });
            list.Add(new { Id = "4", Name = "问题件" });


            return Json(list);
        }

        public ActionResult Details(string id)
        {
            ViewBag.Id = id;
            return View();
        }
        [HttpPost]
        public JsonResult Details(string sort, string order, string id)
        {

            bool isAsc = order == "asc" ? true : false;
            List<Spm_TracesInfoModel> model = OpeCur.ServiceSession.Spm_TracesInfo.GetListSort(t => t.ExInfoId == id, t => t.AcceptTime, isAsc);
            return Json(model);
        }

        //[HttpPost]
        //public JsonResult CheckExportData()
        //{
        //    IService.Spm.ISpm_ExpressInfoService eis = OpeCur.ServiceSession.Spm_ExpressInfo;
        //    List<ExViewModel> list = eis.GetViewList(LambdaHelper.CreateEquals<Spm_ExpressInfo>("Company", OpeCur.AccountNow.AllMerchant, OpeCur.UsrHasMerchantCode));
        //    if (list.Count().Equals(0))
        //    {
        //        return OpeCur.AjaxMsgNOOK("没有可以导出的数据");
        //    }
        //    else
        //    {
        //        return OpeCur.AjaxMsgOK("可以导出");
        //    }
        //}
        public ActionResult Export()
        {
            
            IService.Spm.ISpm_ExpressInfoService eis = OpeCur.ServiceSession.Spm_ExpressInfo;
            //var dt = await Task.Run(() => { return eis.GetViewDataTable(LambdaHelper.CreateEquals<Spm_ExpressInfo>("Company", OpeCur.AccountNow.AllMerchant, OpeCur.UsrHasMerchantCode)); });
            var dt = eis.GetViewDataTable(LambdaHelper.T_CreateEquals<Spm_ExpressInfo>("Company", OpeCur.AccountNow.AllMerchant, OpeCur.UsrHasMerchantCode));
            if (dt.Rows.Count > 0)
            {
                var exportFileName = string.Concat(
                    "ExpressInfo",
                    DateTime.Now.ToString("yyyyMMddHHmmss"),
                    ".xlsx");

                return new ExportExcelResult
                {
                    SheetName = "快递信息",
                    FileName = exportFileName,
                    ExportData = dt
                };
            }
            else {
                return OpeCur.JsMsg("没有符合条件的数据");
            }
        }

        //private JArray GetExportData()
        //{
        //    IService.Spm.ISpm_ExpressInfoService eis = OpeCur.ServiceSession.Spm_ExpressInfo;
        //    List<ExViewModel> list = eis.GetViewList(LambdaHelper.CreateEquals<Spm_ExpressInfo>("Company", OpeCur.AccountNow.AllMerchant, OpeCur.UsrHasMerchantCode));
        //    JArray jObjects = new JArray();

        //    foreach (var item in list)
        //    {
        //        var jo = new JObject();
        //        jo.Add("订单号", item.ShipmentId);
        //        jo.Add("运单号", item.TrackingNumber);
        //        jo.Add("订单创建时间", item.DateTimeStamp);
        //        jo.Add("商家代码", item.Company);
        //        switch (item.State) {
        //            case "-1": jo.Add("物流状态", "订阅失败"); break;
        //            case "900": jo.Add("物流状态", "暂无状态"); break;
        //            case "0": jo.Add("物流状态", "无轨迹"); break;
        //            case "1": jo.Add("物流状态", "已揽收"); break;
        //            case "2": jo.Add("物流状态", "在途中"); break;
        //            case "3": jo.Add("物流状态", "签收"); break;
        //            case "4": jo.Add("物流状态", "问题件"); break;
        //            default:
        //                jo.Add("State", "");
        //                break;
        //        }
                
        //        jo.Add("承运商", item.ShipperCode);
        //        jo.Add("快递最新动态", item.NewTraces);
        //        jObjects.Add(jo);
        //    }
        //    return jObjects;
        //}


    }
}