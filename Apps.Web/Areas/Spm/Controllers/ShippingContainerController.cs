using Apps.Common;
using Apps.Common.WeightHelp;
using Apps.Locale;
using Apps.Models.SCV.SHIPPING;
using Apps.Web.Core;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Apps.Web.Areas.Spm.Controllers
{
    public class ShippingContainerController : BaseController
    {
        ValidationErrors errors = new ValidationErrors();
        bool isInisitil = false;
        // GET: Spm/ShippingContainer
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetList(GridPager pager, string queryStr)
        {
            Apps.IService.SCV.ISCVServiceSession serviceSession = OpeCur.SCVServiceSession;
            List<SHIPPING_CONTAINER_HIS_MODEL> list = serviceSession.SHIPPING_CONTAINER_HIS.GetList(ref pager, queryStr, t => t.UPDATE_USER.ToString() == OpeCur.AccountNow.Id).ToList(); 

            if (list.Count <= 0)
            {
                return OpeCur.AjaxMsgOK(Resource.NoMatchingData);
            }
            var json = new
            {
                total = pager.totalRows,
                rows = list,

            };

            return OpeCur.AjaxMsgOK(Resource.GetSuccess, "", json);
        }
        #region 更新包裹重量
        /// <summary>
        /// 更新出库产品重量
        /// </summary>
        /// <returns></returns>
        public ActionResult EditOfWeight()
        {
            SHIPPING_CONTAINER_MODEL model = new SHIPPING_CONTAINER_MODEL();
            return View(model);
        }
        /// <summary>
        /// 更新出库产品重量
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult EditOfWeight(SHIPPING_CONTAINER_MODEL info)
        {
            if (info != null && ModelState.IsValid)
            {
                Apps.IService.SCV.ISCVServiceSession scvSession = OpeCur.SCVServiceSession;
                string ErrorCol = errors.Error;

                List<SHIPPING_CONTAINER_MODEL> modelList = scvSession.SHIPPING_CONTAINER.GetList(t => (t.TRACKING_NUMBER.ToLower()) == info.TRACKING_NUMBER.ToLower()&&t.PARENT==0);
                if (modelList.Count()==0)
                {
                    return OpeCur.AjaxMsgNOOK("该单号不存在，或数据不可更改！");
                }
                SHIPPING_CONTAINER_MODEL item = modelList.FirstOrDefault();
                int saveData = 0;
                if (info.WEIGHT != null && info.WEIGHT != 0)
                {
                    info.INTERNAL_CONTAINER_NUM = item.INTERNAL_CONTAINER_NUM;
                    item.WEIGHT = info.WEIGHT;
                    scvSession.SHIPPING_CONTAINER.Modify(ref errors, info, "WEIGHT");
                    saveData = scvSession.SaveChange();
                }

                if (saveData > 0)
                {
                    SHIPPING_CONTAINER_HIS_MODEL model = new SHIPPING_CONTAINER_HIS_MODEL();
                    model.ID = ResultHelper.NewId;
                    model.INTERNAL_CONTAINER_NUM = item.INTERNAL_CONTAINER_NUM;
                    model.UPDATE_DATATIME = DateTime.Now;
                    model.WEIGHT = item.WEIGHT;
                    model.WEIGHT_NUM = item.WEIGHT_UM;
                    model.TRACKING_NUMBER = item.TRACKING_NUMBER;
                    model.CONTAINER_ID = item.CONTAINER_ID;
                    model.UPDATE_USER = OpeCur.AccountNow.Id;
                    model.UPDATE_USERNAME = OpeCur.AccountNow.UserName;
                    model.UPDATE_USERTRUENAME = OpeCur.AccountNow.TrueName;
                    scvSession.SHIPPING_CONTAINER_HIS.Create(ref errors, model);
                    scvSession.SaveChange();

                    LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "SHIPMENT_ID:" + info.SHIPMENT_ID + "ITEM:" + info.ITEM + "Name:" + info.INTERNAL_SHIPMENT_LINE_NUM, "成功", "修改", "用户设置");
                    return OpeCur.AjaxMsgOK("修改成功！" + ErrorCol);
                }
                else
                {
                    LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "SHIPMENT_ID:" + info.SHIPMENT_ID + "ITEM:" + info.ITEM + "Name:" + info.INTERNAL_SHIPMENT_LINE_NUM, "失败", "修改", "用户设置");
                    return OpeCur.AjaxMsgNOOK("修改失败！" + ErrorCol);
                }
            }
            else
            {
                return OpeCur.AjaxMsgNOOK(Resource.ModelStateValidFail);
            }
        }
        /// <summary>
        /// 获取天平称重量数据
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public async Task<JsonResult> GetWeihhtData()
        {
            var rest = new JsonResult();
            rest.JsonRequestBehavior = JsonRequestBehavior.AllowGet;//允许使用GET方式获取，否则用GET获取是会报错。

            Apps.IService.SCV.ISCVServiceSession scvSession = OpeCur.SCVServiceSession;
            SHIPPING_CONTAINER_MODEL model = new SHIPPING_CONTAINER_MODEL();

            try
            {
                //判断串口种类
                string[] portList = SerialPort.GetPortNames();

                WeightReader weRea = new WeightReader();

                //初始化串口 
                isInisitil = weRea.InitCom("COM3");
                try
                {
                    WeightReader ww = new WeightReader();

                    if (!isInisitil)
                    {
                        weRea.InitCom("COM3");
                    }
                    WeightInformation info = await Task.Run(() => { return ww.ReadInfo(); });
                    model.WEIGHT = Convert.ToDecimal(info.WData);
                }
                catch (Exception ex)
                {
                    LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, ex.ToString(), "失败", "修改", "用户设置");
                    model.WEIGHT = 0;
                }
                rest.Data = model;

            }
            catch (Exception ex)
            {
                LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, ex.ToString(), "失败", "修改", "用户设置");
                model.WEIGHT = 0;
                rest.Data = model;
                return rest;
            }

            return rest;
        }
        #endregion
    }
}