using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.returnorder.create
    /// </summary>
    public class ReturnorderCreateRequest : QimenRequest<Qimen.Api.Response.ReturnorderCreateResponse>
    {
        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        public List<ItemDomain> ItemList { get; set; }

        public List<OrderLineDomain> OrderLines { get; set; }

        public ReturnOrderDomain ReturnOrder { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.returnorder.create";
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
            /// 奇门仓储字段,说明,string(50),,
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
            /// 奇门仓储字段,说明,string(50),,
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
            /// 奇门仓储字段,说明,string(50),,
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
            /// 奇门仓储字段,说明,string(50),,
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
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("itemCode")]
            public string ItemCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
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
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("orderCode")]
            public string OrderCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("orderLineNo")]
            public string OrderLineNo { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
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
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("outBizCode")]
            public string OutBizCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
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
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("produceCode")]
            public string ProduceCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("productCode")]
            public string ProductCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("productDate")]
            public string ProductDate { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("purchasePrice")]
            public string PurchasePrice { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("quantity")]
            public string Quantity { get; set; }

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
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("warehouseCode")]
            public string WarehouseCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("width")]
            public string Width { get; set; }
        }

        /// <summary>
        /// SenderInfoDomain Data Structure.
        /// </summary>
        [Serializable]

        public class SenderInfoDomain
        {
            /// <summary>
            /// 区域
            /// </summary>
            [XmlElement("area")]
            public string Area { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("birthDate")]
            public string BirthDate { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("carNo")]
            public string CarNo { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("career")]
            public string Career { get; set; }

            /// <summary>
            /// 城市
            /// </summary>
            [XmlElement("city")]
            public string City { get; set; }

            /// <summary>
            /// 公司名称
            /// </summary>
            [XmlElement("company")]
            public string Company { get; set; }

            /// <summary>
            /// 国家二字码
            /// </summary>
            [XmlElement("countryCode")]
            public string CountryCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("countryCodeCiq")]
            public string CountryCodeCiq { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("countryCodeCus")]
            public string CountryCodeCus { get; set; }

            /// <summary>
            /// 详细地址
            /// </summary>
            [XmlElement("detailAddress")]
            public string DetailAddress { get; set; }

            /// <summary>
            /// 电子邮箱
            /// </summary>
            [XmlElement("email")]
            public string Email { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("fax")]
            public string Fax { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("gender")]
            public string Gender { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("id")]
            public string Id { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("idNumber")]
            public string IdNumber { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("idType")]
            public string IdType { get; set; }

            /// <summary>
            /// 移动电话
            /// </summary>
            [XmlElement("mobile")]
            public string Mobile { get; set; }

            /// <summary>
            /// 姓名
            /// </summary>
            [XmlElement("name")]
            public string Name { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("nick")]
            public string Nick { get; set; }

            /// <summary>
            /// 省份
            /// </summary>
            [XmlElement("province")]
            public string Province { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [XmlElement("remark")]
            public string Remark { get; set; }

            /// <summary>
            /// 固定电话
            /// </summary>
            [XmlElement("tel")]
            public string Tel { get; set; }

            /// <summary>
            /// 村镇
            /// </summary>
            [XmlElement("town")]
            public string Town { get; set; }

            /// <summary>
            /// 邮编
            /// </summary>
            [XmlElement("zipCode")]
            public string ZipCode { get; set; }
        }

        /// <summary>
        /// ReturnOrderDomain Data Structure.
        /// </summary>
        [Serializable]

        public class ReturnOrderDomain
        {
            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("actionType")]
            public string ActionType { get; set; }

            /// <summary>
            /// 买家昵称
            /// </summary>
            [XmlElement("buyerNick")]
            public string BuyerNick { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("earliestArrivalTime")]
            public string EarliestArrivalTime { get; set; }

            /// <summary>
            /// 运单号
            /// </summary>
            [XmlElement("expressCode")]
            public string ExpressCode { get; set; }

            /// <summary>
            /// 物流公司编码(SF=顺丰、EMS=标准快递、EYB=经济快件、ZJS=宅急送、YTO=圆通、ZTO=中通(ZTO)、HTKY=百世汇通、 UC=优速、STO=申通、TTKDEX=天天快递、QFKD=全峰、FAST=快捷、POSTB=邮政小包、GTO=国通、YUNDA=韵达、JD=京东配送、DD=当当宅配、 AMAZON=亚马逊物流、OTHER=其他;只传英文编码)
            /// </summary>
            [XmlElement("logisticsCode")]
            public string LogisticsCode { get; set; }

            /// <summary>
            /// 物流公司名称
            /// </summary>
            [XmlElement("logisticsName")]
            public string LogisticsName { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("orderConfirmTime")]
            public string OrderConfirmTime { get; set; }

            /// <summary>
            /// 用字符串格式来表示订单标记列表(比如VISIT^ SELLER_AFFORD^SYNC_RETURN_BILL等;中间用“^”来隔开订单标记list (所 有字母全部大写) VISIT=上门；SELLER_AFFORD=是否卖家承担运费(默认是)SYNC_RETURN_BILL=同时退回发票)
            /// </summary>
            [XmlElement("orderFlag")]
            public string OrderFlag { get; set; }

            /// <summary>
            /// 单据类型(THRK=退货入库;HHRK=换货入库;只传英文编码)
            /// </summary>
            [XmlElement("orderType")]
            public string OrderType { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("outBizCode")]
            public string OutBizCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("ownerCode")]
            public string OwnerCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("planArrivalTime")]
            public string PlanArrivalTime { get; set; }

            /// <summary>
            /// 原出库单号(ERP分配)
            /// </summary>
            [XmlElement("preDeliveryOrderCode")]
            public string PreDeliveryOrderCode { get; set; }

            /// <summary>
            /// 原出库单号(WMS分配)
            /// </summary>
            [XmlElement("preDeliveryOrderId")]
            public string PreDeliveryOrderId { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("refOrderCode")]
            public string RefOrderCode { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [XmlElement("remark")]
            public string Remark { get; set; }

            /// <summary>
            /// ERP的退货入库单编码
            /// </summary>
            [XmlElement("returnOrderCode")]
            public string ReturnOrderCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("returnOrderId")]
            public string ReturnOrderId { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("returnOrderStatus")]
            public string ReturnOrderStatus { get; set; }

            /// <summary>
            /// 退货原因
            /// </summary>
            [XmlElement("returnReason")]
            public string ReturnReason { get; set; }

            /// <summary>
            /// 发件人信息
            /// </summary>
            [XmlElement("senderInfo")]
            public SenderInfoDomain SenderInfo { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("sourceOrderCode")]
            public string SourceOrderCode { get; set; }

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
            /// 仓库编码(统仓统配等无需ERP指定仓储编码的情况填OTHER)
            /// </summary>
            [XmlElement("warehouseCode")]
            public string WarehouseCode { get; set; }
        }

        /// <summary>
        /// OrderLineDomain Data Structure.
        /// </summary>
        [Serializable]

        public class OrderLineDomain
        {
            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("actualPrice")]
            public string ActualPrice { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("actualQty")]
            public string ActualQty { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("amount")]
            public string Amount { get; set; }

            /// <summary>
            /// 批次编码
            /// </summary>
            [XmlElement("batchCode")]
            public string BatchCode { get; set; }

            /// <summary>
            /// batchs
            /// </summary>
            [XmlArray("batchs")]
            [XmlArrayItem("batch")]
            public List<BatchDomain> Batchs { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("color")]
            public string Color { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("deliveryOrderId")]
            public string DeliveryOrderId { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("discount")]
            public string Discount { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("discountAmount")]
            public string DiscountAmount { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("discountPrice")]
            public string DiscountPrice { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("exceptionQty")]
            public string ExceptionQty { get; set; }

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
            /// 库存类型(ZP=正品;CC=残次;JS=机损;XS=箱损;默认为ZP)
            /// </summary>
            [XmlElement("inventoryType")]
            public string InventoryType { get; set; }

            /// <summary>
            /// 商品编码
            /// </summary>
            [XmlElement("itemCode")]
            public string ItemCode { get; set; }

            /// <summary>
            /// 仓储系统商品编码(条件为提供后端（仓储系统）商品编码的仓储系统)
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
            [XmlElement("locationCode")]
            public string LocationCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("moveInLocation")]
            public string MoveInLocation { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("moveOutLocation")]
            public string MoveOutLocation { get; set; }

            /// <summary>
            /// 单据行号
            /// </summary>
            [XmlElement("orderLineNo")]
            public string OrderLineNo { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("orderSourceCode")]
            public string OrderSourceCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
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
            [XmlElement("payNo")]
            public string PayNo { get; set; }

            /// <summary>
            /// 应收商品数量
            /// </summary>
            [XmlElement("planQty")]
            public Nullable<long> PlanQty { get; set; }

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
            /// 生产日期(YYYY-MM-DD)
            /// </summary>
            [XmlElement("productDate")]
            public string ProductDate { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("purchasePrice")]
            public string PurchasePrice { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("qrCode")]
            public string QrCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("quantity")]
            public string Quantity { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("referencePrice")]
            public string ReferencePrice { get; set; }

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
            [XmlElement("settlementAmount")]
            public string SettlementAmount { get; set; }

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
            /// 交易平台订单
            /// </summary>
            [XmlElement("sourceOrderCode")]
            public string SourceOrderCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("standardAmount")]
            public string StandardAmount { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("standardPrice")]
            public string StandardPrice { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("status")]
            public string Status { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("stockInQty")]
            public string StockInQty { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("stockOutQty")]
            public string StockOutQty { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("subDeliveryOrderId")]
            public string SubDeliveryOrderId { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("subSourceCode")]
            public string SubSourceCode { get; set; }

            /// <summary>
            /// 交易平台子订单编码
            /// </summary>
            [XmlElement("subSourceOrderCode")]
            public string SubSourceOrderCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("taobaoItemCode")]
            public string TaobaoItemCode { get; set; }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("warehouseCode")]
            public string WarehouseCode { get; set; }
        }

        #endregion
    }
}
