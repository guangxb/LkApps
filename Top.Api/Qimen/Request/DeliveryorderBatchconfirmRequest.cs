using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.deliveryorder.batchconfirm
    /// </summary>
    public class DeliveryorderBatchconfirmRequest : QimenRequest<Qimen.Api.Response.DeliveryorderBatchconfirmResponse>
    {
        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        public List<OrderDomain> Orders { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.deliveryorder.batchconfirm";
        }


	/// <summary>
/// BatchDomain Data Structure.
/// </summary>
[Serializable]
[Top.Api.Util.ApiListType("batch")]
public class BatchDomain
{
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("actualQty")]
	        public string ActualQty { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("expireDate")]
	        public string ExpireDate { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("produceCode")]
	        public string ProduceCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("productDate")]
	        public string ProductDate { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("quantity")]
	        public string Quantity { get; set; }
	
	        /// <summary>
	        /// null
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
	        /// null
	        /// </summary>
	        [XmlElement("discount")]
	        public string Discount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("endDate")]
	        public string EndDate { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("standardPrice")]
	        public string StandardPrice { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("startDate")]
	        public string StartDate { get; set; }
	
	        /// <summary>
	        /// null
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
	        /// null
	        /// </summary>
	        [XmlElement("actualAmount")]
	        public string ActualAmount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("actualQty")]
	        public string ActualQty { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("adventLifecycle")]
	        public string AdventLifecycle { get; set; }
	
	        /// <summary>
	        /// 金额
	        /// </summary>
	        [XmlElement("amount")]
	        public string Amount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("approvalNumber")]
	        public string ApprovalNumber { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("barCode")]
	        public string BarCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("batchRemark")]
	        public string BatchRemark { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlArray("batchs")]
	        [XmlArrayItem("batch")]
	        public List<BatchDomain> Batchs { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("brandCode")]
	        public string BrandCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("brandName")]
	        public string BrandName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("categoryId")]
	        public string CategoryId { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("categoryName")]
	        public string CategoryName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("changeTime")]
	        public string ChangeTime { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("channelCode")]
	        public string ChannelCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("color")]
	        public string Color { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("costPrice")]
	        public string CostPrice { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("defectiveQty")]
	        public string DefectiveQty { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("diffQuantity")]
	        public string DiffQuantity { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("discount")]
	        public string Discount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("discountPrice")]
	        public string DiscountPrice { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("englishName")]
	        public string EnglishName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("exCode")]
	        public string ExCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("expireDate")]
	        public string ExpireDate { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("extCode")]
	        public string ExtCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("goodsCode")]
	        public string GoodsCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("grossWeight")]
	        public string GrossWeight { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("height")]
	        public string Height { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("isAreaSale")]
	        public string IsAreaSale { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("isBatchMgmt")]
	        public string IsBatchMgmt { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("isFragile")]
	        public string IsFragile { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("isHazardous")]
	        public string IsHazardous { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("isSNMgmt")]
	        public string IsSNMgmt { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("isShelfLifeMgmt")]
	        public string IsShelfLifeMgmt { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("isSku")]
	        public string IsSku { get; set; }
	
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
	        /// null
	        /// </summary>
	        [XmlElement("itemType")]
	        public string ItemType { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("lackQty")]
	        public string LackQty { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("latestUpdateTime")]
	        public string LatestUpdateTime { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("length")]
	        public string Length { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("lockQuantity")]
	        public string LockQuantity { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("lockupLifecycle")]
	        public string LockupLifecycle { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("netWeight")]
	        public string NetWeight { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("normalQty")]
	        public string NormalQty { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("orderCode")]
	        public string OrderCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("orderLineNo")]
	        public string OrderLineNo { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("orderType")]
	        public string OrderType { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("originAddress")]
	        public string OriginAddress { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("originCode")]
	        public string OriginCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("outBizCode")]
	        public string OutBizCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("ownerCode")]
	        public string OwnerCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("packCode")]
	        public string PackCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("packageMaterial")]
	        public string PackageMaterial { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("paperQty")]
	        public string PaperQty { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("pcs")]
	        public string Pcs { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("planQty")]
	        public string PlanQty { get; set; }
	
	        /// <summary>
	        /// 商品单价
	        /// </summary>
	        [XmlElement("price")]
	        public string Price { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("priceAdjustment")]
	        public PriceAdjustmentDomain PriceAdjustment { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("pricingCategory")]
	        public string PricingCategory { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("produceCode")]
	        public string ProduceCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("productCode")]
	        public string ProductCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("productDate")]
	        public string ProductDate { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("purchasePrice")]
	        public string PurchasePrice { get; set; }
	
	        /// <summary>
	        /// 数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public Nullable<long> Quantity { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("reason")]
	        public string Reason { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("receiveQty")]
	        public string ReceiveQty { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("referencePrice")]
	        public string ReferencePrice { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("rejectLifecycle")]
	        public string RejectLifecycle { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("retailPrice")]
	        public string RetailPrice { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("safetyStock")]
	        public string SafetyStock { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("seasonCode")]
	        public string SeasonCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("seasonName")]
	        public string SeasonName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("shelfLife")]
	        public string ShelfLife { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("shortName")]
	        public string ShortName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("size")]
	        public string Size { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("skuProperty")]
	        public string SkuProperty { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("sn")]
	        public string Sn { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("snCode")]
	        public string SnCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("sourceOrderCode")]
	        public string SourceOrderCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("standardPrice")]
	        public string StandardPrice { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("stockStatus")]
	        public string StockStatus { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("stockUnit")]
	        public string StockUnit { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("subSourceOrderCode")]
	        public string SubSourceOrderCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("supplierCode")]
	        public string SupplierCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("supplierName")]
	        public string SupplierName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("tagPrice")]
	        public string TagPrice { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("tareWeight")]
	        public string TareWeight { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("tempRequirement")]
	        public string TempRequirement { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 商品单位
	        /// </summary>
	        [XmlElement("unit")]
	        public string Unit { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("volume")]
	        public string Volume { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("width")]
	        public string Width { get; set; }
}

	/// <summary>
/// DetailDomain Data Structure.
/// </summary>
[Serializable]

public class DetailDomain
{
	        /// <summary>
	        /// 订单商品列表
	        /// </summary>
	        [XmlArray("items")]
	        [XmlArrayItem("item")]
	        public List<ItemDomain> Items { get; set; }
}

	/// <summary>
/// InvoiceDomain Data Structure.
/// </summary>
[Serializable]

public class InvoiceDomain
{
	        /// <summary>
	        /// 发票金额
	        /// </summary>
	        [XmlElement("amount")]
	        public string Amount { get; set; }
	
	        /// <summary>
	        /// 发票代码(纳税企业的标识)
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 发票内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 订单详情
	        /// </summary>
	        [XmlElement("detail")]
	        public DetailDomain Detail { get; set; }
	
	        /// <summary>
	        /// 发票抬头
	        /// </summary>
	        [XmlElement("header")]
	        public string Header { get; set; }
	
	        /// <summary>
	        /// 发票号码(纳税企业内部的发票号)
	        /// </summary>
	        [XmlElement("number")]
	        public string Number { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// DeliveryRequirementsDomain Data Structure.
/// </summary>
[Serializable]

public class DeliveryRequirementsDomain
{
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("deliveryType")]
	        public string DeliveryType { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("scheduleDay")]
	        public string ScheduleDay { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("scheduleEndTime")]
	        public string ScheduleEndTime { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("scheduleStartTime")]
	        public string ScheduleStartTime { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("scheduleType")]
	        public string ScheduleType { get; set; }
}

	/// <summary>
/// SenderInfoDomain Data Structure.
/// </summary>
[Serializable]

public class SenderInfoDomain
{
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("area")]
	        public string Area { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("birthDate")]
	        public string BirthDate { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("carNo")]
	        public string CarNo { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("career")]
	        public string Career { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("company")]
	        public string Company { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("countryCode")]
	        public string CountryCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("countryCodeCiq")]
	        public string CountryCodeCiq { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("countryCodeCus")]
	        public string CountryCodeCus { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("detailAddress")]
	        public string DetailAddress { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("fax")]
	        public string Fax { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("gender")]
	        public string Gender { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("idNumber")]
	        public string IdNumber { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("idType")]
	        public string IdType { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("tel")]
	        public string Tel { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("town")]
	        public string Town { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("zipCode")]
	        public string ZipCode { get; set; }
}

	/// <summary>
/// ReceiverInfoDomain Data Structure.
/// </summary>
[Serializable]

public class ReceiverInfoDomain
{
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("area")]
	        public string Area { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("birthDate")]
	        public string BirthDate { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("carNo")]
	        public string CarNo { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("career")]
	        public string Career { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("company")]
	        public string Company { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("countryCode")]
	        public string CountryCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("countryCodeCiq")]
	        public string CountryCodeCiq { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("countryCodeCus")]
	        public string CountryCodeCus { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("detailAddress")]
	        public string DetailAddress { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("fax")]
	        public string Fax { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("gender")]
	        public string Gender { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("idNumber")]
	        public string IdNumber { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("idType")]
	        public string IdType { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("tel")]
	        public string Tel { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("town")]
	        public string Town { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("zipCode")]
	        public string ZipCode { get; set; }
}

	/// <summary>
/// PickerInfoDomain Data Structure.
/// </summary>
[Serializable]

public class PickerInfoDomain
{
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("area")]
	        public string Area { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("birthDate")]
	        public string BirthDate { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("carNo")]
	        public string CarNo { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("career")]
	        public string Career { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("company")]
	        public string Company { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("countryCode")]
	        public string CountryCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("countryCodeCiq")]
	        public string CountryCodeCiq { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("countryCodeCus")]
	        public string CountryCodeCus { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("detailAddress")]
	        public string DetailAddress { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("fax")]
	        public string Fax { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("gender")]
	        public string Gender { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("idNumber")]
	        public string IdNumber { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("idType")]
	        public string IdType { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("tel")]
	        public string Tel { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("town")]
	        public string Town { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("zipCode")]
	        public string ZipCode { get; set; }
}

	/// <summary>
/// OrderLineDomain Data Structure.
/// </summary>
[Serializable]
[Top.Api.Util.ApiListType("orderLine")]
public class OrderLineDomain
{
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("actualPrice")]
	        public string ActualPrice { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("actualQty")]
	        public string ActualQty { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("amount")]
	        public string Amount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlArray("batchs")]
	        [XmlArrayItem("batch")]
	        public List<BatchDomain> Batchs { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("color")]
	        public string Color { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("deliveryOrderId")]
	        public string DeliveryOrderId { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("discount")]
	        public string Discount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("discountAmount")]
	        public string DiscountAmount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("discountPrice")]
	        public string DiscountPrice { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("exceptionQty")]
	        public string ExceptionQty { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("expireDate")]
	        public string ExpireDate { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("extCode")]
	        public string ExtCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("itemName")]
	        public string ItemName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("locationCode")]
	        public string LocationCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("moveInLocation")]
	        public string MoveInLocation { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("moveOutLocation")]
	        public string MoveOutLocation { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("orderLineNo")]
	        public string OrderLineNo { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("orderSourceCode")]
	        public string OrderSourceCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("outBizCode")]
	        public string OutBizCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("ownerCode")]
	        public string OwnerCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("payNo")]
	        public string PayNo { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("planQty")]
	        public string PlanQty { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("produceCode")]
	        public string ProduceCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("productCode")]
	        public string ProductCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("productDate")]
	        public string ProductDate { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("purchasePrice")]
	        public string PurchasePrice { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("qrCode")]
	        public string QrCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("quantity")]
	        public string Quantity { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("referencePrice")]
	        public string ReferencePrice { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("retailPrice")]
	        public string RetailPrice { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("settlementAmount")]
	        public string SettlementAmount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("size")]
	        public string Size { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("skuProperty")]
	        public string SkuProperty { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("sourceOrderCode")]
	        public string SourceOrderCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("standardAmount")]
	        public string StandardAmount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("standardPrice")]
	        public string StandardPrice { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("stockInQty")]
	        public string StockInQty { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("stockOutQty")]
	        public string StockOutQty { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("subDeliveryOrderId")]
	        public string SubDeliveryOrderId { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("subSourceCode")]
	        public string SubSourceCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("subSourceOrderCode")]
	        public string SubSourceOrderCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("taobaoItemCode")]
	        public string TaobaoItemCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
}

	/// <summary>
/// PackageMaterialDomain Data Structure.
/// </summary>
[Serializable]
[Top.Api.Util.ApiListType("packageMaterial")]
public class PackageMaterialDomain
{
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("quantity")]
	        public string Quantity { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// PackageDomain Data Structure.
/// </summary>
[Serializable]
[Top.Api.Util.ApiListType("package")]
public class PackageDomain
{
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("expressCode")]
	        public string ExpressCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("height")]
	        public string Height { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("invoiceNo")]
	        public string InvoiceNo { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlArray("items")]
	        [XmlArrayItem("item")]
	        public List<ItemDomain> Items { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("length")]
	        public string Length { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("logisticsCode")]
	        public string LogisticsCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("logisticsName")]
	        public string LogisticsName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("packageCode")]
	        public string PackageCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlArray("packageMaterialList")]
	        [XmlArrayItem("packageMaterial")]
	        public List<PackageMaterialDomain> PackageMaterialList { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("theoreticalWeight")]
	        public string TheoreticalWeight { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("volume")]
	        public string Volume { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("weight")]
	        public string Weight { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("width")]
	        public string Width { get; set; }
}

	/// <summary>
/// RelatedOrderDomain Data Structure.
/// </summary>
[Serializable]
[Top.Api.Util.ApiListType("relatedOrder")]
public class RelatedOrderDomain
{
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("orderCode")]
	        public string OrderCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("orderType")]
	        public string OrderType { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
}

	/// <summary>
/// DeliveryOrderDomain Data Structure.
/// </summary>
[Serializable]

public class DeliveryOrderDomain
{
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("actualAmount")]
	        public string ActualAmount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("arAmount")]
	        public string ArAmount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("businessMemo")]
	        public string BusinessMemo { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("buyerMessage")]
	        public string BuyerMessage { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("buyerName")]
	        public string BuyerName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("buyerNick")]
	        public string BuyerNick { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("buyerPhone")]
	        public string BuyerPhone { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("collectedAmount")]
	        public string CollectedAmount { get; set; }
	
	        /// <summary>
	        /// 支持出库单多次发货(多次发货后确认时;0表示发货单最终状态确认;1表示发货单中间状态确认)
	        /// </summary>
	        [XmlElement("confirmType")]
	        public Nullable<long> ConfirmType { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("createTime")]
	        public string CreateTime { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("declaredAmount")]
	        public string DeclaredAmount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("deliveryNote")]
	        public string DeliveryNote { get; set; }
	
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
	        /// null
	        /// </summary>
	        [XmlElement("deliveryRequirements")]
	        public DeliveryRequirementsDomain DeliveryRequirements { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("discountAmount")]
	        public string DiscountAmount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("exceptionCode")]
	        public string ExceptionCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("expressCode")]
	        public string ExpressCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("fetchItemLocation")]
	        public string FetchItemLocation { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("freight")]
	        public string Freight { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("gotAmount")]
	        public string GotAmount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("identifyCode")]
	        public string IdentifyCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("insuranceFlag")]
	        public string InsuranceFlag { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("invoiceFlag")]
	        public string InvoiceFlag { get; set; }
	
	        /// <summary>
	        /// 发票信息
	        /// </summary>
	        [XmlArray("invoices")]
	        [XmlArrayItem("invoice")]
	        public List<InvoiceDomain> Invoices { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("isCod")]
	        public string IsCod { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("isPaymentCollected")]
	        public string IsPaymentCollected { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("isUrgency")]
	        public string IsUrgency { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("isValueDeclared")]
	        public string IsValueDeclared { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("itemAmount")]
	        public string ItemAmount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("itemName")]
	        public string ItemName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlArray("items")]
	        [XmlArrayItem("item")]
	        public List<ItemDomain> Items { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("lineNumber")]
	        public string LineNumber { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("logisticsAreaCode")]
	        public string LogisticsAreaCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("logisticsCode")]
	        public string LogisticsCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("logisticsName")]
	        public string LogisticsName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("maxArrivalTime")]
	        public string MaxArrivalTime { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("mergeOrderCodes")]
	        public string MergeOrderCodes { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("mergeOrderFlag")]
	        public string MergeOrderFlag { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("minArrivalTime")]
	        public string MinArrivalTime { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("modifiedTime")]
	        public string ModifiedTime { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("noStackTag")]
	        public string NoStackTag { get; set; }
	
	        /// <summary>
	        /// 当前状态操作时间(YYYY-MM-DD HH:MM:SS)
	        /// </summary>
	        [XmlElement("operateTime")]
	        public string OperateTime { get; set; }
	
	        /// <summary>
	        /// 当前状态操作员编码
	        /// </summary>
	        [XmlElement("operatorCode")]
	        public string OperatorCode { get; set; }
	
	        /// <summary>
	        /// 当前状态操作员姓名
	        /// </summary>
	        [XmlElement("operatorName")]
	        public string OperatorName { get; set; }
	
	        /// <summary>
	        /// 订单完成时间(YYYY-MM-DD HH:MM:SS)
	        /// </summary>
	        [XmlElement("orderConfirmTime")]
	        public string OrderConfirmTime { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("orderFlag")]
	        public string OrderFlag { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlArray("orderLines")]
	        [XmlArrayItem("orderLine")]
	        public List<OrderLineDomain> OrderLines { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("orderNote")]
	        public string OrderNote { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("orderSourceCode")]
	        public string OrderSourceCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("orderStatus")]
	        public string OrderStatus { get; set; }
	
	        /// <summary>
	        /// 出库单类型(JYCK=一般交易出库;HHCK=换货出库;BFCK=补发出库;QTCK=其他出库单)
	        /// </summary>
	        [XmlElement("orderType")]
	        public string OrderType { get; set; }
	
	        /// <summary>
	        /// 外部业务编码(消息ID;用于去重;ISV对于同一请求;分配一个唯一性的编码。用来保证因为网络等原因导致重复传输;请求 不会被重复处理;条件必填;条件为一单需要多次确认时)
	        /// </summary>
	        [XmlElement("outBizCode")]
	        public string OutBizCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("ownerCode")]
	        public string OwnerCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("packCode")]
	        public string PackCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlArray("packages")]
	        [XmlArrayItem("package")]
	        public List<PackageDomain> Packages { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("payMethod")]
	        public string PayMethod { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("payNo")]
	        public string PayNo { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("payTime")]
	        public string PayTime { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("personalOrderNote")]
	        public string PersonalOrderNote { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("personalPackageNote")]
	        public string PersonalPackageNote { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("pickerInfo")]
	        public PickerInfoDomain PickerInfo { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("placeOrderTime")]
	        public string PlaceOrderTime { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("planArrivalTime")]
	        public string PlanArrivalTime { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("planDeliveryDate")]
	        public string PlanDeliveryDate { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("preDeliveryOrderCode")]
	        public string PreDeliveryOrderCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("preDeliveryOrderId")]
	        public string PreDeliveryOrderId { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("presaleOrderType")]
	        public string PresaleOrderType { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("price")]
	        public string Price { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("priorityCode")]
	        public string PriorityCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("produceDate")]
	        public string ProduceDate { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("quantity")]
	        public string Quantity { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("receiveOrderTime")]
	        public string ReceiveOrderTime { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("receiverInfo")]
	        public ReceiverInfoDomain ReceiverInfo { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlArray("relatedOrders")]
	        [XmlArrayItem("relatedOrder")]
	        public List<RelatedOrderDomain> RelatedOrders { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlArray("remark")]
	        [XmlArrayItem("string")]
	        public List<string> Remark { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("salesModel")]
	        public string SalesModel { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("scheduleDate")]
	        public string ScheduleDate { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("sellerId")]
	        public string SellerId { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("sellerMessage")]
	        public string SellerMessage { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("sellerNick")]
	        public string SellerNick { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("senderInfo")]
	        public SenderInfoDomain SenderInfo { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("serviceCode")]
	        public string ServiceCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("serviceFee")]
	        public string ServiceFee { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("shelfLife")]
	        public string ShelfLife { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("shopCode")]
	        public string ShopCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("shopNick")]
	        public string ShopNick { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("sourceOrderCode")]
	        public string SourceOrderCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("sourcePlatformCode")]
	        public string SourcePlatformCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("sourcePlatformName")]
	        public string SourcePlatformName { get; set; }
	
	        /// <summary>
	        /// 出库单状态(NEW-未开始处理;ACCEPT-仓库接单;PARTDELIVERED-部分发货完成;DELIVERED-发货完成;EXCEPTION-异 常;CANCELED-取消;CLOSED-关闭;REJECT-拒单;CANCELEDFAIL-取消失败;只传英文编 码)
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 仓储费用
	        /// </summary>
	        [XmlElement("storageFee")]
	        public string StorageFee { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("supplierCode")]
	        public string SupplierCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("supplierName")]
	        public string SupplierName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("totalAmount")]
	        public string TotalAmount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("totalOrderLines")]
	        public string TotalOrderLines { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("transportMode")]
	        public string TransportMode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("transpostSum")]
	        public string TranspostSum { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("uomCode")]
	        public string UomCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("warehouseAddressCode")]
	        public string WarehouseAddressCode { get; set; }
	
	        /// <summary>
	        /// 仓库编码
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
}

	/// <summary>
/// OrderDomain Data Structure.
/// </summary>
[Serializable]

public class OrderDomain
{
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("deliveryOrder")]
	        public DeliveryOrderDomain DeliveryOrder { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("deliveryOrderCode")]
	        public string DeliveryOrderCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("message")]
	        public string Message { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlArray("orderLines")]
	        [XmlArrayItem("orderLine")]
	        public List<OrderLineDomain> OrderLines { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlArray("packages")]
	        [XmlArrayItem("package")]
	        public List<PackageDomain> Packages { get; set; }
}

        #endregion
    }
}
