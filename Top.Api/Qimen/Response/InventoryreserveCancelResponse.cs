using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// InventoryreserveCancelResponse.
    /// </summary>
    public class InventoryreserveCancelResponse : QimenResponse
    {
        /// <summary>
        /// 奇门仓储字段
        /// </summary>
        [XmlElement("isRetry")]
        public string IsRetry { get; set; }

        /// <summary>
        /// 奇门仓储字段
        /// </summary>
        [XmlArray("itemInventories")]
        [XmlArrayItem("item_inventory")]
        public List<ItemInventoryDomain> ItemInventories { get; set; }

        /// <summary>
        /// 奇门仓储字段
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
	        /// 响应码
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("combItemId")]
	        public string CombItemId { get; set; }
	
	        /// <summary>
	        /// 响应结果:success|failure
	        /// </summary>
	        [XmlElement("flag")]
	        public string Flag { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("itemQuantity")]
	        public string ItemQuantity { get; set; }
	
	        /// <summary>
	        /// 响应信息
	        /// </summary>
	        [XmlElement("message")]
	        public string Message { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("orderSourceCode")]
	        public string OrderSourceCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("subSourceCode")]
	        public string SubSourceCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
}

    }
}
