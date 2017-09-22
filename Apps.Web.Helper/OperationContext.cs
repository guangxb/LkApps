using Apps.Common;
using Apps.IService;
using Apps.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace Apps.Web.Helper
{
    
    public class OperationContext
    {

        //0.0 常量
        /// <summary>
        /// 用户Session键
        /// </summary>
        public const string ACCOUNT_SESSION_KEY = "uinfo";
        /// <summary>
        /// 用户权限集合Session键
        /// </summary>
        public const string USER_PER_SESSION_KEY = "upers";
        /// <summary>
        /// 用户id Cookie键
        /// </summary>
        public const string USERID_COOKIE_KEY = "ui";

        #region 1.0 操作上下文对象 +OperationContext Current
        /// <summary>
        /// 操作上下文对象
        /// </summary>
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
        #endregion

        //-------------------业务仓储 属性 ------------------
        #region 1.0 业务仓储 +IServiceSession ServiceSession
        /// <summary>
        /// 1.0 业务仓储 
        /// </summary>
        /// 
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
        #endregion

        #region 1.0 业务仓储 +IServiceSession SCVServiceSession
        /// <summary>
        /// 1.0 SCV业务仓储 
        /// </summary>
        /// 
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
        #endregion

        //-------------------Http 各种属性 的便捷访问------------------
        #region Http 各种属性 的便捷访问
        public HttpContext ContextHttp
        {
            get
            {
                return HttpContext.Current;
            }
        }
        public HttpSessionState Session
        {
            get
            {
                return ContextHttp.Session;
            }
        }

        public HttpResponse Response
        {
            get
            {
                return ContextHttp.Response;
            }
        }

        public HttpRequest Request
        {
            get
            {
                return ContextHttp.Request;
            }
        }
        #endregion

        //--------------------------------通用返回消息方法--------------------
        #region 1.0 返回 针对Ajax 的统一格式的消息字符串（JSON）+AjaxMsg(AjaxMsgStatu statu, string strMsg, string strBackUrl, object data = null)
        /// <summary>
        /// 1.0 返回 针对Ajax 的统一格式的消息字符串（JSON）
        /// </summary>
        /// <param name="statu"></param>
        /// <param name="strMsg"></param>
        /// <param name="strBackUrl"></param>
        /// <param name="data"></param>
        /// <returns></returns>
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
        }
        #endregion

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

        #region 2.0 返回 js 提示 和 跳转 代码片段 +ContentResult JsMsg(string strMsg, string strBackUrl = "")
        /// <summary>
        /// 2.0 返回 js 提示 和 跳转 代码片段
        /// </summary>
        /// <param name="strMsg">消息</param>
        /// <param name="strBackUrl">跳转页面的url</param>
        /// <returns></returns>
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
        #endregion

        //--------------------公共属性方法-------------------
        #region 1.0 操作Session中的登录用户对象 + MODEL.Employee UsrNow
        /// <summary>
        /// 1.0 操作Session中的登录用户对象
        /// </summary>
        public Apps.Models.AccountModel AccountNow
        {
            get
            {
                return Session[ACCOUNT_SESSION_KEY] as Models.AccountModel;
            }
            set
            {
                Session[ACCOUNT_SESSION_KEY] = value;
            }
        }
        #endregion

        #region 1.1 操作Session中的登录用户的权限集合
        /// <summary>
        /// 1.1 操作Session中的登录用户的权限集合
        /// </summary>
        public List<Apps.Models.PermissionModel> UsrNowPers
        {
            get
            {
                return Session[USER_PER_SESSION_KEY] as List<Apps.Models.PermissionModel>;
            }
            set
            {
                Session[USER_PER_SESSION_KEY] = value;
            }
        }
        #endregion

        #region 1.2 检查 当前登录用户 是否有 访问权限 + bool HasPermission
        /// <summary>
        /// 1.2 检查 当前登录用户 是否有 访问权限
        /// </summary>
        /// <param name="strAreaName">当前访问的区域名</param>
        /// <param name="strControllerName">当前访问的控制器名</param>
        /// <param name="strActionName">当前访问的Action方法名</param>
        /// <param name="strFormMethod">当前的请求方式(GET/POST)</param>
        /// <returns></returns>
        public bool HasPermission(string strAreaName, string strControllerName, string strActionName, string strFormMethod)
        {
            return GetUsrPermission(strAreaName, strControllerName, strActionName, strFormMethod) != null;
        }
        #endregion

        #region 1.3 根据url 获取 当前登录用户 权限对象 +Permission GetUsrPermission(string strAreaName, string strControllerName, string strActionName, string strFormMethod)
        /// <summary>
        /// 1.3 根据url 获取 当前登录用户 权限对象
        /// </summary>
        /// <param name="strAreaName">当前访问的区域名</param>
        /// <param name="strControllerName">当前访问的控制器名</param>
        /// <param name="strActionName">当前访问的Action方法名</param>
        /// <param name="strFormMethod">当前的请求方式(GET/POST)</param>
        /// <returns></returns>
        public Apps.Models.PermissionModel GetUsrPermission(string strAreaName, string strControllerName, string strActionName, string strFormMethod)
        {
            int formMethod = strFormMethod.ToLower() == "get" ? 1 : 2;

            //从登录用户的 session里保存的 权限集合中 查找 匹配的权限
            var curPer = UsrNowPers.SingleOrDefault(o => (o.AreasName.IsSame(strAreaName))//请求区域名一样
                 && o.ControllerName.IsSame(strControllerName)//请求控制器名一样
                 && o.ActionName.IsSame(strActionName)//请求Action方法名一样
                 && (o.FormMethod == 3 ? true : (o.FormMethod == formMethod))//浏览器请求类型一样
                 );
            return curPer;
        }
        #endregion
    }
}
