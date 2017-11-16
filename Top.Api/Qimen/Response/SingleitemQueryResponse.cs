using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// SingleitemQueryResponse.
    /// </summary>
    /// 
    [XmlRoot("response", Namespace = "", IsNullable = false)]
    public class SingleitemQueryResponse : QimenResponse
    {
        /// <summary>
        /// item
        /// </summary>
        [XmlElement("item")]
        public ItemDomain Item { get; set; }

	/// <summary>
/// ItemDomain Data Structure.
/// </summary>
[Serializable]

public class ItemDomain : TopObject
{
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("adventLifecycle")]
	        public string AdventLifecycle { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("approvalNumber")]
	        public string ApprovalNumber { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("barCode")]
	        public string BarCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("batchRemark")]
	        public string BatchRemark { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("brandCode")]
	        public string BrandCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("brandName")]
	        public string BrandName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("categoryId")]
	        public string CategoryId { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("categoryName")]
	        public string CategoryName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("color")]
	        public string Color { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("costPrice")]
	        public string CostPrice { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("createTime")]
	        public string CreateTime { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("englishName")]
	        public string EnglishName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("expireDate")]
	        public string ExpireDate { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("goodsCode")]
	        public string GoodsCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("grossWeight")]
	        public string GrossWeight { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("height")]
	        public string Height { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("isAreaSale")]
	        public string IsAreaSale { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("isBatchMgmt")]
	        public string IsBatchMgmt { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("isFragile")]
	        public string IsFragile { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("isHazardous")]
	        public string IsHazardous { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("isSNMgmt")]
	        public string IsSNMgmt { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("isShelfLifeMgmt")]
	        public string IsShelfLifeMgmt { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("isSku")]
	        public string IsSku { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("isValid")]
	        public string IsValid { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("itemName")]
	        public string ItemName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("itemType")]
	        public string ItemType { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("length")]
	        public string Length { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("lockupLifecycle")]
	        public string LockupLifecycle { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("netWeight")]
	        public string NetWeight { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("originAddress")]
	        public string OriginAddress { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("packCode")]
	        public string PackCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("packageMaterial")]
	        public string PackageMaterial { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("pcs")]
	        public string Pcs { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("pricingCategory")]
	        public string PricingCategory { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("productDate")]
	        public string ProductDate { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("purchasePrice")]
	        public string PurchasePrice { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("rejectLifecycle")]
	        public string RejectLifecycle { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("retailPrice")]
	        public string RetailPrice { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("safetyStock")]
	        public string SafetyStock { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("seasonCode")]
	        public string SeasonCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("seasonName")]
	        public string SeasonName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("shelfLife")]
	        public string ShelfLife { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("shortName")]
	        public string ShortName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("size")]
	        public string Size { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("skuProperty")]
	        public string SkuProperty { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("stockUnit")]
	        public string StockUnit { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("tagPrice")]
	        public string TagPrice { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("updateTime")]
	        public string UpdateTime { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("volume")]
	        public string Volume { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,H123,string(50),必填,
	        /// </summary>
	        [XmlElement("width")]
	        public string Width { get; set; }
}

    }
}
