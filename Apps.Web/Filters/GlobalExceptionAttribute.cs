using Apps.Models.Common;
using Apps.Web.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apps.Web.Filters
{
    public class GlobalExceptionAttribute:System.Web.Mvc.HandleErrorAttribute
    {
        private OperationContext opeCur = new OperationContext();
        public override void OnException(System.Web.Mvc.ExceptionContext filterContext)
        {
            filterContext.Result = SendMsg(filterContext.Exception, "/Account/Index");
            filterContext.ExceptionHandled = true;
        }

    
        System.Web.Mvc.ActionResult SendMsg(Exception ex, string strBackUrl)
        {
            if (opeCur.Request.Headers.AllKeys.Contains("X-Requested-With"))
            {
                return opeCur.AjaxMsgError(ex, strBackUrl);
            }
            else
            {
                return opeCur.JsMsg(ex.Message, strBackUrl);
            }
        }

    }
}