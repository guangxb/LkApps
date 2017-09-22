using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.inventoryreserve.cancel
    /// </summary>
    public class InventoryreserveCancelRequest : QimenRequest<Qimen.Api.Response.InventoryreserveCancelResponse>
    {
        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        public List<ItemInventoryDomain> ItemInventories { get; set; }

        /// <summary>
        /// 奇门仓储字段
        /// </summary>
        public string OrderCode { get; set; }

        /// <summary>
        /// 奇门仓储字段
        /// </summary>
        public string OrderSource { get; set; }

        /// <summary>
        /// 奇门仓储字段
        /// </summary>
        public string OwnerCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.inventoryreserve.cancel";
        }


	/// <summary>
/// ItemInventoryDomain Data Structure.
/// </summary>
[Serializable]

public class ItemInventoryDomain
{
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
	        [XmlElement("orderSourceCode")]
	        public string OrderSourceCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("subSourceCode")]
	        public string SubSourceCode { get; set; }
}

        #endregion
    }
}
