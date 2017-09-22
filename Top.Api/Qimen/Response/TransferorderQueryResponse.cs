using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// TransferorderQueryResponse.
    /// </summary>
    public class TransferorderQueryResponse : QimenResponse
    {
        /// <summary>
        /// 调拨单细节
        /// </summary>
        [XmlElement("transferOrderDetail")]
        public TransferOrderDetailDomain TransferOrderDetail { get; set; }

	/// <summary>
/// ItemDomain Data Structure.
/// </summary>
[Serializable]

public class ItemDomain : TopObject
{
	        /// <summary>
	        /// 实际入库数量,Item1234,string(50),,
	        /// </summary>
	        [XmlElement("inCount")]
	        public string InCount { get; set; }
	
	        /// <summary>
	        /// 库存类型(1:可销售库存.101:残次),HZ1234,string(500),,
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
	        /// <summary>
	        /// 实际出库数量,Item1234,string(50),,
	        /// </summary>
	        [XmlElement("outCount")]
	        public string OutCount { get; set; }
	
	        /// <summary>
	        /// 计划调拨数量,Item1234,string(50),,
	        /// </summary>
	        [XmlElement("planCount")]
	        public string PlanCount { get; set; }
	
	        /// <summary>
	        /// 货品编码,HZ1234,string(50),,
	        /// </summary>
	        [XmlElement("scItemCode")]
	        public string ScItemCode { get; set; }
}

	/// <summary>
/// ItemsDomain Data Structure.
/// </summary>
[Serializable]

public class ItemsDomain : TopObject
{
	        /// <summary>
	        /// 调拨单项目
	        /// </summary>
	        [XmlElement("item")]
	        public ItemDomain Item { get; set; }
}

	/// <summary>
/// TransferOrderDetailDomain Data Structure.
/// </summary>
[Serializable]

public class TransferOrderDetailDomain : TopObject
{
	        /// <summary>
	        /// 外部ERP订单号,HZ1234,string(50),,
	        /// </summary>
	        [XmlElement("erpOrderCode")]
	        public string ErpOrderCode { get; set; }
	
	        /// <summary>
	        /// 调拨单项目
	        /// </summary>
	        [XmlElement("items")]
	        public ItemsDomain Items { get; set; }
	
	        /// <summary>
	        /// 订单状态,0,string(50),,
	        /// </summary>
	        [XmlElement("orderStatus")]
	        public string OrderStatus { get; set; }
	
	        /// <summary>
	        /// 1111
	        /// </summary>
	        [XmlElement("ownerCode")]
	        public string OwnerCode { get; set; }
	
	        /// <summary>
	        /// 调拨单号,0,string(50),,
	        /// </summary>
	        [XmlElement("transferOrderCode")]
	        public string TransferOrderCode { get; set; }
}

    }
}
