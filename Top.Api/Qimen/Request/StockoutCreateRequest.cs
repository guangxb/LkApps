using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.stockout.create
    /// </summary>
    public class StockoutCreateRequest : QimenRequest<Qimen.Api.Response.StockoutCreateResponse>
    {
        public DeliveryOrderDomain DeliveryOrder { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        public List<ItemDomain> Items { get; set; }

        public List<OrderLineDomain> OrderLines { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.stockout.create";
        }


	/// <summary>
/// RelatedOrderDomain Data Structure.
/// </summary>
[Serializable]

public class RelatedOrderDomain
{
	        /// <summary>
	        /// 关联的订单编号
	        /// </summary>
	        [XmlElement("orderCode")]
	        public string OrderCode { get; set; }
	
	        /// <summary>
	        /// 关联的订单类型(CG=采购单;DB=调拨单;CK=出库单;RK=入库单;只传英文编码)
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
	        /// 车牌号
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
	        /// 公司名称
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
	        /// 证件号
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
	        [XmlElement("receiverMobile")]
	        public string ReceiverMobile { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("receiverName")]
	        public string ReceiverName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("receiverTel")]
	        public string ReceiverTel { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("receiverZipCode")]
	        public string ReceiverZipCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 固定电话
	        /// </summary>
	        [XmlElement("tel")]
	        public string Tel { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("town")]
	        public string Town { get; set; }
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
	        /// 证件号
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
	        /// null
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 省份
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("receiverMobile")]
	        public string ReceiverMobile { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("receiverName")]
	        public string ReceiverName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("receiverTel")]
	        public string ReceiverTel { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("receiverZipCode")]
	        public string ReceiverZipCode { get; set; }
	
	        /// <summary>
	        /// null
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
/// ReceiverInfoDomain Data Structure.
/// </summary>
[Serializable]

public class ReceiverInfoDomain
{
	        /// <summary>
	        /// 区域
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
	        /// 证件号
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 收件人证件号码
	        /// </summary>
	        [XmlElement("idNumber")]
	        public string IdNumber { get; set; }
	
	        /// <summary>
	        /// 收件人证件类型(1-身份证、2-军官证、3-护照、4-其他)
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
	        /// null
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 省份
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("receiverMobile")]
	        public string ReceiverMobile { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("receiverName")]
	        public string ReceiverName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("receiverTel")]
	        public string ReceiverTel { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("receiverZipCode")]
	        public string ReceiverZipCode { get; set; }
	
	        /// <summary>
	        /// null
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
[Top.Api.Util.ApiListType("item")]
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
	        /// null
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
	        /// null
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
	        /// null
	        /// </summary>
	        [XmlElement("quantity")]
	        public string Quantity { get; set; }
	
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
	        /// null
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
	        /// null
	        /// </summary>
	        [XmlArray("items")]
	        [XmlArrayItem("item")]
	        public List<ItemDomain> Items { get; set; }
}

	/// <summary>
/// InvoiceDomain Data Structure.
/// </summary>
[Serializable]
[Top.Api.Util.ApiListType("invoice")]
public class InvoiceDomain
{
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("detail")]
	        public DetailDomain Detail { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("invoiceAmount")]
	        public string InvoiceAmount { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("invoiceContent")]
	        public string InvoiceContent { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("invoiceHead")]
	        public string InvoiceHead { get; set; }
	
	        /// <summary>
	        /// null
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
	        /// null
	        /// </summary>
	        [XmlElement("confirmType")]
	        public string ConfirmType { get; set; }
	
	        /// <summary>
	        /// 出库单创建时间(YYYY-MM-DD HH:MM:SS)
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
	        /// null
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
	        /// 物流公司编码(SF=顺丰、EMS=标准快递、EYB=经济快件、ZJS=宅急送、YTO=圆通 、ZTO=中通(ZTO)、HTKY=百世汇通、UC=优速、STO=申通、TTKDEX=天天快递、QFKD=全峰、FAST=快捷、POSTB=邮政小包、GTO=国通、YUNDA=韵达、JD=京东配送、DD=当当宅配、AMAZON=亚马逊物流、OTHER=其他;只传英文编码)
	        /// </summary>
	        [XmlElement("logisticsCode")]
	        public string LogisticsCode { get; set; }
	
	        /// <summary>
	        /// 物流公司名称(包括干线物流公司等)
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
	        /// null
	        /// </summary>
	        [XmlElement("operateTime")]
	        public string OperateTime { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("operatorCode")]
	        public string OperatorCode { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("operatorName")]
	        public string OperatorName { get; set; }
	
	        /// <summary>
	        /// null
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
	        /// 出库单类型(PTCK=普通出库单;DBCK=调拨出库;B2BCK=B2B出库;QTCK=其他出库;CGTH=采购退货出库单;XNCK=虚拟出库单)
	        /// </summary>
	        [XmlElement("orderType")]
	        public string OrderType { get; set; }
	
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
	        /// 提货人信息
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
	        /// 收件人信息
	        /// </summary>
	        [XmlElement("receiverInfo")]
	        public ReceiverInfoDomain ReceiverInfo { get; set; }
	
	        /// <summary>
	        /// 关联单据信息
	        /// </summary>
	        [XmlArray("relatedOrders")]
	        [XmlArrayItem("related_order")]
	        public List<RelatedOrderDomain> RelatedOrders { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("salesModel")]
	        public string SalesModel { get; set; }
	
	        /// <summary>
	        /// 要求出库时间(YYYY-MM-DD)
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
	        /// 发件人信息
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
	        [XmlElement("shopName")]
	        public string ShopName { get; set; }
	
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
	        /// null
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("storageFee")]
	        public string StorageFee { get; set; }
	
	        /// <summary>
	        /// 供应商编码
	        /// </summary>
	        [XmlElement("supplierCode")]
	        public string SupplierCode { get; set; }
	
	        /// <summary>
	        /// 供应商名称
	        /// </summary>
	        [XmlElement("supplierName")]
	        public string SupplierName { get; set; }
	
	        /// <summary>
	        /// null
	        /// </summary>
	        [XmlElement("totalAmount")]
	        public string TotalAmount { get; set; }
	
	        /// <summary>
	        /// 单据总行数(当单据需要分多个请求发送时;发送方需要将totalOrderLines填入;接收方收到后;根据实际接收到的条数和totalOrderLines进行比对;如果小于;则继续等待接收请求。如果等于;则表示该单据的所有请求发送完成.)
	        /// </summary>
	        [XmlElement("totalOrderLines")]
	        public Nullable<long> TotalOrderLines { get; set; }
	
	        /// <summary>
	        /// 提货方式(到仓自提、快递、干线物流)
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
	        /// 仓库编码(统仓统配等无需ERP指定仓储编码的情况填OTHER)
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
}

        #endregion
    }
}
