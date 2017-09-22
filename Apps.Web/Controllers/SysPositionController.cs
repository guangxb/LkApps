using Apps.Common;
using Apps.Locale;
using Apps.Models.Sys;
using Apps.Web.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apps.Web.Controllers
{
    public class SysPositionController : BaseController
    {
        ValidationErrors errors = new ValidationErrors();
        // GET: SysPosition
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetList(GridPager pager, string queryStr)
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
            List<SysPositionModel> list = serviceSession.SysPosition.GetList(ref pager, queryStr);
            var json = new
            {
                total = pager.totalRows,
                rows = (from r in list
                        select new SysPositionModel()
                        {
                            Id = r.Id,
                            Name = r.Name,
                             
                            Remark = r.Remark,
                            Sort = r.Sort,
                            CreateTime = r.CreateTime,
                            Enable = r.Enable,
                            MemberCount = r.MemberCount,
                            DepId = r.DepId,
                            DepName = r.DepName

                        }).ToArray()

            };

            return Json(json);
        }

        #region 创建
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create(SysPositionModel model)
        {
            model.Id = ResultHelper.NewId;
            model.CreateTime = ResultHelper.NowTime;
            string userId = OpeCur.AccountNow.Id;
            if (model != null && ModelState.IsValid)
            {
                if (model.Name.IsNullOrEmpty())
                {
                    return OpeCur.AjaxMsgNOOK("职业名不能为空！");
                }
                OpeCur.ServiceSession.SysPosition.Create(ref errors, model);

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

            SysPositionModel entity = serviceSession.SysPosition.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public JsonResult Edit(SysPositionModel info)
        {
            if (info != null && ModelState.IsValid)
            {
                Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
                serviceSession.SysPosition.Modify(ref errors, info, "Name", "Remark", "Sort", "Enable", "MemberCount", "DepId");
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

        #region 删除
        [HttpPost]
        public JsonResult Delete(string id)
        {
            if (!string.IsNullOrWhiteSpace(id)&&id!="员工")
            {
                Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
                string userId = OpeCur.AccountNow.Id;
                string ErrorCol = errors.Error;
                if (id == "2017admin")
                {
                    LogHandler.WriteServiceLog(userId, "尝试删除管理员", "失败", "删除", "用户设置");
                    return OpeCur.AjaxMsgNOOK("管理员不能被删除" + ErrorCol);
                }
                if (serviceSession.SysPosition.GetById(id).Enable != true)
                {         
                    IEnumerable<SysUserModel> sysUserList = serviceSession.SysUser.GetList().Where(t => t.PosId == id);//1、查找用户   2、更新用户
                    foreach (var item in sysUserList)
                    {
                        try
                        {
                            item.PosId = "员工";
                            item.PosName = "员工";
                            serviceSession.SysUser.EditByPosition(ref errors, item);//更新用户信息
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                    serviceSession.SysPosition.RemoveById(ref errors, id);
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
                    return OpeCur.AjaxMsgNOOK(Resource.DeleteFail + " 职业已启用，请先取消，再删除" + ErrorCol);
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