using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.inventory.query
    /// </summary>
    /// 
    [XmlRoot("request", Namespace = "", IsNullable = false)]
    public class InventoryQueryRequest : QimenRequest<Qimen.Api.Response.InventoryQueryResponse>
    {
        [XmlArray("criteriaList")]
        [XmlArrayItem("criteria")]
        public List<CriteriaDomain> CriteriaList { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        /// 
        [XmlElement("extendProps")]
        public string ExtendProps { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        /// 
        [XmlElement("remark")]
        public string Remark { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.inventory.query";
        }


	/// <summary>
/// CriteriaDomain Data Structure.
/// </summary>
[Serializable]


public class CriteriaDomain
{
	        /// <summary>
	        /// 库存类型(ZP=正品;CC=残次;JS=机损;XS=箱损;ZT=在途库存;默认为查所有类型的库存)
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
	        /// <summary>
	        /// 商品编码
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 仓储系统商品ID
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 货主编码
	        /// </summary>
	        [XmlElement("ownerCode")]
	        public string OwnerCode { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 仓库编码
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
}

        #endregion
    }
}
