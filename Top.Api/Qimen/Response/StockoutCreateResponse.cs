using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// StockoutCreateResponse.
    /// </summary>
    public class StockoutCreateResponse : QimenResponse
    {
        /// <summary>
        /// 订单创建时间(YYYY-MM-DD HH:MM:SS)
        /// </summary>
        [XmlElement("createTime")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 出库单仓储系统编码
        /// </summary>
        [XmlElement("deliveryOrderId")]
        public string DeliveryOrderId { get; set; }

    }
}
