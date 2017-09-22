using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// ChannelinventoryQueryResponse.
    /// </summary>
    public class ChannelinventoryQueryResponse : QimenResponse
    {
        /// <summary>
        /// itemInventories
        /// </summary>
        [XmlArray("itemInventories")]
        [XmlArrayItem("itemInventory")]
        public List<ItemInventoryDomain> ItemInventories { get; set; }

	/// <summary>
/// ItemInventoryDomain Data Structure.
/// </summary>
[Serializable]

public class ItemInventoryDomain : TopObject
{
	        /// <summary>
	        /// 奇门仓储字段,C123,string(50),,
	        /// </summary>
	        [XmlElement("channelCode")]
	        public string ChannelCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,C123,string(50),,
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,C123,string(50),,
	        /// </summary>
	        [XmlElement("lockQuantity")]
	        public string LockQuantity { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,C123,string(50),,
	        /// </summary>
	        [XmlElement("quantity")]
	        public string Quantity { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,C123,string(50),,
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
}

    }
}
