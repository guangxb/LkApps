using Apps.Common;
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
    public class SysRoleController : BaseController
    {
        ValidationErrors errors = new ValidationErrors();
        // GET: SysRole
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetRoleList(GridPager pager, string queryStr)
        {
            var time = DateTime.Now;
            List<Apps.Models.Sys.SysRoleModel> list = OpeCur.ServiceSession.SysRole.GetList(ref pager, queryStr);

            var json = new
            {
                total = pager.totalRows,
                rows = list,
            };
            if (list.Count <= 0) {
                return OpeCur.AjaxMsgNOOK("没有符合条件的数据", "", json);
            }

            return OpeCur.AjaxMsgOK("查询成功","",json);
        }

        #region 设置角色用户
        public ActionResult AssignUser(string roleId)
        {
            ViewBag.RoleId = roleId;

            StructHelper helper = new StructHelper();
            ViewBag.StructTree = helper.GetStructTree(true);
            return View();
        }
        [HttpPost]
        public JsonResult AssignUser(string roleId, List<AssignUserModel> users)
        {
            //string[] arr = userIds.Split(',');
            OpeCur.ServiceSession.SysRole.UpdateSysRoleSysUser(roleId, users);

            if (OpeCur.ServiceSession.SaveChange() > 0)
            {
                foreach (var usr in users) {
                    OpeCur.SetOtherUsrPers(usr.UserId);
                }
                LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Ids:" + "", "成功", "分配用户", "角色设置");
                return OpeCur.AjaxMsgOK(Resource.SetSucceed);
                //return Json(JsonHandler.CreateMessage(1, Resource.SetSucceed), JsonRequestBehavior.AllowGet);
            }
            else
            {
                LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Ids:" + "", "失败", "分配用户", "角色设置");
                return OpeCur.AjaxMsgOK(Resource.SetFail);
                //return Json(JsonHandler.CreateMessage(0, Resource.SetFail), JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public JsonResult GetUserListByRole(GridPager pager, string roleId, string depId, string queryStr)
        {
            if (string.IsNullOrWhiteSpace(roleId))
                return OpeCur.AjaxMsgNOOK("角色id为空");
            var userList = OpeCur.ServiceSession.SysRole.GetUserByRoleId(ref pager, roleId, depId, queryStr);

            var jsonData = new
            {
                total = pager.totalRows,
                rows = userList
            };
            return OpeCur.AjaxMsgOK("获取成功","",jsonData);
        }
        #endregion

        #region 创建
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create(SysRoleModel model)
        {
            model.Id = ResultHelper.NewId;
            model.CreateTime = ResultHelper.NowTime;
            string userId = OpeCur.AccountNow.Id;
            model.CreatePerson = userId;
            if (model != null && ModelState.IsValid)
            {
                if (model.Name.IsNullOrEmpty() || model.Description.IsNullOrEmpty()) {
                    return OpeCur.AjaxMsgNOOK("用户名和描述都不能为空！");
                }
                OpeCur.ServiceSession.SysRole.Create(ref errors, model);

                if(OpeCur.ServiceSession.SaveChange()>0)
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

            SysRoleModel entity = OpeCur.ServiceSession.SysRole.GetById(id);

            return View(entity);
        }

        [HttpPost]
        public JsonResult Edit(SysRoleModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                OpeCur.ServiceSession.SysRole.Modify(ref errors, model,"Name", "Description");
                if (OpeCur.ServiceSession.SaveChange()>0)
                {
                    LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Id" + model.Id + ",Name" + model.Name, "成功", "修改", "SysRole");
                    return OpeCur.AjaxMsgOK(Resource.EditSucceed);
                    //return Json(JsonHandler.CreateMessage(1, Resource.EditSucceed));
                }
                else
                {
                    string ErrorCol = errors.Error;
                    LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Id" + model.Id + ",Name" + model.Name + "," + ErrorCol, "失败", "修改", "SysRole");
                    return OpeCur.AjaxMsgNOOK(Resource.EditFail);
                    //return Json(JsonHandler.CreateMessage(0, Resource.EditFail + ":" + ErrorCol));
                }
            }
            else
            {
                return Json(JsonHandler.CreateMessage(0, Resource.EditFail));
            }
        }
        #endregion

        #region 删除
        [HttpPost]
        public JsonResult Remove(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var userId = OpeCur.AccountNow.Id;
                if (id == "administrator")
                {
                    LogHandler.WriteServiceLog(userId, "尝试删除管理员组", "失败", "删除", "用户设置");
                    return OpeCur.AjaxMsgNOOK("超级管理员组不能被删除");
                }

                OpeCur.ServiceSession.SysRole.RemoveById(ref errors, id);
                if (OpeCur.ServiceSession.SaveChange()>0)
                {
                    LogHandler.WriteServiceLog(userId, "Id:" + id, "成功", "删除", "SysRole");
                    return OpeCur.AjaxMsgOK(Resource.DeleteSucceed);
                }
                else
                {
                    string ErrorCol = errors.Error;
                    LogHandler.WriteServiceLog(userId, "Id" + id + "," + ErrorCol, "失败", "删除", "SysRole");
                    return OpeCur.AjaxMsgNOOK(Resource.DeleteFail);
                }
            }
            else
            {
                return OpeCur.AjaxMsgNOOK("Id为空");
            }

        }
        #endregion
    }
}