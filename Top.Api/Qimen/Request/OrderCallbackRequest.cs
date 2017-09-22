using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.order.callback
    /// </summary>
    public class OrderCallbackRequest : QimenRequest<Qimen.Api.Response.OrderCallbackResponse>
    {
        /// <summary>
        /// 奇门仓储字段,C123,string(50),,
        /// </summary>
        public string DeliveryOrderCode { get; set; }

        /// <summary>
        /// 奇门仓储字段,C123,string(50),,
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 奇门仓储字段,C123,string(50),,
        /// </summary>
        public string OwnerCode { get; set; }

        /// <summary>
        /// 奇门仓储字段,C123,string(50),,
        /// </summary>
        public string WarehouseCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.order.callback";
        }


        #endregion
    }
}
