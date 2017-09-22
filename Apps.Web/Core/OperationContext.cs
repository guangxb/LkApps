using Apps.Common;
using Apps.IService;
using Apps.Models;
using Apps.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Apps.Web.Core
{
    
    public class OperationContext
    {

    
        public const string ACCOUNT_SESSION_KEY = "uinfo";
    
        public const string USER_PER_SESSION_KEY = "upers";
    
        public const string USERID_COOKIE_KEY = "ui";

        public const string USERNAME_SESSIONID = "UserNameSessionId.";

        public static OperationContext Current
        {
            get
            {
                var opeContext = CallContext.GetData(typeof(OperationContext).FullName) as OperationContext;
                if (opeContext == null)
                {
                    opeContext = new OperationContext();
                    CallContext.SetData(typeof(OperationContext).FullName, opeContext);
                }
                return opeContext;
            }
        }

       
        private IServiceSession _serviceSession;
        public IServiceSession ServiceSession
        {
            get
            {
                if (_serviceSession == null)
                {
                    //_serviceSession = DependencyResolver.Current.GetService<IServiceSession>();
                    _serviceSession = DI.GetObject<IService.IServiceSession>("ServiceSession");
                }
                return _serviceSession;
            }
        }

 
        private Apps.IService.SCV.ISCVServiceSession _SCVServiceSession;
        public Apps.IService.SCV.ISCVServiceSession SCVServiceSession
        {
            get
            {
                if (_SCVServiceSession == null)
                {
                    //_SCVServiceSession = DependencyResolver.Current.GetService<Apps.IService.SCV.ISCVServiceSession>();
                    _SCVServiceSession = DI.GetObject<IService.SCV.ISCVServiceSession>("SCVServiceSession");
                }
                return _SCVServiceSession;
            }
        } 

        #region Http 各种属性 的便捷访问
        //public HttpContext ContextHttp
        //{
        //    get
        //    {
        //        return HttpContext.Current;
        //    }
        //}
        //public HttpSessionState Session
        //{
        //    get
        //    {
        //        return ContextHttp.Session;
        //    }
        //}

        public HttpResponse Response
        {
            get
            {
                return HttpContext.Current.Response;
            }
        }

        public HttpRequest Request
        {
            get
            {
                return HttpContext.Current.Request;
            }
        }
        #endregion

     
        public JsonResult AjaxMsg(AjaxMsgStatu statu, string strMsg, string strBackUrl="", object data = null)
        {
            AjaxMsg msgObj = new AjaxMsg()
            {
                Status = statu,
                Msg = strMsg,
                BackUrl = strBackUrl,
                Data = data


            };
            return new ToJsonResult()
            {
                Data = msgObj,
                FormateStr = "yyyy-MM-dd HH:mm:ss",
            };
            //return new JsonResult()
            //{
            //    Data = msgObj,
            //    JsonRequestBehavior = JsonRequestBehavior.AllowGet
            //};
        }

        #region 1.0.1 返回各种消息的 快捷方法 AjaxMsgOK，AjaxMsgNOOK，AjaxMsgError 等
        public JsonResult AjaxMsgOK(string strMsg = "操作成功~", string strBackUrl = "", object data = null)
        {
            return AjaxMsg(AjaxMsgStatu.Ok, strMsg, strBackUrl, data);
        }

        public JsonResult AjaxMsgNOOK(string strMsg = "操作失败~", string strBackUrl = "", object data = null)
        {
            return AjaxMsg(AjaxMsgStatu.NoOk, strMsg, strBackUrl, data);
        }

        public JsonResult AjaxMsgError(string strMsg = "操作异常~", string strBackUrl = "", object data = null)
        {
            return AjaxMsg(AjaxMsgStatu.Error, strMsg, strBackUrl, data);
        }

        public JsonResult AjaxMsgError(Exception ex, string strBackUrl = "", object data = null)
        {
            return AjaxMsg(AjaxMsgStatu.Error, ex.Message, strBackUrl, data);
        }

        public JsonResult AjaxMsgNoLogin(string strBackUrl = "", object data = null)
        {
            return AjaxMsg(AjaxMsgStatu.NoLogin, "尚未登录!", strBackUrl, data);
        }

        public JsonResult AjaxMsgNoPermission(string strBackUrl = "", object data = null)
        {
            return AjaxMsg(AjaxMsgStatu.NoPermission, "您没有访问此操作的权限!", strBackUrl, data);
        }
        #endregion

    
        public ContentResult JsMsg(string strMsg, string strBackUrl = "")
        {
            System.Text.StringBuilder sbJs = new System.Text.StringBuilder("<script src=\"../../Scripts/jquery.min.js\"></script><script src=\"../../Content/layer/layer.js\"></script><script>layer.alert(\"").Append(strMsg).Append("\",{icon:0,closeBtn: 0,skin:\"layer-ext-moon\"},function(){layer.closeAll();");
            if (!strBackUrl.IsNullOrEmpty())
            {
                sbJs.Append("if(window.top == window)window.location=\"").Append(strBackUrl).Append("\";").Append("else window.top.location =\"").Append(strBackUrl).Append("\";");
            }
            sbJs.Append("})</script>");
            return new ContentResult()
            {
                Content = sbJs.ToString()
            };
        }

        //public Apps.Models.AccountModel SessionAccountNow {
        //    get {
        //        return HttpContext.Current.Session[ACCOUNT_SESSION_KEY] as Apps.Models.AccountModel;
        //    }
        //    set {
        //        HttpContext.Current.Session[ACCOUNT_SESSION_KEY] = value;
        //    }
        //}



        public Apps.Models.AccountModel AccountNow
        {
            get
            {
                //Apps.Models.AccountModel redisValue;
                //using (var client = RedisManager.ClientManager.GetClient())
                //{
                //    redisValue = client.Get<Apps.Models.AccountModel>(SessionAccountNow.Id + "Account");
                //}
                //return redisValue;
                return HttpContext.Current.Session[ACCOUNT_SESSION_KEY] as Apps.Models.AccountModel;
            }
            set
            {
                //Apps.Models.AccountModel redisValue = value;
                //using (var client = RedisManager.ClientManager.GetClient())
                //{
                //    client.Set<Apps.Models.AccountModel>(SessionAccountNow.Id + "Account", redisValue);
                //}
                HttpContext.Current.Session[ACCOUNT_SESSION_KEY] = value;
            }
        }

        public string[] UsrHasMerchantCode
        {
            get
            {
                string[] redisValue;
                using (var client = RedisManager.ClientManager.GetClient())
                {
                    redisValue = client.Get<string[]>(AccountNow.Id + "HMC");
                }
                return redisValue;

                //return HttpContext.Current.Session[ACCOUNT_SESSION_KEY] as Apps.Models.AccountModel;
            }
            set
            {
                string[] redisValue = value;
                using (var client = RedisManager.ClientManager.GetClient())
                {
                    client.Set<string[]>(AccountNow.Id + "HMC", redisValue);
                }
                //HttpContext.Current.Session[ACCOUNT_SESSION_KEY] = value;
            }
        }


        public List<Apps.Models.PermissionModel> UsrNowPers
        {
            get
            {
                List<Apps.Models.PermissionModel> redisValue;
                using (var client = RedisManager.ClientManager.GetClient())
                {
                   redisValue = client.Get<List<Apps.Models.PermissionModel>>(AccountNow.Id + "Pers");
                }
                return redisValue;
                //return HttpContext.Current.Session[USER_PER_SESSION_KEY] as List<Apps.Models.PermissionModel>;
            }
            set
            {
                List<Apps.Models.PermissionModel> redisValue = value;
                using (var client = RedisManager.ClientManager.GetClient())
                {
                    client.Set<List<Apps.Models.PermissionModel>>(AccountNow.Id + "Pers", redisValue);
                }
                //HttpContext.Current.Session[USER_PER_SESSION_KEY] = value;
            }
        }

        public void SetOtherHMC(string userId)
        {
            using (var client = RedisManager.ClientManager.GetClient())
            {
                client.Set<string[]>(userId + "HMC", Current.ServiceSession.SysUser.GetAccountByUserId(userId).HasMerchantCode);
            }
        }

        public void SetOtherUsrPers(string userId) {
            
            using (var client = RedisManager.ClientManager.GetClient())
            {
                client.Set<List<Apps.Models.PermissionModel>>(userId + "Pers", Current.ServiceSession.SysUser.GetUserPermission(userId));
            }
        }

        public void SetRedisSession() {
            using (var client = RedisManager.ClientManager.GetClient())
            {
                client.Set<string>(USERNAME_SESSIONID + AccountNow.UserName, HttpContext.Current.Session.SessionID);
            }
        }



        public bool HasPermission(string strAreaName, string strControllerName, string strActionName, string strFormMethod)
        {
            return GetUsrPermission(strAreaName, strControllerName, strActionName, strFormMethod) != null;
        }

    
        public Apps.Models.PermissionModel GetUsrPermission(string strAreaName, string strControllerName, string strActionName, string strFormMethod)
        {
            int formMethod = strFormMethod.ToLower() == "get" ? 1 : 2;

            var curPer = UsrNowPers.FirstOrDefault(o => (o.AreasName.IsSame(strAreaName))
                 && o.ControllerName.IsSame(strControllerName)
                 && o.ActionName.IsSame(strActionName)
                 && (o.FormMethod == 3 ? true : (o.FormMethod == formMethod))
                 );
            return curPer;
        }
    }
}
