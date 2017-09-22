using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace Apps.WebApi.Core
{
    public class ApiOperationContext
    {
        #region 操作上下文对象 +ApiOperationContext Current
        /// <summary>
        /// 操作上下文对象
        /// </summary>
        public static ApiOperationContext Current
        {
            get
            {
                var opeContext = CallContext.GetData(typeof(ApiOperationContext).FullName) as ApiOperationContext;
                if (opeContext == null)
                {
                    opeContext = new ApiOperationContext();
                    CallContext.SetData(typeof(ApiOperationContext).FullName, opeContext);
                }
                return opeContext;
            }
        }
        #endregion

        //-------------------业务仓储 属性 ------------------
        #region 业务仓储 +IServiceSession ServiceSession
        /// <summary>
        /// 业务仓储 
        /// </summary>
        /// 
        private Apps.IService.IServiceSession _serviceSession;
        public Apps.IService.IServiceSession ServiceSession
        {
            get
            {
                if (_serviceSession == null)
                {
                    //_serviceSession = DependencyResolver.Current.GetService<IServiceSession>();
                    _serviceSession = Apps.Common.DI.GetObject<IService.IServiceSession>("ServiceSession");
                }
                return _serviceSession;
            }
        }
        #endregion

        #region 业务仓储 +IServiceSession SCVServiceSession
        /// <summary>
        ///  SCV业务仓储 
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
                    _SCVServiceSession = Apps.Common.DI.GetObject<IService.SCV.ISCVServiceSession>("SCVServiceSession");
                }
                return _SCVServiceSession;
            }
        }
        #endregion
    }
}