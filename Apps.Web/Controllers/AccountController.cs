using Apps.Common;
using Apps.Common.Attrs;
using Apps.Locale;
using Apps.Models;
using Apps.Models.Sys;
using Apps.Web.Core;
using Apps.Web.Helper;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apps.Web.Controllers
{
    [SkipLogin]
    public class AccountController : BaseController
    {
        // GET: Account
        
        public ActionResult Index()
        {
            if (Session["uinfo"] != null) {
                return RedirectToAction("Index","Home");
            }
            SysConfigModel siteConfig = OpeCur.ServiceSession.SysConfig.LoadConfig(Common.Utils.GetXmlMapPath("ConfigPath"));
            //系统名称

            ViewBag.WebName = siteConfig.webname;
            //公司名称
            ViewBag.ComName = siteConfig.webcompany;
            //
            ViewBag.CopyRight = siteConfig.webcopyright;

            return View();
        }

        [HttpPost]
        public JsonResult Login(Apps.Models.ViewModel.LoginModel usrLoginModel)
        {

            string userAgent = HttpContext.Request.UserAgent.ToLower();//compatible
            if ((userAgent.Contains("mozilla/4.0") || userAgent.Contains("compatible") || userAgent.Contains("msie 7.0") || userAgent.Contains("msie 6.0")|| userAgent.Contains("msie 8.0")|| userAgent.Contains("msie 9.0")))
            {
                return OpeCur.AjaxMsgNOOK(Resource.BrowserCompatibility);
            }

            if (ModelState.IsValid)
            {
                if (Session["VCode"] != null && usrLoginModel.LoginCode.IsSame(Session["VCode"].ToString()))
                {
                    string loginName = usrLoginModel.LoginName;
                    AccountModel account = OpeCur.ServiceSession.SysUser.GetAccountByUserName(loginName);

                    if (account == null)
                    {
                        return OpeCur.AjaxMsgNOOK("用户名错误！");
                    }
                    else if (!Convert.ToBoolean(account.State))//被禁用
                    {
                        return OpeCur.AjaxMsgNOOK("账户被禁用！");
                    }
                    else
                    {
                        if (account.Password.IsSame(ValueConvert.MD5(usrLoginModel.Password)))
                        {
                            //AccountModel account = new AccountModel();
                            //account.Id = usr.Id;
                            //account.UserName = usr.UserName;
                            //account.TrueName = usr.TrueName;
                            //account.Photo = string.IsNullOrEmpty(usr.Photo) ? "/Images/Photo.jpg" : usr.Photo;
                            //OpeCur.AccountNow = account;
                            //Session["uinfo"] = account;
                            GetThemes(account.Id);
                            OpeCur.AccountNow = account;
                            OpeCur.UsrHasMerchantCode = account.HasMerchantCode;
                            OpeCur.UsrNowPers = OpeCur.ServiceSession.SysUser.GetUserPermission(account.Id);
                            OpeCur.SetRedisSession();
                            LogHandler.WriteServiceLog(account.UserName, ResultHelper.NowTime + "登录系统,IP:" + ResultHelper.GetUserIP(), "成功", "登录", "系统入口");
                            OpeCur.ServiceSession.SaveChange();
                            return OpeCur.AjaxMsgOK("登录成功了！", "/Home/index");
                        }
                        //d.2 登录失败
                        else
                        {
                            return OpeCur.AjaxMsgNOOK("登录密码错误！");
                        }
                    }
                }
                else
                {
                    return OpeCur.AjaxMsgNOOK("验证码输入错误！");
                }
            }
            else
            {
                return OpeCur.AjaxMsgNOOK(Resource.ModelStateValidFail);
            }
        }

        [HttpGet]
        public ActionResult LogOut()
        {
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Index", "Account");
        }

        [HttpPost]
        public void GetThemes(string userid)
        {
            SysUserConfigModel entity = OpeCur.ServiceSession.SysUserConfig.GetById("themes", userid);
            SysUserConfigModel menuEntity = OpeCur.ServiceSession.SysUserConfig.GetById("menu", userid);
            if (entity != null)
            {
                Session["themes"] = entity.Value;
            }
            else
            {
                Session["themes"] = "blue";
            }
            if (menuEntity != null)
            {
                Session["menu"] = menuEntity.Value;
            }
            else
            {
                Session["menu"] = "accordion,topmenu";
            }
        }
    }
}