using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// DeliveryorderCreateResponse.
    /// </summary>
    public class DeliveryorderCreateResponse : QimenResponse
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

        /// <summary>
        /// 发货单信息
        /// </summary>
        [XmlArray("deliveryOrders")]
        [XmlArrayItem("deliveryOrder")]
        public List<DeliveryOrderDomain> DeliveryOrders { get; set; }

        /// <summary>
        /// 物流公司编码(统仓统配使用)
        /// </summary>
        [XmlElement("logisticsCode")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 仓库编码(统仓统配使用)
        /// </summary>
        [XmlElement("warehouseCode")]
        public string WarehouseCode { get; set; }

	/// <summary>
/// OrderLineDomain Data Structure.
/// </summary>
[Serializable]

public class OrderLineDomain : TopObject
{
	        /// <summary>
	        /// ERP商品编码
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// WMS商品编码
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 行号
	        /// </summary>
	        [XmlElement("orderLineNo")]
	        public string OrderLineNo { get; set; }
	
	        /// <summary>
	        /// 数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public string Quantity { get; set; }
}

	/// <summary>
/// DeliveryOrderDomain Data Structure.
/// </summary>
[Serializable]

public class DeliveryOrderDomain : TopObject
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
	
	        /// <summary>
	        /// 物流公司编码(统仓统配使用)
	        /// </summary>
	        [XmlElement("logisticsCode")]
	        public string LogisticsCode { get; set; }
	
	        /// <summary>
	        /// 订单信息
	        /// </summary>
	        [XmlArray("orderLines")]
	        [XmlArrayItem("orderLine")]
	        public List<OrderLineDomain> OrderLines { get; set; }
	
	        /// <summary>
	        /// 仓库编码(统仓统配使用)
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
}

    }
}
