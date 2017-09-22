using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// DeliveryorderBatchcreateResponse.
    /// </summary>
    public class DeliveryorderBatchcreateResponse : QimenResponse
    {
        /// <summary>
        /// 订单详情
        /// </summary>
        [XmlArray("orders")]
        [XmlArrayItem("order")]
        public List<OrderDomain> Orders { get; set; }

	/// <summary>
/// OrderDomain Data Structure.
/// </summary>
[Serializable]

public class OrderDomain : TopObject
{
	        /// <summary>
	        /// 出错的出库单号
	        /// </summary>
	        [XmlElement("deliveryOrderCode")]
	        public string DeliveryOrderCode { get; set; }
	
	        /// <summary>
	        /// 出错信息
	        /// </summary>
	        [XmlElement("message")]
	        public string Message { get; set; }
}

    }
}
