using Apps.Common;
using Apps.Models;
using Apps.Models.SCV.GENERIC;
using Apps.Models.SCV.SHIPMENT;
using Apps.Web.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Apps.Web.Areas.LogisticsSys.Controllers
{
    public class AssignCarriersController : BaseController
    {
        ValidationErrors errors = new ValidationErrors();
        // GET: LogisticsSys/AssignCarriers
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetCompanyList(GridPager pager)
        {
            string userId = OpeCur.AccountNow.Id;
            string[] hasMC = OpeCur.UsrHasMerchantCode;
            List<string> mcList = LinqHelper.DataPaging(hasMC.AsQueryable(), pager.page, pager.rows).ToList();
            pager.totalRows = hasMC.Count();
            var json = new
            {
                total = pager.totalRows,
                rows = (from r in mcList
                        select new
                        {
                            Id = userId,
                            Company = r,
                        }).ToArray()
            };
            return Json(json);
        }

        [HttpPost]
        public JsonResult GetProvincesCarrierList(GridPager pager, string company)
        {

            if (string.IsNullOrEmpty(company))
            {

                return Json(null);
            }
            IService.SCV.ISCVServiceSession ss = OpeCur.SCVServiceSession;

            List<SHIPMENT_CARRIER_EDITRULE_MODEL> list = ss.SHIPMENT_CARRIER_EDITRULE.GetList(s => s.Company == company);


            //pager.totalRows = list.Count();
            //var json = new
            //{
            //    total = pager.totalRows,
            var json = (from r in list
                        select new
                        {
                            id = r.Id,
                            company = r.Company,
                            provincesId = r.Provinces,
                            provincesName = r.Provinces,
                            carrierId = r.Carrier,
                            carrierName = r.Carrier,
                        }).ToArray();
            //};
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetProvincesList()
        {
            IService.SCV.ISCVServiceSession ss = OpeCur.SCVServiceSession;
            List<GENERIC_CONFIG_DETAIL_MODEL> list = ss.GENERIC_CONFIG_DETAIL.GetList(g => g.RECORD_TYPE == "STATE");
            //pager.totalRows = list.Count();
            //var json = new
            //{
            //total = pager.totalRows,
            List<string> ps = new List<string>();
            foreach (var item in list)
            {
                Regex rgx = new Regex("市|省|自治区|特别行政区|壮族|回族|维吾尔族|直辖|维吾尔");
                string temp = rgx.Replace(item.IDENTIFIER, "");
                ps.Add(temp);
            }

            var json = (from r in ps
                        select new
                        {
                            provincesId = r,
                            provincesName = r
                        }).ToArray();
            //};
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetCarrierList()
        {
            IService.SCV.ISCVServiceSession ss = OpeCur.SCVServiceSession;
            List<GENERIC_CONFIG_DETAIL_MODEL> list = ss.GENERIC_CONFIG_DETAIL.GetList(g => g.RECORD_TYPE == "CARRIER");
            //pager.totalRows = list.Count();
            //var json = new
            //{
            //total = pager.totalRows,
            var json = (from r in list
                        select new
                        {
                            carrierId = r.IDENTIFIER,
                            carrierName = r.DESCRIPTION
                        }).ToArray();
            //};
            return Json(json, JsonRequestBehavior.AllowGet);
        }

      

        [HttpPost]
        public JsonResult Save(FormCollection data)
        {


            string deleteList = data["deleted"];
            string updateList = data["updated"];
            string addList = data["inserted"];
            IService.SCV.ISCVServiceSession ss = OpeCur.SCVServiceSession;

            if (!string.IsNullOrWhiteSpace(deleteList))
            {
                List<Model> list = JsonConvert.DeserializeObject<List<Model>>(deleteList);
                //if (list.GroupBy(l => l.provincesId).Where(g => g.Count() > 1).Count() > 0)
                //{
                //    return Json(new { status = 0, msg = "省份重复" });
                //}

                foreach (var item in list)
                {
                    if (!string.IsNullOrWhiteSpace(item.company) && !string.IsNullOrWhiteSpace(item.provincesId) && !string.IsNullOrWhiteSpace(item.carrierId))
                    {
                        int curid = Convert.ToInt32(item.id);
                        //SHIPMENT_CARRIER_EDITRULE_MODEL curObj = ss.SHIPMENT_CARRIER_EDITRULE.GetList(u => u.Id == curid).FirstOrDefault();
                        //if (curObj != null)
                        //{
                            ss.SHIPMENT_CARRIER_EDITRULE.RemoveById(curid);
                        //}
                    }
                }
                ss.SaveChange();
                //return Json(new { status = 1, msg = "删除成功" });
            }

            if (!string.IsNullOrWhiteSpace(updateList))
            {
                List<Model> list = JsonConvert.DeserializeObject<List<Model>>(updateList);

                //if (list.GroupBy(l => l.provincesId).Where(g => g.Count() > 1).Count() > 0)
                //{
                //    return Json(new { status = 0, msg = "省份重复" });
                //}

                foreach (var item in list)
                {
                    if (!string.IsNullOrWhiteSpace(item.company) && !string.IsNullOrWhiteSpace(item.provincesId) && !string.IsNullOrWhiteSpace(item.carrierId))
                    {
                        int curid = Convert.ToInt32(item.id);
                        SHIPMENT_CARRIER_EDITRULE_MODEL curObj = ss.SHIPMENT_CARRIER_EDITRULE.GetList(u => u.Id == curid).FirstOrDefault();

                        curObj.Company = item.company;
                        curObj.Provinces = item.provincesId;
                        curObj.Carrier = item.carrierId;
                        ss.SHIPMENT_CARRIER_EDITRULE.Modify(ref errors, curObj, "Company", "Provinces", "Carrier");

                    }
                }
                ss.SaveChange();
                //return Json(new { status = 1,msg = "修改成功" });
            }

            if (!string.IsNullOrWhiteSpace(addList))
            {
                List<Model> list = JsonConvert.DeserializeObject<List<Model>>(addList);

                //if (list.GroupBy(l => l.provincesId).Where(g => g.Count() > 1).Count() > 0)
                //{
                //    return Json(new { status = 0,msg = "省份重复" });
                //}

                foreach (var item in list)
                {
                    if (!string.IsNullOrWhiteSpace(item.company) && !string.IsNullOrWhiteSpace(item.provincesId) && !string.IsNullOrWhiteSpace(item.carrierId))
                    {
                        SHIPMENT_CARRIER_EDITRULE_MODEL curprovinces = ss.SHIPMENT_CARRIER_EDITRULE.GetList(u => u.Company == item.company && u.Provinces == item.provincesId).FirstOrDefault();
                        if (curprovinces != null)
                        {
                            return Json(new { status = 0, msg = "省份重复" });
                        }
                        ss.SHIPMENT_CARRIER_EDITRULE.Create(ref errors,new SHIPMENT_CARRIER_EDITRULE_MODEL()
                        {
                            Company = item.company,
                            Provinces = item.provincesId,
                            Carrier = item.carrierId,
                        });
                    }
                }
                ss.SaveChange();
                //return Json(new { status = 1, msg = "添加成功" });
            }
            //object obj = JsonConvert.DeserializeObject(updateList);
            //CarrierEdit/Commit
            return Json(new { status = 1, msg = "保存成功" });
        }

        class Model
        {
            public string id { get; set; }
            public string company { get; set; }
            public string provincesId { get; set; }
            public string carrierId { get; set; }
        }
    }
}
