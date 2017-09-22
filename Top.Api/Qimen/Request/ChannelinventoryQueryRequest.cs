using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.channelinventory.query
    /// </summary>
    public class ChannelinventoryQueryRequest : QimenRequest<Qimen.Api.Response.ChannelinventoryQueryResponse>
    {
        /// <summary>
        /// 奇门仓储字段
        /// </summary>
        public string ChannelCodes { get; set; }

        /// <summary>
        /// 奇门仓储字段
        /// </summary>
        public string ItemCodes { get; set; }

        /// <summary>
        /// 奇门仓储字段,C123,string(50),,
        /// </summary>
        public string OwnerCode { get; set; }

        /// <summary>
        /// 奇门仓储字段
        /// </summary>
        public string WarehouseCodes { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.channelinventory.query";
        }


        #endregion
    }
}
