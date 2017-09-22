using Apps.Common;
using Apps.Locale;
using Apps.Models.Sys;
using Apps.Web.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Apps.Web.Controllers
{
    public class SysStructController : BaseController
    {
        ValidationErrors errors = new ValidationErrors();
        // GET: SysStruct
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetList(string id)
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
            if (id == null)
                id = "0";
            List<SysStructModel> list = serviceSession.SysStruct.GetList(id);
            var json = from r in list
                       select new SysStructModel()
                       {
                           Id = r.Id,
                           Name = r.Name,
                           ParentId = r.ParentId,
                           Sort = r.Sort,
                           Enable = r.Enable,
                           Higher = r.Higher,
                           Remark = r.Remark,
                           CreateTime = r.CreateTime,
                           state = (serviceSession.SysStruct.GetList(r.Id).Count > 0) ? "closed" : "open"
                       };


            return Json(json);
        }

        #region 创建
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create(SysStructModel model)
        {
            model.Id = ResultHelper.NewId;
            model.CreateTime = ResultHelper.NowTime;
            string userId = OpeCur.AccountNow.Id;
            var error1 = ModelState.Values.SelectMany(v => v.Errors);

            if (model != null && ModelState.IsValid)
            {
                if (model.Name.IsNullOrEmpty())
                {
                    return OpeCur.AjaxMsgNOOK("用户名不能为空！");
                }
                OpeCur.ServiceSession.SysStruct.Create(ref errors, model);

                if (OpeCur.ServiceSession.SaveChange() > 0)
                {
                    LogHandler.WriteServiceLog(userId, "Id" + model.Id + ",Name" + model.Name, "成功", "创建", "SysRole");
                    //return Json(JsonHandler.CreateMessage(1, Resource.InsertSucceed));
                    return OpeCur.AjaxMsgOK(Resource.InsertSucceed);
                }
                else
                {
                    string ErrorCol = errors.Error;
                    LogHandler.WriteServiceLog(userId, "Id" + model.Id + ",Name" + model.Name + "," + ErrorCol, "失败", "创建", "SysRole");
                    //return Json(JsonHandler.CreateMessage(0, Resource.InsertFail + ErrorCol));
                    return OpeCur.AjaxMsgOK(Resource.InsertFail + ErrorCol);
                }
            }
            else
            {
                return OpeCur.AjaxMsgNOOK(Resource.ModelStateValidFail);
            }
        }
        #endregion

        #region 修改
        public ActionResult Edit(string id)
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;

            ViewBag.Areas = new SelectList(serviceSession.SysAreas.GetList("0"), "Id", "Name");

            SysStructModel entity = serviceSession.SysStruct.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public JsonResult Edit(SysStructModel info)
        {
            if (info != null && ModelState.IsValid)
            {
                Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
                serviceSession.SysStruct.Modify(ref errors, info, "Name", "Remark", "Sort", "Enable", "ParentId");
                string ErrorCol = errors.Error;
                if (serviceSession.SaveChange() > 0)
                {
                    LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Id:" + info.Id + ",Name:" + info.Name, "成功", "修改", "用户设置");
                    return OpeCur.AjaxMsgOK("修改成功！" + ErrorCol);
                }
                else
                {
                    LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Id:" + info.Id + ",Name:" + info.Name + "," + ErrorCol, "失败", "修改", "用户设置");
                    return OpeCur.AjaxMsgNOOK("修改失败！" + ErrorCol);
                }
            }
            else
            {
                return OpeCur.AjaxMsgNOOK(Resource.ModelStateValidFail);
            }
        }
        #endregion


        [HttpPost]
        public JsonResult GetListByComTree(string id)
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
            List<SysStructModel> list = serviceSession.SysStruct.GetList(id).Where(t=>t.Enable==true).ToList();//获取子集
            var json = from r in list
                       select new SysStructEditModel()
                       {
                           id = r.Id,
                           text = r.Name,
                           state = (serviceSession.SysStruct.GetList(r.Id).Count > 0) ? "closed" : "open"
                       };


            return Json(json);
        }

        [HttpPost]
        public JsonResult GetPosListByComTree(string depId)
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
            List<SysPositionModel> list = serviceSession.SysPosition.GetPosListByDepId(depId).Where(t=>t.Enable==true).ToList();
            var json = from r in list
                       select new SysPositionEditModel()
                       {
                           id = r.Id,
                           text = r.Name,
                           state = "open"
                       };


            return Json(json);
        }
        #region 删除
        [HttpPost]
        public JsonResult Delete(string id)
        {
            if (!string.IsNullOrWhiteSpace(id)&&id!="root")
            {
                Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
                string userId = OpeCur.AccountNow.Id;
                string ErrorCol = errors.Error;

                var structModel = serviceSession.SysStruct.GetById(id);
                if (id == "2017admin")
                {
                    LogHandler.WriteServiceLog(userId, "尝试删除管理员", "失败", "删除", "用户设置");
                    return OpeCur.AjaxMsgNOOK("管理员不能被删除" + ErrorCol);
                }
                if (structModel.Enable!=true)
                {
                    IEnumerable<SysUserModel> sysUserList = serviceSession.SysUser.GetList(t=>t.DepId==id);//1、查找用户   2、更新用户信息
                    IEnumerable<SysPositionModel> sysPositionList = serviceSession.SysPosition.GetList(t=>t.DepId==id);//1、查找职位 2、更新职位信息
                    IEnumerable<SysStructModel> sysStructList = serviceSession.SysStruct.GetList(t => t.ParentId == id);//获取子部门信息
                    //更新关联--用户信息
                    foreach (var item in sysUserList)
                    {
                        try
                        {
                            item.DepId = structModel.ParentId;
                            item.DepName = serviceSession.SysStruct.GetById(structModel.ParentId).Name;
                            serviceSession.SysUser.UpdateByStruct(ref errors, item);//更新用户信息
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                    //更新关联--职位信息
                    foreach (var item in sysPositionList)
                    {
                        try
                        {
                            item.DepId = structModel.ParentId;
                            item.DepName = serviceSession.SysStruct.GetById(structModel.ParentId).Name;
                            serviceSession.SysPosition.UpdateByStruct(ref errors, item);//更新职业信息
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                    //更新struct
                    foreach (var item in sysStructList)
                    {
                        try
                        {
                            item.ParentId = serviceSession.SysStruct.GetById(id).ParentId;
                            serviceSession.SysStruct.Modify(ref errors, item, "ParentId");//更新部门所属信息
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                    }
                    serviceSession.SysStruct.RemoveById(ref errors, id);
                    int saveNum = serviceSession.SaveChange();
                    if (saveNum > 0)
                    {
                        LogHandler.WriteServiceLog(userId, "Id:" + id, "成功", "删除", "用户设置");
                        return OpeCur.AjaxMsgOK(Resource.DeleteSucceed + ErrorCol);
                    }
                    else
                    {
                        ErrorCol = errors.Error;
                        LogHandler.WriteServiceLog(userId, "Id:" + id + "," + ErrorCol, "失败", "删除", "用户设置");
                        return OpeCur.AjaxMsgNOOK(Resource.DeleteFail + ErrorCol);
                    }
                }
                else
                {
                    ErrorCol = errors.Error;
                    LogHandler.WriteServiceLog(userId, "Id:" + id + "," + ErrorCol, "失败", "删除", "用户设置");
                    return OpeCur.AjaxMsgNOOK(Resource.DeleteFail+" 部门已启用，请禁用，再删除 " + ErrorCol);
                }
                
            }
            else
            {
                return OpeCur.AjaxMsgNOOK(Resource.DeleteFail);
            }

        }
        #endregion

    }
}