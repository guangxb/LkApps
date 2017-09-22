using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.expressinfo.query
    /// </summary>
    public class ExpressinfoQueryRequest : QimenRequest<Qimen.Api.Response.ExpressinfoQueryResponse>
    {
        /// <summary>
        /// 奇门仓储字段
        /// </summary>
        public string ExpressCode { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        /// <summary>
        /// 奇门仓储字段
        /// </summary>
        public string OwnerCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.expressinfo.query";
        }


        #endregion
    }
}
