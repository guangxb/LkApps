using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// StockoutQueryResponse.
    /// </summary>
    public class StockoutQueryResponse : QimenResponse
    {
        /// <summary>
        /// 出库单信息
        /// </summary>
        [XmlElement("deliveryOrder")]
        public DeliveryOrderDomain DeliveryOrder { get; set; }

        /// <summary>
        /// 单据信息列表
        /// </summary>
        [XmlArray("orderLines")]
        [XmlArrayItem("orderLine")]
        public List<OrderLineDomain> OrderLines { get; set; }

        /// <summary>
        /// 包裹信息
        /// </summary>
        [XmlArray("packages")]
        [XmlArrayItem("package")]
        public List<PackageDomain> Packages { get; set; }

        /// <summary>
        /// orderLines总条数
        /// </summary>
        [XmlElement("totalLines")]
        public long TotalLines { get; set; }

	/// <summary>
/// DeliveryOrderDomain Data Structure.
/// </summary>
[Serializable]

public class DeliveryOrderDomain : TopObject
{
	        /// <summary>
	        /// 出库单号
	        /// </summary>
	        [XmlElement("deliveryOrderCode")]
	        public string DeliveryOrderCode { get; set; }
	
	        /// <summary>
	        /// 仓储系统出库单号
	        /// </summary>
	        [XmlElement("deliveryOrderId")]
	        public string DeliveryOrderId { get; set; }
	
	        /// <summary>
	        /// 运单号
	        /// </summary>
	        [XmlElement("expressCode")]
	        public string ExpressCode { get; set; }
	
	        /// <summary>
	        /// 物流公司编码
	        /// </summary>
	        [XmlElement("logisticsCode")]
	        public string LogisticsCode { get; set; }
	
	        /// <summary>
	        /// 物流公司名称
	        /// </summary>
	        [XmlElement("logisticsName")]
	        public string LogisticsName { get; set; }
	
	        /// <summary>
	        /// 订单完成时间
	        /// </summary>
	        [XmlElement("orderConfirmTime")]
	        public string OrderConfirmTime { get; set; }
	
	        /// <summary>
	        /// 出库单类型
	        /// </summary>
	        [XmlElement("orderType")]
	        public string OrderType { get; set; }
	
	        /// <summary>
	        /// 出库单状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 仓库编码
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
}

	/// <summary>
/// PackageMaterialDomain Data Structure.
/// </summary>
[Serializable]

public class PackageMaterialDomain : TopObject
{
	        /// <summary>
	        /// 包材的数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public long Quantity { get; set; }
	
	        /// <summary>
	        /// 包材型号
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// ItemDomain Data Structure.
/// </summary>
[Serializable]

public class ItemDomain : TopObject
{
	        /// <summary>
	        /// 商品编码
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 商品仓储系统编码
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 包裹内该商品的数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public long Quantity { get; set; }
}

	/// <summary>
/// PackageDomain Data Structure.
/// </summary>
[Serializable]

public class PackageDomain : TopObject
{
	        /// <summary>
	        /// 运单号
	        /// </summary>
	        [XmlElement("expressCode")]
	        public string ExpressCode { get; set; }
	
	        /// <summary>
	        /// 包裹高度(厘米)
	        /// </summary>
	        [XmlElement("height")]
	        public string Height { get; set; }
	
	        /// <summary>
	        /// 商品信息列表
	        /// </summary>
	        [XmlArray("items")]
	        [XmlArrayItem("item")]
	        public List<ItemDomain> Items { get; set; }
	
	        /// <summary>
	        /// 包裹长度(厘米)
	        /// </summary>
	        [XmlElement("length")]
	        public string Length { get; set; }
	
	        /// <summary>
	        /// 物流公司名称
	        /// </summary>
	        [XmlElement("logisticsName")]
	        public string LogisticsName { get; set; }
	
	        /// <summary>
	        /// 包裹编号
	        /// </summary>
	        [XmlElement("packageCode")]
	        public string PackageCode { get; set; }
	
	        /// <summary>
	        /// 包材信息
	        /// </summary>
	        [XmlArray("packageMaterialList")]
	        [XmlArrayItem("packageMaterial")]
	        public List<PackageMaterialDomain> PackageMaterialList { get; set; }
	
	        /// <summary>
	        /// 包裹体积(升L)
	        /// </summary>
	        [XmlElement("volume")]
	        public string Volume { get; set; }
	
	        /// <summary>
	        /// 包裹重量(千克)
	        /// </summary>
	        [XmlElement("weight")]
	        public string Weight { get; set; }
	
	        /// <summary>
	        /// 包裹宽度(厘米)
	        /// </summary>
	        [XmlElement("width")]
	        public string Width { get; set; }
}

	/// <summary>
/// OrderLineDomain Data Structure.
/// </summary>
[Serializable]

public class OrderLineDomain : TopObject
{
	        /// <summary>
	        /// 实发商品数量
	        /// </summary>
	        [XmlElement("actualQty")]
	        public long ActualQty { get; set; }
	
	        /// <summary>
	        /// 批次编号
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// 过期日期(YYYY-MM-DD)
	        /// </summary>
	        [XmlElement("expireDate")]
	        public string ExpireDate { get; set; }
	
	        /// <summary>
	        /// 库存类型
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
	        /// <summary>
	        /// 商品编码
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 商品仓储系统编码
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 商品名称
	        /// </summary>
	        [XmlElement("itemName")]
	        public string ItemName { get; set; }
	
	        /// <summary>
	        /// 单据行号
	        /// </summary>
	        [XmlElement("orderLineNo")]
	        public string OrderLineNo { get; set; }
	
	        /// <summary>
	        /// 生产批号
	        /// </summary>
	        [XmlElement("produceCode")]
	        public string ProduceCode { get; set; }
	
	        /// <summary>
	        /// 生产日期(YYYY-MM-DD)
	        /// </summary>
	        [XmlElement("productDate")]
	        public string ProductDate { get; set; }
}

    }
}
