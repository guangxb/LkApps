using Apps.Common;
using Apps.Locale;
using Apps.Models;
using Apps.Models.Sys;
using Apps.Web.Core;
using Apps.Web.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Apps.Web.Controllers
{
    public class SysUserController : Apps.Web.Core.BaseController
    {
        ValidationErrors errors = new ValidationErrors();
        // GET: SysUser
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetList(GridPager pager, string queryStr)
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
            List<SysUserModel> list = serviceSession.SysUser.GetUsrList(ref pager, queryStr);

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

        [HttpPost]
        public JsonResult GetListByComTree(string id)
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
            List<SysStructModel> list = serviceSession.SysStruct.GetList(id).Where(t=>t.Enable==true).ToList();
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
            List<SysPositionModel> list = serviceSession.SysPosition.GetPosListByDepId(depId).Where(t => t.Enable == true).ToList();
            var json = from r in list
                       select new SysPositionEditModel()
                       {
                           id = r.Id,
                           text = r.Name,
                           state = "open"
                       };


            return Json(json);
        }

        #region 获取人员选择表
        public ActionResult UserLookUp()
        {
            StructHelper structHelper = new StructHelper();
            ViewBag.StructTree = structHelper.GetStructTree(true);
            return View();
        }
        public JsonResult GetUserListByDep(GridPager pager, string depId, string queryStr)
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;

            if (string.IsNullOrWhiteSpace(depId))
                return Json(0);
            var userList = serviceSession.SysUser.GetUserByDepId(ref pager, depId, queryStr);

            var jsonData = new
            {
                total = pager.totalRows,
                rows = (
                    from r in userList
                    select new SysUserModel()
                    {
                        Id = r.Id,
                        UserName = r.UserName,
                        TrueName = r.TrueName,
                        DepName = serviceSession.SysStruct.GetById(r.DepId).Name,
                        PosName = serviceSession.SysPosition.GetById(r.PosId).Name,
                        Flag = "<input type='checkbox' id='cb_" + r.Id + "' onclick='SetValue(\"" + r.Id + "\",\"" + r.TrueName + "\")'>",
                    }
                ).ToArray()
            };
            return Json(jsonData);
        }
        #endregion

        #region 创建
        public ActionResult Create()
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
            ViewBag.Struct = new SelectList(serviceSession.SysStruct.GetList("0"), "Id", "Name");
            ViewBag.Areas = new SelectList(serviceSession.SysAreas.GetList("0"), "Id", "Name");
            SysUserModel model = new SysUserModel()
            {
                Password = "Lk123456",
                JoinDate = ResultHelper.NowTime,
                MerchantCodes = serviceSession.SysUser.GetMerchantCodes(),
            };
            return View(model);
        }

        #region 获取区域列表
        [HttpPost]
        public JsonResult GetAreasListByParentId(string id)
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
            if (id == null)
                id = "0";
            List<SysAreasModel> list = serviceSession.SysAreas.GetList(id);
            StringBuilder sb = new StringBuilder("");
            foreach (var i in list)
            {
                sb.AppendFormat("<option value='{0}'>{1}</option>", i.Id, i.Name);
            }

            return Json(sb.ToString());
        }

        #endregion
        [HttpPost]
        public JsonResult Create(SysUserModel model)
        {

            if (model != null && ModelState.IsValid)
            {

                Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
                string curUserId = OpeCur.AccountNow.Id;
                model.Id = ResultHelper.NewId;
                model.CreateTime = ResultHelper.NowTime;
                model.Password = ValueConvert.MD5(model.Password);
                model.CreatePerson = OpeCur.AccountNow.TrueName;
                model.State = true;
                serviceSession.SysUser.Create(ref errors, model);
                if (serviceSession.SaveChange() > 0)
                {
                    LogHandler.WriteServiceLog(curUserId, "Id:" + model.Id + ",Name:" + model.UserName, "成功", "创建", "用户设置");
                    return OpeCur.AjaxMsgOK("创建成功！");
                }
                else
                {
                    string ErrorCol = errors.Error;
                    LogHandler.WriteServiceLog(curUserId, "Id:" + model.Id + ",Name:" + model.UserName + "," + ErrorCol,

                    "失败", "创建", "用户设置");
                    return OpeCur.AjaxMsgNOOK("创建失败！" + ErrorCol);
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

            SysUserModel entity = serviceSession.SysUser.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public JsonResult Edit(SysUserModel info)
        {
            if (info != null && ModelState.IsValid)
            {
                Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
                serviceSession.SysUser.Edit(ref errors, info);
                string ErrorCol = errors.Error;
                if (serviceSession.SaveChange() > 0)
                {
                    OpeCur.SetOtherHMC(info.Id);
                    OpeCur.AccountNow.AllMerchant = false;
                    LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Id:" + info.Id + ",Name:" + info.UserName, "成功", "修改", "用户设置");
                    return OpeCur.AjaxMsgOK("修改成功！" + ErrorCol);
                }
                else
                {

                    LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Id:" + info.Id + ",Name:" + info.UserName + "," + ErrorCol, "失败", "修改", "用户设置");
                    return OpeCur.AjaxMsgNOOK("修改失败！" + ErrorCol);
                }
            }
            else
            {
                return OpeCur.AjaxMsgNOOK(Resource.ModelStateValidFail);
            }
        }

        [HttpPost]
        public JsonResult ReSet(string Id, string Pwd)
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;

            serviceSession.SysUser.EditPwd(ref errors, Id, Pwd);
            string ErrorCol = errors.Error;
            if (serviceSession.SaveChange() > 0)
            {
                LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Id:" + Id + ",密码:********", "成功", "初始化密码", "用户设置");
                return OpeCur.AjaxMsgOK(Resource.EditSucceed + ErrorCol);
            }
            else
            {

                LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Id:" + Id + ",,密码:********" + ErrorCol, "失败", "初始化密码", "用户设置");
                return OpeCur.AjaxMsgNOOK(Resource.EditFail + ErrorCol);
            }
        }
        #endregion

        #region 删除
        [HttpPost]
        public JsonResult Delete(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
                string userId = OpeCur.AccountNow.Id;
                string ErrorCol = errors.Error;
                if (id == "2017admin")
                {
                    LogHandler.WriteServiceLog(userId, "尝试删除管理员", "失败", "删除", "用户设置");
                    return OpeCur.AjaxMsgNOOK("管理员不能被删除" + ErrorCol);
                }
                serviceSession.SysUser.RemoveById(ref errors, id);
                if (serviceSession.SaveChange() > 0)
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
                return OpeCur.AjaxMsgNOOK(Resource.DeleteFail);
            }

        }
        #endregion

        #region 设置用户角色
        public ActionResult AssignRole(string userId)
        {
            ViewBag.UserId = userId;

            return View();
        }
        [HttpPost]
        public JsonResult GetRoleListByUser(GridPager pager, string userId)
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
            if (string.IsNullOrWhiteSpace(userId))
                return Json(0);
            var userList = serviceSession.SysUser.GetRoleByUserId(ref pager, userId);
            var jsonData = new
            {
                total = pager.totalRows,
                rows = (
                    from r in userList
                    select new SysRoleModel()
                    {
                        Id = r.Id,
                        Name = r.Name,
                        Description = r.Description,
                        Flag = r.flag == "0" ? "0" : "1",
                    }
                ).ToArray()
            };
            return Json(jsonData);
        }
        [HttpPost]
        public JsonResult AssignRole(string userId, string roleIds)
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;

            string[] arr = roleIds.Split(',');
            string curId = OpeCur.AccountNow.Id;
            serviceSession.SysUser.UpdateSysRoleSysUser(userId, arr);
            string ErrorCol = errors.Error;
            if (serviceSession.SaveChange() > 0)
            {
                OpeCur.SetOtherUsrPers(userId);
                LogHandler.WriteServiceLog(curId, "Ids:" + roleIds, "成功", "分配角色", "用户设置");
                return OpeCur.AjaxMsgOK(Resource.SetSucceed + ErrorCol);
            }
            else
            {
                ErrorCol = errors.Error;
                LogHandler.WriteServiceLog(curId, "Ids:" + roleIds, "失败", "分配角色", "用户设置");
                return OpeCur.AjaxMsgNOOK(Resource.SetFail + ErrorCol);
            }

        }
        #endregion

    }
}