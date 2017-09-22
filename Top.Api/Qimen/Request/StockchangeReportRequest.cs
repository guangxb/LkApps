using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.stockchange.report
    /// </summary>
    public class StockchangeReportRequest : QimenRequest<Qimen.Api.Response.StockchangeReportResponse>
    {
        /// <summary>
        /// 奇门仓储字段,说明,string(50),,
        /// </summary>
        public string CurrentPage { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        public List<ItemDomain> Items { get; set; }

        /// <summary>
        /// 奇门仓储字段,说明,string(50),,
        /// </summary>
        public string OrderCode { get; set; }

        /// <summary>
        /// 奇门仓储字段,说明,string(50),,
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 奇门仓储字段,说明,string(50),,
        /// </summary>
        public string OwnerCode { get; set; }

        /// <summary>
        /// 奇门仓储字段,说明,string(50),,
        /// </summary>
        public string PageSize { get; set; }

        /// <summary>
        /// 奇门仓储字段,说明,string(50),,
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 奇门仓储字段,说明,string(50),,
        /// </summary>
        public string TotalPage { get; set; }

        /// <summary>
        /// 奇门仓储字段,说明,string(50),,
        /// </summary>
        public string WarehouseCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.stockchange.report";
        }


	/// <summary>
/// PriceAdjustmentDomain Data Structure.
/// </summary>
[Serializable]

public class PriceAdjustmentDomain
{
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("discount")]
	        public string Discount { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("endDate")]
	        public string EndDate { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("standardPrice")]
	        public string StandardPrice { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("startDate")]
	        public string StartDate { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// BatchDomain Data Structure.
/// </summary>
[Serializable]

public class BatchDomain
{
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
	        /// 库存类型(ZP=正品;CC=残次;JS=机损 XS= 箱损;ZT=在途库存)
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
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
	
	        /// <summary>
	        /// 异动数量(要求batchs节点下所有的异动数量之和等于orderline中的异动数量)
	        /// </summary>
	        [XmlElement("quantity")]
	        public Nullable<long> Quantity { get; set; }
}

	/// <summary>
/// ItemDomain Data Structure.
/// </summary>
[Serializable]

public class ItemDomain
{
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("actualAmount")]
	        public string ActualAmount { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("actualQty")]
	        public string ActualQty { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("adventLifecycle")]
	        public string AdventLifecycle { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("amount")]
	        public string Amount { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("approvalNumber")]
	        public string ApprovalNumber { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("barCode")]
	        public string BarCode { get; set; }
	
	        /// <summary>
	        /// 批次编码
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("batchRemark")]
	        public string BatchRemark { get; set; }
	
	        /// <summary>
	        /// batchs
	        /// </summary>
	        [XmlArray("batchs")]
	        [XmlArrayItem("batch")]
	        public List<BatchDomain> Batchs { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("brandCode")]
	        public string BrandCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("brandName")]
	        public string BrandName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("categoryId")]
	        public string CategoryId { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("categoryName")]
	        public string CategoryName { get; set; }
	
	        /// <summary>
	        /// 异动时间(YYYY-MM-DD HH:MM:SS)
	        /// </summary>
	        [XmlElement("changeTime")]
	        public string ChangeTime { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("channelCode")]
	        public string ChannelCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("color")]
	        public string Color { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("costPrice")]
	        public string CostPrice { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("defectiveQty")]
	        public string DefectiveQty { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("diffQuantity")]
	        public string DiffQuantity { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("discount")]
	        public string Discount { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("discountPrice")]
	        public string DiscountPrice { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("englishName")]
	        public string EnglishName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("exCode")]
	        public string ExCode { get; set; }
	
	        /// <summary>
	        /// 商品过期日期(YYYY-MM-DD)
	        /// </summary>
	        [XmlElement("expireDate")]
	        public string ExpireDate { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("extCode")]
	        public string ExtCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("goodsCode")]
	        public string GoodsCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("grossWeight")]
	        public string GrossWeight { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("height")]
	        public string Height { get; set; }
	
	        /// <summary>
	        /// 库存类型(ZP=正品;CC=残次;JS=机损;XS=箱损;ZT=在途库存)
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("isAreaSale")]
	        public string IsAreaSale { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("isBatchMgmt")]
	        public string IsBatchMgmt { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("isFragile")]
	        public string IsFragile { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("isHazardous")]
	        public string IsHazardous { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("isSNMgmt")]
	        public string IsSNMgmt { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("isShelfLifeMgmt")]
	        public string IsShelfLifeMgmt { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("isSku")]
	        public string IsSku { get; set; }
	
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
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("itemName")]
	        public string ItemName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("itemType")]
	        public string ItemType { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("lackQty")]
	        public string LackQty { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("latestUpdateTime")]
	        public string LatestUpdateTime { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("length")]
	        public string Length { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("lockQuantity")]
	        public string LockQuantity { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("lockupLifecycle")]
	        public string LockupLifecycle { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("netWeight")]
	        public string NetWeight { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("normalQty")]
	        public string NormalQty { get; set; }
	
	        /// <summary>
	        /// 引起异动的单据编码
	        /// </summary>
	        [XmlElement("orderCode")]
	        public string OrderCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("orderLineNo")]
	        public string OrderLineNo { get; set; }
	
	        /// <summary>
	        /// 单据类型(JYCK=一般交易出库单;HHCK=换货出库;BFCK=补发出库;PTCK=普通出库单;DBCK=调拨出库;B2BRK=B2B入 库;B2BCK=B2B出库;QTCK=其他出库;SCRK=生产入库;LYRK=领用入库;CCRK=残次品入库;CGRK=采购入库;DBRK= 调拨入库;QTRK= 其他入 库;XTRK= 销退入库;HHRK= 换货入库;CNJG= 仓内加工单)
	        /// </summary>
	        [XmlElement("orderType")]
	        public string OrderType { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("originAddress")]
	        public string OriginAddress { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("originCode")]
	        public string OriginCode { get; set; }
	
	        /// <summary>
	        /// 外部业务编码(消息ID;用于去重;用来保证因为网络等原因导致重复传输;请求不会被重复处理)
	        /// </summary>
	        [XmlElement("outBizCode")]
	        public string OutBizCode { get; set; }
	
	        /// <summary>
	        /// 货主编码
	        /// </summary>
	        [XmlElement("ownerCode")]
	        public string OwnerCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("packCode")]
	        public string PackCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("packageMaterial")]
	        public string PackageMaterial { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("paperQty")]
	        public string PaperQty { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("pcs")]
	        public string Pcs { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("planQty")]
	        public string PlanQty { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("price")]
	        public string Price { get; set; }
	
	        /// <summary>
	        /// priceAdjustment
	        /// </summary>
	        [XmlElement("priceAdjustment")]
	        public PriceAdjustmentDomain PriceAdjustment { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("pricingCategory")]
	        public string PricingCategory { get; set; }
	
	        /// <summary>
	        /// 生产批号
	        /// </summary>
	        [XmlElement("produceCode")]
	        public string ProduceCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("productCode")]
	        public string ProductCode { get; set; }
	
	        /// <summary>
	        /// 商品生产日期(YYYY-MM-DD)
	        /// </summary>
	        [XmlElement("productDate")]
	        public string ProductDate { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("purchasePrice")]
	        public string PurchasePrice { get; set; }
	
	        /// <summary>
	        /// 商品变化量(可为正为负)
	        /// </summary>
	        [XmlElement("quantity")]
	        public Nullable<long> Quantity { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("reason")]
	        public string Reason { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("receiveQty")]
	        public string ReceiveQty { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("referencePrice")]
	        public string ReferencePrice { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("rejectLifecycle")]
	        public string RejectLifecycle { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("retailPrice")]
	        public string RetailPrice { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("safetyStock")]
	        public string SafetyStock { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("seasonCode")]
	        public string SeasonCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("seasonName")]
	        public string SeasonName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("shelfLife")]
	        public string ShelfLife { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("shortName")]
	        public string ShortName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("size")]
	        public string Size { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("skuProperty")]
	        public string SkuProperty { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("sn")]
	        public string Sn { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("snCode")]
	        public string SnCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("sourceOrderCode")]
	        public string SourceOrderCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("standardPrice")]
	        public string StandardPrice { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("stockStatus")]
	        public string StockStatus { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("stockUnit")]
	        public string StockUnit { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("subSourceOrderCode")]
	        public string SubSourceOrderCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("supplierCode")]
	        public string SupplierCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("supplierName")]
	        public string SupplierName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("tagPrice")]
	        public string TagPrice { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("tareWeight")]
	        public string TareWeight { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("tempRequirement")]
	        public string TempRequirement { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("unit")]
	        public string Unit { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("volume")]
	        public string Volume { get; set; }
	
	        /// <summary>
	        /// 仓库编码
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("width")]
	        public string Width { get; set; }
}

        #endregion
    }
}
