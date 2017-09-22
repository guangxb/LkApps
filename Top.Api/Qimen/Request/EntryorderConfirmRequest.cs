using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.entryorder.confirm
    /// </summary>
    /// 
    [XmlRoot("request")]
    public class EntryorderConfirmRequest : QimenRequest<Qimen.Api.Response.EntryorderConfirmResponse>
    {
        [XmlElement("entryOrder")]
        public EntryOrderDomain EntryOrder { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        public List<ItemDomain> Items { get; set; }

        [XmlArray("orderLines"),XmlArrayItem("orderLine")]
        public List<OrderLineDomain> OrderLines { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.entryorder.confirm";
        }


	/// <summary>
/// SenderInfoDomain Data Structure.
/// </summary>
[Serializable]

public class SenderInfoDomain
{
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
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
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("company")]
	        public string Company { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
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
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("detailAddress")]
	        public string DetailAddress { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
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
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("tel")]
	        public string Tel { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("town")]
	        public string Town { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
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
	        /// 奇门仓储字段,说明,string(50),,
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
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("company")]
	        public string Company { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
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
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("detailAddress")]
	        public string DetailAddress { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
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
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("tel")]
	        public string Tel { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("town")]
	        public string Town { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("zipCode")]
	        public string ZipCode { get; set; }
}

	/// <summary>
/// RelatedOrderDomain Data Structure.
/// </summary>
[Serializable]
[Top.Api.Util.ApiListType("relatedOrder")]
public class RelatedOrderDomain
{
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("orderCode")]
	        public string OrderCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("orderType")]
	        public string OrderType { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
}

	/// <summary>
/// EntryOrderDomain Data Structure.
/// </summary>
[Serializable]

public class EntryOrderDomain
{
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("businessId")]
	        public string BusinessId { get; set; }
	
	        /// <summary>
	        /// 支持出入库单多次收货(多次收货后确认时:0:表示入库单最终状态确认;1:表示入库单中间状态确认;每次入库传入的数量为增 量;特殊情况;同一入库单;如果先收到0;后又收到1;允许修改收货的数量)
	        /// </summary>
	        [XmlElement("confirmType")]
	        public Nullable<long> ConfirmType { get; set; }

            public bool ShouldSerializeConfirmType()
            {
                return ConfirmType != null;
            }

            /// <summary>
            /// 奇门仓储字段,说明,string(50),,
            /// </summary>
            [XmlElement("consignId")]
	        public string ConsignId { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("contractCode")]
	        public string ContractCode { get; set; }
	
	        /// <summary>
	        /// 入库单号
	        /// </summary>
	        [XmlElement("entryOrderCode")]
	        public string EntryOrderCode { get; set; }
	
	        /// <summary>
	        /// 仓储系统入库单ID
	        /// </summary>
	        [XmlElement("entryOrderId")]
	        public string EntryOrderId { get; set; }
	
	        /// <summary>
	        /// 入库单类型(SCRK=生产入库;LYRK=领用入库;CCRK=残次品入库;CGRK=采购入库;DBRK=调拨入库;QTRK=其他入 库;B2BRK=B2B入库)
	        /// </summary>
	        [XmlElement("entryOrderType")]
	        public string EntryOrderType { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("expectEndTime")]
	        public string ExpectEndTime { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("expectStartTime")]
	        public string ExpectStartTime { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("expressCode")]
	        public string ExpressCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("extOrderCode")]
	        public string ExtOrderCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("isCheck")]
	        public string IsCheck { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("isNudePackage")]
	        public string IsNudePackage { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("logisticsCode")]
	        public string LogisticsCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("logisticsContactName")]
	        public string LogisticsContactName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("logisticsContactNo")]
	        public string LogisticsContactNo { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("logisticsContactPhone")]
	        public string LogisticsContactPhone { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("logisticsName")]
	        public string LogisticsName { get; set; }
	
	        /// <summary>
	        /// 操作时间(YYYY-MM-DD HH:MM:SS;当status=FULFILLED;operateTime为入库时间)
	        /// </summary>
	        [XmlElement("operateTime")]
	        public string OperateTime { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("operatorCode")]
	        public string OperatorCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("operatorName")]
	        public string OperatorName { get; set; }
	
	        /// <summary>
	        /// 订单编码
	        /// </summary>
	        [XmlElement("orderCode")]
	        public string OrderCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("orderCreateTime")]
	        public string OrderCreateTime { get; set; }
	
	        /// <summary>
	        /// 后端订单id
	        /// </summary>
	        [XmlElement("orderId")]
	        public string OrderId { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("orderSource")]
	        public string OrderSource { get; set; }
	
	        /// <summary>
	        /// 订单类型
	        /// </summary>
	        [XmlElement("orderType")]
	        public string OrderType { get; set; }
	
	        /// <summary>
	        /// 外部业务编码(消息ID;用于去重;ISV对于同一请求;分配一个唯一性的编码。用来保证因为网络等原因导致重复传输;请求 不会被重复处理)
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
	        [XmlElement("planArrivalTime")]
	        public string PlanArrivalTime { get; set; }
	
	        /// <summary>
	        /// 采购单号(当orderType=CGRK时使用)
	        /// </summary>
	        [XmlElement("purchaseOrderCode")]
	        public string PurchaseOrderCode { get; set; }
	
	        /// <summary>
	        /// receiverInfo
	        /// </summary>
	        [XmlElement("receiverInfo")]
	        public ReceiverInfoDomain ReceiverInfo { get; set; }
	
	        /// <summary>
	        /// relatedOrders
	        /// </summary>
	        [XmlArray("relatedOrders")]
	        [XmlArrayItem("relatedOrder")]
	        public List<RelatedOrderDomain> RelatedOrders { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// senderInfo
	        /// </summary>
	        [XmlElement("senderInfo")]
	        public SenderInfoDomain SenderInfo { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("sizeDetail")]
	        public string SizeDetail { get; set; }
	
	        /// <summary>
	        /// 入库单状态(NEW-未开始处理;ACCEPT-仓库接单;PARTFULFILLED-部分收货完成;FULFILLED-收货完成;EXCEPTION-异 常;CANCELED-取消;CLOSED-关闭;REJECT-拒单;CANCELEDFAIL-取消失败;只传英文编码)
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("supplierAddress")]
	        public string SupplierAddress { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("supplierArea")]
	        public string SupplierArea { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("supplierCity")]
	        public string SupplierCity { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("supplierCode")]
	        public string SupplierCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("supplierEmail")]
	        public string SupplierEmail { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("supplierName")]
	        public string SupplierName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("supplierPhone")]
	        public string SupplierPhone { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("supplierProvince")]
	        public string SupplierProvince { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("supplierTel")]
	        public string SupplierTel { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("supplierTown")]
	        public string SupplierTown { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("supplierZipCode")]
	        public string SupplierZipCode { get; set; }
	
	        /// <summary>
	        /// 单据总行数(当单据需要分多个请求发送时;发送方需要将totalOrderLines填入;接收方收到后;根据实际接收到的 条数和 totalOrderLines进行比对;如果小于;则继续等待接收请求。如果等于;则表示该单据的所有请求发送完 成)
	        /// </summary>
	        [XmlElement("totalOrderLines")]
	        public Nullable<long> TotalOrderLines { get; set; }

            public bool ShouldSerializeTotalOrderLines()
            {
                return TotalOrderLines != null;
            }

            /// <summary>
            /// 仓库编码(统仓统配等无需ERP指定仓储编码的情况填OTHER)
            /// </summary>
            [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
	
	        /// <summary>
	        /// 仓库名称
	        /// </summary>
	        [XmlElement("warehouseName")]
	        public string WarehouseName { get; set; }
}

	/// <summary>
/// BatchDomain Data Structure.
/// </summary>
[Serializable]

public class BatchDomain
{
	        /// <summary>
	        /// 实收数量(要求batchs节点下所有的实收数量之和等于orderline中的实收数量)
	        /// </summary>
	        [XmlElement("actualQty")]
	        public Nullable<long> ActualQty { get; set; }
	
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
	        /// 库存类型(ZP=正品;CC=残次;JS=机损;XS= 箱损;默认为ZP;)
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
	        /// temp
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
/// OrderLineDomain Data Structure.
/// </summary>
[Serializable]

public class OrderLineDomain
{
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("actualPrice")]
	        public string ActualPrice { get; set; }
	
	        /// <summary>
	        /// 实收数量
	        /// </summary>
	        [XmlElement("actualQty")]
	        public Nullable<long> ActualQty { get; set; }
	
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
	        /// 批次信息
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
	        /// temp
	        /// </summary>
	        [XmlElement("deliveryOrderId")]
	        public string DeliveryOrderId { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("discount")]
	        public string Discount { get; set; }
	
	        /// <summary>
	        /// temp
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
	        /// 商品过期日期(YYYY-MM-DD)
	        /// </summary>
	        [XmlElement("expireDate")]
	        public string ExpireDate { get; set; }
	
	        /// <summary>
	        /// temp
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
	        /// 仓储系统商品ID
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 商品名称
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
	        /// 入库单的行号
	        /// </summary>
	        [XmlElement("orderLineNo")]
	        public string OrderLineNo { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("orderSourceCode")]
	        public string OrderSourceCode { get; set; }
	
	        /// <summary>
	        /// 外部业务编码(消息ID;用于去重;当单据需要分批次发送时使用)
	        /// </summary>
	        [XmlElement("outBizCode")]
	        public string OutBizCode { get; set; }
	
	        /// <summary>
	        /// 货主编码
	        /// </summary>
	        [XmlElement("ownerCode")]
	        public string OwnerCode { get; set; }
	
	        /// <summary>
	        /// temp
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
	        /// temp
	        /// </summary>
	        [XmlElement("qrCode")]
	        public string QrCode { get; set; }
	
	        /// <summary>
	        /// temp
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
	        /// temp
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
	        /// temp
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
	        /// temp
	        /// </summary>
	        [XmlElement("subDeliveryOrderId")]
	        public string SubDeliveryOrderId { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("subSourceCode")]
	        public string SubSourceCode { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("subSourceOrderCode")]
	        public string SubSourceOrderCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("taobaoItemCode")]
	        public string TaobaoItemCode { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
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
	        /// temp
	        /// </summary>
	        [XmlElement("adventLifecycle")]
	        public string AdventLifecycle { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("amount")]
	        public string Amount { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("approvalNumber")]
	        public string ApprovalNumber { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("barCode")]
	        public string BarCode { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// temp
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
	        /// temp
	        /// </summary>
	        [XmlElement("brandCode")]
	        public string BrandCode { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("brandName")]
	        public string BrandName { get; set; }
	
	        /// <summary>
	        /// v
	        /// </summary>
	        [XmlElement("categoryId")]
	        public string CategoryId { get; set; }
	
	        /// <summary>
	        /// v
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
	        /// temp
	        /// </summary>
	        [XmlElement("color")]
	        public string Color { get; set; }
	
	        /// <summary>
	        /// v
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
	        /// v
	        /// </summary>
	        [XmlElement("englishName")]
	        public string EnglishName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("exCode")]
	        public string ExCode { get; set; }
	
	        /// <summary>
	        /// temp
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
	        /// temp
	        /// </summary>
	        [XmlElement("grossWeight")]
	        public string GrossWeight { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("height")]
	        public string Height { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("isAreaSale")]
	        public string IsAreaSale { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("isBatchMgmt")]
	        public string IsBatchMgmt { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("isFragile")]
	        public string IsFragile { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("isHazardous")]
	        public string IsHazardous { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("isSNMgmt")]
	        public string IsSNMgmt { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("isShelfLifeMgmt")]
	        public string IsShelfLifeMgmt { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("isSku")]
	        public string IsSku { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// v
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// v
	        /// </summary>
	        [XmlElement("itemName")]
	        public string ItemName { get; set; }
	
	        /// <summary>
	        /// v
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
	        /// temp
	        /// </summary>
	        [XmlElement("length")]
	        public string Length { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("lockQuantity")]
	        public string LockQuantity { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("lockupLifecycle")]
	        public string LockupLifecycle { get; set; }
	
	        /// <summary>
	        /// temp
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
	        /// temp
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
	        /// temp
	        /// </summary>
	        [XmlElement("ownerCode")]
	        public string OwnerCode { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("packCode")]
	        public string PackCode { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("packageMaterial")]
	        public string PackageMaterial { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("paperQty")]
	        public string PaperQty { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("pcs")]
	        public string Pcs { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
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
	        /// temp
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
	        /// temp
	        /// </summary>
	        [XmlElement("productDate")]
	        public string ProductDate { get; set; }
	
	        /// <summary>
	        /// v
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
	        /// temp
	        /// </summary>
	        [XmlElement("rejectLifecycle")]
	        public string RejectLifecycle { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// v
	        /// </summary>
	        [XmlElement("retailPrice")]
	        public string RetailPrice { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("safetyStock")]
	        public string SafetyStock { get; set; }
	
	        /// <summary>
	        /// v
	        /// </summary>
	        [XmlElement("seasonCode")]
	        public string SeasonCode { get; set; }
	
	        /// <summary>
	        /// 商品信息
	        /// </summary>
	        [XmlElement("seasonName")]
	        public string SeasonName { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("shelfLife")]
	        public string ShelfLife { get; set; }
	
	        /// <summary>
	        /// vv
	        /// </summary>
	        [XmlElement("shortName")]
	        public string ShortName { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("size")]
	        public string Size { get; set; }
	
	        /// <summary>
	        /// v
	        /// </summary>
	        [XmlElement("skuProperty")]
	        public string SkuProperty { get; set; }
	
	        /// <summary>
	        /// temp
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
	        /// temp
	        /// </summary>
	        [XmlElement("stockStatus")]
	        public string StockStatus { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("stockUnit")]
	        public string StockUnit { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("subSourceOrderCode")]
	        public string SubSourceOrderCode { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("supplierCode")]
	        public string SupplierCode { get; set; }
	
	        /// <summary>
	        /// v
	        /// </summary>
	        [XmlElement("supplierName")]
	        public string SupplierName { get; set; }
	
	        /// <summary>
	        /// v
	        /// </summary>
	        [XmlElement("tagPrice")]
	        public string TagPrice { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("tareWeight")]
	        public string TareWeight { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("tempRequirement")]
	        public string TempRequirement { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("unit")]
	        public string Unit { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("volume")]
	        public string Volume { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
	
	        /// <summary>
	        /// temp
	        /// </summary>
	        [XmlElement("width")]
	        public string Width { get; set; }
}

        #endregion
    }
}
