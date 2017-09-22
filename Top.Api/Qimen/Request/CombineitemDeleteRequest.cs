using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.combineitem.delete
    /// </summary>
    public class CombineitemDeleteRequest : QimenRequest<Qimen.Api.Response.CombineitemDeleteResponse>
    {
        /// <summary>
        /// 奇门仓储字段,C123,string(50),,
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// 奇门仓储字段,C123,string(50),,
        /// </summary>
        public string OwnerCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.combineitem.delete";
        }


        #endregion
    }
}
