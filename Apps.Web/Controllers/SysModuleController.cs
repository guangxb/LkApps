using Apps.Common;
using Apps.Common.Attrs;
using Apps.Locale;
using Apps.Models.Sys;
using Apps.Web.Core;
using Apps.Web.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apps.Web.Controllers
{
    public class SysModuleController : BaseController
    {
        // GET: SysModule
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IconList()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetList(string id)
        {
            Apps.IService.Sys.ISysModuleService mService = OpeCur.ServiceSession.SysModule;
            if (id == null)
                id = "0";

            List<SysModuleModel> list = mService.GetListByParentId(id);
            if (list.Count<=0)
            {
                return OpeCur.AjaxMsgNOOK("没有符合条件的数据！","",list);
            }

            //List<SysModuleModel> tempList = new List<SysModuleModel>();
            //foreach (var item in list)
            //{
            //    if (item.OperationType == 3)
            //    {
            //        tempList.AddRange(mService.GetListByParentId(item.Id));
            //    }
            //}

            //list.AddRange(tempList);

            return OpeCur.AjaxMsgOK("获取成功！", "", list);
        }

        #region 创建模块
        public ActionResult Create(string id)
        {

            SysModuleModel entity = new SysModuleModel()
            {
                ParentId = id,
                Iconic = "fa fa-puzzle-piece",
                Enable = true,
                Sort = 0
            };
            return View(entity);
        }

        [HttpPost]
        public JsonResult Create(SysModuleModel model)
        {
            model.Id = ResultHelper.NewId;
            model.CreateTime = ResultHelper.NowTime;
            model.CreatePerson = OpeCur.AccountNow.UserName;
            ValidationErrors errors = new ValidationErrors();
            if (model != null && ModelState.IsValid)
            {

                OpeCur.ServiceSession.SysModule.Create(ref errors, model);

                if (OpeCur.ServiceSession.SaveChange() > 0)
                {
                    LogHandler.WriteServiceLog(OpeCur.AccountNow.UserName, "Id" + model.Id + ",Name" + model.Name, "成功", "创建", "SysModule");
                    return OpeCur.AjaxMsgOK(Resource.InsertSucceed);
                }
                else {
                    return OpeCur.AjaxMsgError(Resource.InsertFail);
                }
            }
            else
            {
                return OpeCur.AjaxMsgNOOK(Resource.ModelStateValidFail);
            }
        }

        #endregion

        #region 修改模块
        public ActionResult Edit(string id)
        {

            SysModuleModel entity = OpeCur.ServiceSession.SysModule.GetById(id);

            return View(entity);
        }

        [HttpPost]
        public JsonResult Edit(SysModuleModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                ValidationErrors errors = new ValidationErrors();
                OpeCur.ServiceSession.SysModule.Modify(ref errors, model);
                if (OpeCur.ServiceSession.SaveChange() > 0) {
                    LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Id" + model.Id + ",Name" + model.Name, "成功", "修改", "系统菜单");
                    //return Json(JsonHandler.CreateMessage(1, Resource.EditSucceed));
                    return OpeCur.AjaxMsgOK(Resource.EditSucceed);
                }
                else
                {
                    string ErrorCol = errors.Error;
                    LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Id" + model.Id + ",Name" + model.Name + "," + ErrorCol, "失败", "修改", "系统菜单");
                    //return Json(JsonHandler.CreateMessage(0, Resource.EditFail + ":" + ErrorCol));
                    return OpeCur.AjaxMsgError(Resource.EditFail + ":" + ErrorCol);
                }
            }
            else
            {
                return OpeCur.AjaxMsgNOOK(Resource.ModelStateValidFail);
                //return Json(JsonHandler.CreateMessage(0, Resource.EditFail));
            }
        }
        #endregion

        #region 删除
        [HttpPost]
        public JsonResult Delete(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                ValidationErrors errors = new ValidationErrors();
                OpeCur.ServiceSession.SysModule.DeleteAndClear(ref errors, id);

                if (errors.Count() > 0) {
                    return OpeCur.AjaxMsgNOOK(errors.Error);
                }


                if (OpeCur.ServiceSession.SaveChange() > 0)
                {
                    LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Ids:" + id, "成功", "删除", "模块设置");
                    return OpeCur.AjaxMsgOK(Resource.DeleteSucceed);
                    //return Json(JsonHandler.CreateMessage(1, Resource.DeleteSucceed), JsonRequestBehavior.AllowGet);
                }
                else
                {
                    string ErrorCol = errors.Error;
                    LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Id:" + id + "," + ErrorCol, "失败", "删除", "模块设置");
                    return OpeCur.AjaxMsgError(Resource.DeleteFail + ":" + ErrorCol);
                    //return Json(JsonHandler.CreateMessage(0, Resource.DeleteFail + ErrorCol), JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return OpeCur.AjaxMsgNOOK("Id为空！");
                //return Json(JsonHandler.CreateMessage(0, Resource.DeleteFail), JsonRequestBehavior.AllowGet);
            }


        }
        #endregion
    }
}