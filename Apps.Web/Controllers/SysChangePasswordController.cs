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
    public class SysChangePasswordController : Apps.Web.Core.BaseController
    {
        // GET: SysChangePassword
        ValidationErrors errors = new ValidationErrors();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetList(GridPager pager, string queryStr)
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
            List<SysUserModel> list = serviceSession.SysUser.GetUsrList(ref pager, queryStr,u=>u.Id == OpeCur.AccountNow.Id);

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
        public JsonResult ReSet(string Id, string pwd)
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;

            if (ValueConvert.MD5(pwd) == OpeCur.AccountNow.Password) {
                return OpeCur.AjaxMsgNOOK(Resource.EditFail + "密码不能和当前密码相同");
            }
            serviceSession.SysUser.EditPwd(ref errors, Id, pwd);
            string ErrorCol = errors.Error;
            if (serviceSession.SaveChange() > 0)
            {
                LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Id:" + Id + ",密码:********", "成功", "初始化密码", "用户设置");
                //Session.Abandon();
                //Session.Clear();
                return OpeCur.AjaxMsgOK(Resource.EditSucceed + ErrorCol);
            }
            else
            {

                LogHandler.WriteServiceLog(OpeCur.AccountNow.Id, "Id:" + Id + ",,密码:********" + ErrorCol, "失败", "初始化密码", "用户设置");
                return OpeCur.AjaxMsgNOOK(Resource.EditFail + ErrorCol);
            }
        }
    }
}