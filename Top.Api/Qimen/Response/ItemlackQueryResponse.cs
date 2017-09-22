using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// ItemlackQueryResponse.
    /// </summary>
    public class ItemlackQueryResponse : QimenResponse
    {
        /// <summary>
        /// 缺货回告创建时间(YYYY-MM-DD HH:mm:ss)
        /// </summary>
        [XmlElement("createTime")]
        public string CreateTime { get; set; }

        /// <summary>
        /// ERP的发货单编码
        /// </summary>
        [XmlElement("deliveryOrderCode")]
        public string DeliveryOrderCode { get; set; }

        /// <summary>
        /// 仓库系统的发货单编码
        /// </summary>
        [XmlElement("deliveryOrderId")]
        public string DeliveryOrderId { get; set; }

        /// <summary>
        /// 缺货商品列表
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("item")]
        public List<ItemDomain> Items { get; set; }

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
	        /// 库存类型(ZP=正品;CC=残次;JS=机损;XS=箱损;ZT=在途库存)
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
	        /// <summary>
	        /// 商品编码
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 仓储系统商品编码
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 缺货商品数量
	        /// </summary>
	        [XmlElement("lackQty")]
	        public long LackQty { get; set; }
	
	        /// <summary>
	        /// 应发商品数量
	        /// </summary>
	        [XmlElement("planQty")]
	        public long PlanQty { get; set; }
	
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
	        /// 缺货原因(系统报缺;实物报缺)
	        /// </summary>
	        [XmlElement("reason")]
	        public string Reason { get; set; }
}

    }
}
