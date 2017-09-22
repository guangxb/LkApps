using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// InventorycheckQueryResponse.
    /// </summary>
    public class InventorycheckQueryResponse : QimenResponse
    {
        /// <summary>
        /// 盘点单编码
        /// </summary>
        [XmlElement("checkOrderCode")]
        public string CheckOrderCode { get; set; }

        /// <summary>
        /// 仓储系统的盘点单编码
        /// </summary>
        [XmlElement("checkOrderId")]
        public string CheckOrderId { get; set; }

        /// <summary>
        /// 盘点时间(YYYY-MM-DD HH:MM:SS)
        /// </summary>
        [XmlElement("checkTime")]
        public string CheckTime { get; set; }

        /// <summary>
        /// 商品库存列表
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("item")]
        public List<ItemDomain> Items { get; set; }

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
        /// orderLines总条数
        /// </summary>
        [XmlElement("totalLines")]
        public long TotalLines { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [XmlElement("warehouseCode")]
        public string WarehouseCode { get; set; }

	/// <summary>
/// ItemDomain Data Structure.
/// </summary>
[Serializable]

public class ItemDomain : TopObject
{
	        /// <summary>
	        /// 批次编码
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// 商品过期日期(YYYY-MM-DD)
	        /// </summary>
	        [XmlElement("expireDate")]
	        public string ExpireDate { get; set; }
	
	        /// <summary>
	        /// 库存类型(ZP=正品;CC=残次;JS=机损;XS= 箱损;ZT=在途库存;默认为ZP)
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
	        /// 生产批号
	        /// </summary>
	        [XmlElement("produceCode")]
	        public string ProduceCode { get; set; }
	
	        /// <summary>
	        /// 商品生产日期(YYYY-MM-DD)
	        /// </summary>
	        [XmlElement("productDate")]
	        public string ProductDate { get; set; }
	
	        /// <summary>
	        /// 盘盈盘亏商品变化量(盘盈为正数;盘亏为负数)
	        /// </summary>
	        [XmlElement("quantity")]
	        public long Quantity { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 商品序列号
	        /// </summary>
	        [XmlElement("snCode")]
	        public string SnCode { get; set; }
}

    }
}
