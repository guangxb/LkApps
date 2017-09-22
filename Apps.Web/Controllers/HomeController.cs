using Apps.Common;
using Apps.Common.Attrs;
using Apps.IService.Sys;
using Apps.Models;
using Apps.Models.Sys;
using Apps.Web.Helper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Apps.Web.Controllers
{
    
    public class HomeController : Apps.Web.Core.BaseController
    {
        // GET: Home
        ValidationErrors errors = new ValidationErrors();
        public ActionResult Index()
        {

            if (OpeCur.AccountNow != null)
            {
                SysConfigModel siteConfig = OpeCur.ServiceSession.SysConfig.LoadConfig(Utils.GetXmlMapPath("Configpath"));
                ViewBag.IsEnable = siteConfig.webimstatus;
                ViewBag.NewMesTime = siteConfig.refreshnewmessage;
                ViewBag.WebName = siteConfig.webname;
                ViewBag.ComName = siteConfig.webcompany;
                ViewBag.CopyRight = siteConfig.webcopyright;
   
                return View(OpeCur.AccountNow);
            }
            else
            {
                return RedirectToAction("Index","Account");
            }
        }

        /// <summary>
        /// 顶部模块菜单
        /// </summary>
        /// <returns></returns>
        [HttpPost, SkipPermission]
        public JsonResult GetTopMenu()
        {
            //加入本地化
            CultureInfo info = Thread.CurrentThread.CurrentCulture;
            string infoName = info.Name;
            if (OpeCur.AccountNow != null)
            {
                //加入本地化
                AccountModel account = OpeCur.AccountNow;
                List<PermissionModel> list = OpeCur.UsrNowPers.Where(p=>p.ParentId == "0"&& p.OperationType==1).ToList();
                var json = from r in list
                           select new SysModuleNavModel()
                           {
                               id = r.Id,
                               text = infoName.IndexOf("zh") > -1 || infoName == "" ? r.Name : r.EnglishName,     //text
                               attributes = (infoName.IndexOf("zh") > -1 || infoName == "" ? "zh-CN" : "en-US") + "/" + r.AreasName == null ? "" : (r.AreasName + "/") + r.ControllerName + "/" + r.ActionName,
                               iconCls = r.Iconic
                           };
                //return Json(json);
                return OpeCur.AjaxMsgOK("成功获取", "", json);
            }
            else
            {
                return OpeCur.AjaxMsgNoLogin("/Account");
            }
        }

        [HttpPost, SkipPermission]
        public JsonResult GetTreeByEasyui(string id)
        {
            //加入本地化
            CultureInfo info = Thread.CurrentThread.CurrentCulture;
            string infoName = info.Name;
            if (OpeCur.AccountNow != null)
            {
                //加入本地化
                AccountModel account = OpeCur.AccountNow;
                //OpeCur.UsrNowPers.Where(p=>p.ParentId == "0").ToList();
                List<PermissionModel> list = OpeCur.UsrNowPers.Where(p => p.ParentId == id && (p.OperationType == 1 ||p.OperationType==2)).ToList();
                var json = from r in list
                           select new SysModuleNavModel()
                           {
                               id = r.Id,
                               text = infoName.IndexOf("zh") > -1 || infoName == "" ? r.Name : r.EnglishName,     //text
                               attributes = (infoName.IndexOf("zh") > -1 || infoName == "" ? "zh-CN" : "en-US") + "/" + r.AreasName == null ? "" : (r.AreasName + "/") + r.ControllerName + "/" + r.ActionName,
                               iconCls = r.Iconic,
                               //state = (list.Where(p=>p.ParentId==r.Id).Count() > 0) ? "closed" : "open"
                               //state = (OpeCur.ServiceSession.SysModule.GetList(m => m.ParentId == r.Id).Count > 0) ? "closed" : "open"
                               state = r.State,
                           };

                //return Json(json);
                return OpeCur.AjaxMsgOK("成功获取", "", json);
            }
            else
            {
                return OpeCur.AjaxMsgNoLogin("/Account/Index");
            }
        }
        [HttpPost, SkipPermission]
        public JsonResult SetThemes(string theme, string menu, bool topmenu)
        {
            ISysUserConfigService userConfigService = OpeCur.ServiceSession.SysUserConfig;
            string userId = OpeCur.AccountNow.Id;
            SysUserConfigModel entity = userConfigService.GetById("themes", userId);
            

            if (entity != null)
            {
                entity.Value = theme;
                entity.Name = "用户自定义主题";
                userConfigService.Modify(ref errors, entity,"Value");

               
            }
            else
            {
                entity = new SysUserConfigModel()
                {
                    Name = "用户自定义主题",
                    Value = theme,
                    Type = "themes",
                    State = true,
                    UserId = userId
                };
                userConfigService.Create(ref errors, entity);
            }

            Session["themes"] = theme;

            //开启顶部菜单，顶部菜单必须配置多一层
            if (topmenu)
            {
                menu = menu + ",topmenu";
            }
            SysUserConfigModel entityMenu = userConfigService.GetById("menu", userId);
            if (entityMenu != null)
            {
                entityMenu.Value = menu;
                userConfigService.Modify(ref errors, entityMenu, "Value");
            }
            else
            {
                entityMenu = new SysUserConfigModel()
                {
                    Name = "用户自定义菜单",
                    Value = menu,
                    Type = "menu",
                    State = true,
                    UserId = userId
                };
                userConfigService.Create(ref errors, entityMenu);
            }
            Session["menu"] = menu;

            OpeCur.ServiceSession.SaveChange();

            return Json("1", JsonRequestBehavior.AllowGet);
        }
        [SkipPermission]
        public ActionResult TopInfo()
        {
            if (OpeCur.AccountNow != null)
            {
                return View(OpeCur.AccountNow);
            }
            return View();
        }

        #region js配置
        [SkipPermission]
        public JavaScriptResult ConfigJs()
        {
            CultureInfo info = Thread.CurrentThread.CurrentCulture;
            StringBuilder sb = new StringBuilder();
            sb.Append("var _YMGlobal;");
            sb.Append("(function(_YMGlobal) {");
            sb.Append("    var Config = (function() {");
            sb.Append("        function Config() {}");
            sb.AppendFormat("  Config.currentCulture = '{0}';", info.Name);
            sb.AppendFormat("  Config.apiUrl = '{0}';", "");
            sb.AppendFormat("  Config.token = '{0}';", "");
            sb.Append("       return Config;");
            sb.Append("   })();");
            sb.Append("   _YMGlobal.Config = Config;");
            sb.Append(" })(_YMGlobal || (_YMGlobal = { }));");

            return JavaScript(sb.ToString());
        }

        #endregion
        [SkipPermission]
        public ActionResult Desktop()
        {
            return View();
        }
    }
}