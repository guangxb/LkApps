using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// InventoryreserveCreateResponse.
    /// </summary>
    public class InventoryreserveCreateResponse : QimenResponse
    {
        /// <summary>
        /// 是否需要重试(Y/N (默认为N)返回Y时建议系统自动重试)
        /// </summary>
        [XmlElement("isRetry")]
        public string IsRetry { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("itemInventories")]
        [XmlArrayItem("item_inventory")]
        public List<ItemInventoryDomain> ItemInventories { get; set; }

        /// <summary>
        /// ERP订单编码
        /// </summary>
        [XmlElement("orderCode")]
        public string OrderCode { get; set; }

	/// <summary>
/// ItemInventoryDomain Data Structure.
/// </summary>
[Serializable]

public class ItemInventoryDomain : TopObject
{
	        /// <summary>
	        /// 菜鸟组合货品ID
	        /// </summary>
	        [XmlElement("combItemId")]
	        public string CombItemId { get; set; }
	
	        /// <summary>
	        /// 菜鸟商品编码
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 菜鸟商品ID
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 订单交易编码
	        /// </summary>
	        [XmlElement("orderSourceCode")]
	        public string OrderSourceCode { get; set; }
	
	        /// <summary>
	        /// 商品数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public long Quantity { get; set; }
	
	        /// <summary>
	        /// 子交易编码
	        /// </summary>
	        [XmlElement("subSourceCode")]
	        public string SubSourceCode { get; set; }
	
	        /// <summary>
	        /// 仓库编码
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
}

    }
}
