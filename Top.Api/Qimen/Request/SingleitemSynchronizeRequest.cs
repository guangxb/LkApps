using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.singleitem.synchronize
    /// </summary>
    public class SingleitemSynchronizeRequest : QimenRequest<Qimen.Api.Response.SingleitemSynchronizeResponse>
    {
        /// <summary>
        /// 操作类型(两种类型：add|update)
        /// </summary>
        public string ActionType { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        public ItemDomain Item { get; set; }

        /// <summary>
        /// 货主编码
        /// </summary>
        public string OwnerCode { get; set; }

        /// <summary>
        /// 供应商编码
        /// </summary>
        public string SupplierCode { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        public string SupplierName { get; set; }

        /// <summary>
        /// 仓库编码(统仓统配等无需ERP指定仓储编码的情况填OTHER)
        /// </summary>
        public string WarehouseCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.singleitem.synchronize";
        }


	/// <summary>
/// BatchDomain Data Structure.
/// </summary>
[Serializable]

public class BatchDomain
{
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("actualQty")]
	        public string ActualQty { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("expireDate")]
	        public string ExpireDate { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("produceCode")]
	        public string ProduceCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("productDate")]
	        public string ProductDate { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("quantity")]
	        public string Quantity { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
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
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
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
/// ItemDomain Data Structure.
/// </summary>
[Serializable]

public class ItemDomain
{
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("actualAmount")]
	        public string ActualAmount { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("actualQty")]
	        public string ActualQty { get; set; }
	
	        /// <summary>
	        /// 保质期临期预警天数
	        /// </summary>
	        [XmlElement("adventLifecycle")]
	        public Nullable<long> AdventLifecycle { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("amount")]
	        public string Amount { get; set; }
	
	        /// <summary>
	        /// 批准文号
	        /// </summary>
	        [XmlElement("approvalNumber")]
	        public string ApprovalNumber { get; set; }
	
	        /// <summary>
	        /// 条形码(可多个;用分号;隔开)
	        /// </summary>
	        [XmlElement("barCode")]
	        public string BarCode { get; set; }
	
	        /// <summary>
	        /// 批次代码
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// 批次备注
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
	        /// 品牌代码
	        /// </summary>
	        [XmlElement("brandCode")]
	        public string BrandCode { get; set; }
	
	        /// <summary>
	        /// 品牌名称
	        /// </summary>
	        [XmlElement("brandName")]
	        public string BrandName { get; set; }
	
	        /// <summary>
	        /// 商品类别ID
	        /// </summary>
	        [XmlElement("categoryId")]
	        public string CategoryId { get; set; }
	
	        /// <summary>
	        /// 商品类别名称
	        /// </summary>
	        [XmlElement("categoryName")]
	        public string CategoryName { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("changeTime")]
	        public string ChangeTime { get; set; }
	
	        /// <summary>
	        /// 渠道变量
	        /// </summary>
	        [XmlElement("channelCode")]
	        public string ChannelCode { get; set; }
	
	        /// <summary>
	        /// 颜色
	        /// </summary>
	        [XmlElement("color")]
	        public string Color { get; set; }
	
	        /// <summary>
	        /// 成本价
	        /// </summary>
	        [XmlElement("costPrice")]
	        public string CostPrice { get; set; }
	
	        /// <summary>
	        /// 创建时间(YYYY-MM-DD HH:MM:SS)
	        /// </summary>
	        [XmlElement("createTime")]
	        public string CreateTime { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("defectiveQty")]
	        public string DefectiveQty { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("diffQuantity")]
	        public string DiffQuantity { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("discount")]
	        public string Discount { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("discountPrice")]
	        public string DiscountPrice { get; set; }
	
	        /// <summary>
	        /// 英文名
	        /// </summary>
	        [XmlElement("englishName")]
	        public string EnglishName { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("exCode")]
	        public string ExCode { get; set; }
	
	        /// <summary>
	        /// 过期日期(YYYY-MM-DD)
	        /// </summary>
	        [XmlElement("expireDate")]
	        public string ExpireDate { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("extCode")]
	        public string ExtCode { get; set; }
	
	        /// <summary>
	        /// 货号
	        /// </summary>
	        [XmlElement("goodsCode")]
	        public string GoodsCode { get; set; }
	
	        /// <summary>
	        /// 毛重(单位：千克)
	        /// </summary>
	        [XmlElement("grossWeight")]
	        public string GrossWeight { get; set; }
	
	        /// <summary>
	        /// 高(单位：厘米)
	        /// </summary>
	        [XmlElement("height")]
	        public string Height { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("isAreaSale")]
	        public string IsAreaSale { get; set; }
	
	        /// <summary>
	        /// 是否需要批次管理(Y/N ;默认为N)
	        /// </summary>
	        [XmlElement("isBatchMgmt")]
	        public string IsBatchMgmt { get; set; }
	
	        /// <summary>
	        /// 是否易碎品(Y/N ;默认为N)
	        /// </summary>
	        [XmlElement("isFragile")]
	        public string IsFragile { get; set; }
	
	        /// <summary>
	        /// 是否危险品(Y/N ;默认为N)
	        /// </summary>
	        [XmlElement("isHazardous")]
	        public string IsHazardous { get; set; }
	
	        /// <summary>
	        /// 是否需要串号管理(Y/N ;默认为N)
	        /// </summary>
	        [XmlElement("isSNMgmt")]
	        public string IsSNMgmt { get; set; }
	
	        /// <summary>
	        /// 是否需要保质期管理(Y/N ;默认为N)
	        /// </summary>
	        [XmlElement("isShelfLifeMgmt")]
	        public string IsShelfLifeMgmt { get; set; }
	
	        /// <summary>
	        /// 是否sku(Y/N ;默认为N)
	        /// </summary>
	        [XmlElement("isSku")]
	        public string IsSku { get; set; }
	
	        /// <summary>
	        /// 是否有效(Y/N ;默认为N)
	        /// </summary>
	        [XmlElement("isValid")]
	        public string IsValid { get; set; }
	
	        /// <summary>
	        /// 商品编码
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 仓储系统商品编码(该字段是WMS分配的商品编号;WMS如果分配了商品编码;则后续的商品操作都需要传该字段;如果WMS不使用;WMS可 以返回itemId=itemCode的值)
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 商品名称
	        /// </summary>
	        [XmlElement("itemName")]
	        public string ItemName { get; set; }
	
	        /// <summary>
	        /// 商品类型(ZC=正常商品;FX=分销商品;ZH=组合商品;ZP=赠品;BC=包材;HC=耗材;FL=辅料;XN=虚拟品;FS=附属品;CC=残次品; OTHER=其它;只传英文编码)
	        /// </summary>
	        [XmlElement("itemType")]
	        public string ItemType { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("lackQty")]
	        public string LackQty { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("latestUpdateTime")]
	        public string LatestUpdateTime { get; set; }
	
	        /// <summary>
	        /// 长(单位：厘米)
	        /// </summary>
	        [XmlElement("length")]
	        public string Length { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("lockQuantity")]
	        public string LockQuantity { get; set; }
	
	        /// <summary>
	        /// 保质期禁售天数
	        /// </summary>
	        [XmlElement("lockupLifecycle")]
	        public Nullable<long> LockupLifecycle { get; set; }
	
	        /// <summary>
	        /// 净重(单位：千克)
	        /// </summary>
	        [XmlElement("netWeight")]
	        public string NetWeight { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("normalQty")]
	        public string NormalQty { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("orderCode")]
	        public string OrderCode { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("orderLineNo")]
	        public string OrderLineNo { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("orderType")]
	        public string OrderType { get; set; }
	
	        /// <summary>
	        /// 商品的原产地
	        /// </summary>
	        [XmlElement("originAddress")]
	        public string OriginAddress { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("originCode")]
	        public string OriginCode { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("outBizCode")]
	        public string OutBizCode { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("ownerCode")]
	        public string OwnerCode { get; set; }
	
	        /// <summary>
	        /// 包装代码
	        /// </summary>
	        [XmlElement("packCode")]
	        public string PackCode { get; set; }
	
	        /// <summary>
	        /// 商品包装材料类型
	        /// </summary>
	        [XmlElement("packageMaterial")]
	        public string PackageMaterial { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("paperQty")]
	        public string PaperQty { get; set; }
	
	        /// <summary>
	        /// 箱规
	        /// </summary>
	        [XmlElement("pcs")]
	        public string Pcs { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("planQty")]
	        public string PlanQty { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("price")]
	        public string Price { get; set; }
	
	        /// <summary>
	        /// priceAdjustment
	        /// </summary>
	        [XmlElement("priceAdjustment")]
	        public PriceAdjustmentDomain PriceAdjustment { get; set; }
	
	        /// <summary>
	        /// 计价货类
	        /// </summary>
	        [XmlElement("pricingCategory")]
	        public string PricingCategory { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("produceCode")]
	        public string ProduceCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("productCode")]
	        public string ProductCode { get; set; }
	
	        /// <summary>
	        /// 生产日期(YYYY-MM-DD)
	        /// </summary>
	        [XmlElement("productDate")]
	        public string ProductDate { get; set; }
	
	        /// <summary>
	        /// 采购价
	        /// </summary>
	        [XmlElement("purchasePrice")]
	        public string PurchasePrice { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("quantity")]
	        public string Quantity { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("reason")]
	        public string Reason { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("receiveQty")]
	        public string ReceiveQty { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("referencePrice")]
	        public string ReferencePrice { get; set; }
	
	        /// <summary>
	        /// 保质期禁收天数
	        /// </summary>
	        [XmlElement("rejectLifecycle")]
	        public Nullable<long> RejectLifecycle { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 零售价
	        /// </summary>
	        [XmlElement("retailPrice")]
	        public string RetailPrice { get; set; }
	
	        /// <summary>
	        /// 安全库存
	        /// </summary>
	        [XmlElement("safetyStock")]
	        public Nullable<long> SafetyStock { get; set; }
	
	        /// <summary>
	        /// 季节编码
	        /// </summary>
	        [XmlElement("seasonCode")]
	        public string SeasonCode { get; set; }
	
	        /// <summary>
	        /// 季节名称
	        /// </summary>
	        [XmlElement("seasonName")]
	        public string SeasonName { get; set; }
	
	        /// <summary>
	        /// 保质期(单位：小时)
	        /// </summary>
	        [XmlElement("shelfLife")]
	        public Nullable<long> ShelfLife { get; set; }
	
	        /// <summary>
	        /// 商品简称
	        /// </summary>
	        [XmlElement("shortName")]
	        public string ShortName { get; set; }
	
	        /// <summary>
	        /// 尺寸
	        /// </summary>
	        [XmlElement("size")]
	        public string Size { get; set; }
	
	        /// <summary>
	        /// 商品属性(如红色;XXL)
	        /// </summary>
	        [XmlElement("skuProperty")]
	        public string SkuProperty { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("sn")]
	        public string Sn { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("snCode")]
	        public string SnCode { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("sourceOrderCode")]
	        public string SourceOrderCode { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("standardPrice")]
	        public string StandardPrice { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("stockStatus")]
	        public string StockStatus { get; set; }
	
	        /// <summary>
	        /// 商品计量单位
	        /// </summary>
	        [XmlElement("stockUnit")]
	        public string StockUnit { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("subSourceOrderCode")]
	        public string SubSourceOrderCode { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("supplierCode")]
	        public string SupplierCode { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("supplierName")]
	        public string SupplierName { get; set; }
	
	        /// <summary>
	        /// 吊牌价
	        /// </summary>
	        [XmlElement("tagPrice")]
	        public string TagPrice { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("tareWeight")]
	        public string TareWeight { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("tempRequirement")]
	        public string TempRequirement { get; set; }
	
	        /// <summary>
	        /// 渠道中的商品标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("unit")]
	        public string Unit { get; set; }
	
	        /// <summary>
	        /// 更新时间(YYYY-MM-DD HH:MM:SS)
	        /// </summary>
	        [XmlElement("updateTime")]
	        public string UpdateTime { get; set; }
	
	        /// <summary>
	        /// 体积(单位：升)
	        /// </summary>
	        [XmlElement("volume")]
	        public string Volume { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
	
	        /// <summary>
	        /// 宽(单位：厘米)
	        /// </summary>
	        [XmlElement("width")]
	        public string Width { get; set; }
}

        #endregion
    }
}
