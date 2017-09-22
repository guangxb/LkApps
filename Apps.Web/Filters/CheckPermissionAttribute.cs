using Apps.Models.Common;
using Apps.Web.Core;
using Apps.Web.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Apps.Web.Filters
{
    public class CheckPermissionAttribute : System.Web.Mvc.AuthorizeAttribute
    {
        private OperationContext opeCur = OperationContext.Current;

        /// <summary>
        /// 区域黑名单
        /// </summary>
        //List<string> blackAreaNames = new List<string>() { "admin" };

        public override void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext)
        {
            string strCurAreaName = null;
            if (filterContext.RouteData.DataTokens.ContainsKey("area"))
            {
                strCurAreaName = filterContext.RouteData.DataTokens["area"].ToString().ToLower();
            }

  
            if (!IsDefind<Apps.Common.Attrs.SkipLoginAttribute>(filterContext))
            {
                if (IsLogin())
                {
                    Apps.Models.PermissionModel curPer = LoadMenuBtns(filterContext);
                    if (!IsDefind<Apps.Common.Attrs.SkipPermissionAttribute>(filterContext))
                    {
                        if (curPer==null)
                        {
                            filterContext.Result = SendMsg(AjaxMsgStatu.NoPermission,"您没有进行此项操作的权限");
                        }
                    }
                }
                else
                {
                    filterContext.Result = SendMsg(AjaxMsgStatu.NoLogin,"您尚未登录", "/Account/Index");
                }
            }
        }

 
        private bool IsLogin()
        {
            return HttpContext.Current.Session["uinfo"] != null;
            //return (opeCur.AccountNow != null);
        }

     
        bool IsDefind<AttrType>(System.Web.Mvc.AuthorizationContext filterContext)
        {
            Type attrTypeObj = typeof(AttrType);
            return filterContext.ActionDescriptor.IsDefined(attrTypeObj, false)
                || filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(attrTypeObj, false);
        }

      
        System.Web.Mvc.ActionResult SendMsg(AjaxMsgStatu Status,string strMsg, string strBackUrl = "")
        {
            if (opeCur.Request.Headers.AllKeys.Contains("X-Requested-With"))
            {
                return opeCur.AjaxMsg(Status,strMsg, strBackUrl);
            }
            else
            {
                return opeCur.JsMsg(strMsg, strBackUrl);
            }
        }

     
        Apps.Models.PermissionModel LoadMenuBtns(System.Web.Mvc.AuthorizationContext filterContext)
        {
            string strCurAreaName = null;
            if (filterContext.RouteData.DataTokens.ContainsKey("area"))
            {
                strCurAreaName = filterContext.RouteData.DataTokens["area"].ToString().ToLower();
            }
            string strControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string strActionName = filterContext.ActionDescriptor.ActionName;
            Apps.Models.PermissionModel curPer = opeCur.GetUsrPermission(strCurAreaName, strControllerName, strActionName, opeCur.Request.HttpMethod);
            if (curPer != null)
            {
                var sonBtns = opeCur.UsrNowPers.Where(o => o.ParentId == curPer.Id && o.OperationType == 3).OrderBy(o => o.Sort).ToList();
                //if (sonBtns.Count==0) { 
                    if (curPer.OperationType == 3) {
                        sonBtns.Add(curPer);
                    //}
                    filterContext.Controller.ViewBag.sonBtns = sonBtns;
                    //filterContext.Controller.ViewBag.sonBtns = emptyBtns;
                }
                else
                    filterContext.Controller.ViewBag.sonBtns = sonBtns;
                return curPer;
            }
            else
            {
                filterContext.Controller.ViewBag.sonBtns = emptyBtns;
                return curPer;
            }
        }

        static List<Apps.Models.PermissionModel> emptyBtns = new List<Apps.Models.PermissionModel>();
    }
}