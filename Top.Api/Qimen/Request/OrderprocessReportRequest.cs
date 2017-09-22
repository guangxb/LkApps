using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.orderprocess.report
    /// </summary>
    public class OrderprocessReportRequest : QimenRequest<Qimen.Api.Response.OrderprocessReportResponse>
    {
        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        public OrderDomain Order { get; set; }

        public ProcessDomain Process { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.orderprocess.report";
        }


	/// <summary>
/// OrderInfoDomain Data Structure.
/// </summary>
[Serializable]

public class OrderInfoDomain
{
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("VIPCardNo")]
	        public string VIPCardNo { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("VIPCode")]
	        public string VIPCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("VIPMobilePhone")]
	        public string VIPMobilePhone { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("VIPName")]
	        public string VIPName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("change")]
	        public string Change { get; set; }
	
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
	        [XmlElement("logisticsCode")]
	        public string LogisticsCode { get; set; }
	
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
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("orderCode")]
	        public string OrderCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("orderCreateTime")]
	        public string OrderCreateTime { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("orderDate")]
	        public string OrderDate { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("orderStatus")]
	        public string OrderStatus { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("orderType")]
	        public string OrderType { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("orgCode")]
	        public string OrgCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("page")]
	        public string Page { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("paidAmount")]
	        public string PaidAmount { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("paymentAccount")]
	        public string PaymentAccount { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("paymentType")]
	        public string PaymentType { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("posCode")]
	        public string PosCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("preOrderCode")]
	        public string PreOrderCode { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("roundingAmount")]
	        public string RoundingAmount { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("saleDate")]
	        public string SaleDate { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("salesPersonCode")]
	        public string SalesPersonCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("salesPersonName")]
	        public string SalesPersonName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("salesPersonTaobaoNick")]
	        public string SalesPersonTaobaoNick { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("standardAmount")]
	        public string StandardAmount { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("stockInTime")]
	        public string StockInTime { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("stockOutTime")]
	        public string StockOutTime { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("storeCode")]
	        public string StoreCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("taobaoStoreCode")]
	        public string TaobaoStoreCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("targetStoreCode")]
	        public string TargetStoreCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("totalActualAmount")]
	        public string TotalActualAmount { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("totalActualQty")]
	        public string TotalActualQty { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("totalAmount")]
	        public string TotalAmount { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("totalAmountBeforeDiscount")]
	        public string TotalAmountBeforeDiscount { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("totalPage")]
	        public string TotalPage { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("totalPlanQty")]
	        public string TotalPlanQty { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("totalQty")]
	        public string TotalQty { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("totalStockInQty")]
	        public string TotalStockInQty { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("totalStockOutQty")]
	        public string TotalStockOutQty { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
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
	        /// 奇门仓储字段,说明,string(50),,
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
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
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
	        /// 奇门仓储字段,说明,string(50),,
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
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("ownerCode")]
	        public string OwnerCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("payNo")]
	        public string PayNo { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("planQty")]
	        public string PlanQty { get; set; }
	
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
	        /// 奇门仓储字段,说明,string(50),,
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
	        /// 奇门仓储字段,说明,string(50),,
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

	/// <summary>
/// OrderDomain Data Structure.
/// </summary>
[Serializable]

public class OrderDomain
{
	        /// <summary>
	        /// 单据号
	        /// </summary>
	        [XmlElement("orderCode")]
	        public string OrderCode { get; set; }
	
	        /// <summary>
	        /// 仓储系统单据号
	        /// </summary>
	        [XmlElement("orderId")]
	        public string OrderId { get; set; }
	
	        /// <summary>
	        /// orderInfo
	        /// </summary>
	        [XmlElement("orderInfo")]
	        public OrderInfoDomain OrderInfo { get; set; }
	
	        /// <summary>
	        /// orderLines
	        /// </summary>
	        [XmlArray("orderLines")]
	        [XmlArrayItem("order_line")]
	        public List<OrderLineDomain> OrderLines { get; set; }
	
	        /// <summary>
	        /// 单据类型(JYCK=一般交易出库单;HHCK=换货出库;BFCK=补发出库;PTCK=普通出库单;DBCK=调拨出库;B2BRK=B2B入 库;B2BCK=B2B出库;QTCK=其他出库;SCRK=生产入库;LYRK=领用入库;CCRK=残次品入库;CGRK=采购入库;DBRK= 调拨入库;QTRK= 其他入 库;XTRK= 销退入库;HHRK= 换货入库;CNJG= 仓内加工单)
	        /// </summary>
	        [XmlElement("orderType")]
	        public string OrderType { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 仓库编码
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("warehouseName")]
	        public string WarehouseName { get; set; }
}

	/// <summary>
/// ProcessDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessDomain
{
	        /// <summary>
	        /// 操作内容
	        /// </summary>
	        [XmlElement("operateInfo")]
	        public string OperateInfo { get; set; }
	
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
	        /// 单据状态(ACCEPT=仓库接单;PARTFULFILLED-部分收货完成;FULFILLED=收货完成;PRINT = 打印;PICK=捡货;CHECK = 复核 ;PACKAGE= 打包;WEIGH= 称重;READY=待提货;DELIVERED=已发货;REFUSE=买家拒签;EXCEPTION =异常;CLOSED= 关闭;CANCELED= 取 消;REJECT=仓库拒单;SIGN=签收;TMSCANCELED=快递拦截;OTHER=其他;PARTDELIVERED=部分发货完成;TMSCANCELFAILED=快递拦截失败;只传英 文编码)
	        /// </summary>
	        [XmlElement("processStatus")]
	        public string ProcessStatus { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
}

        #endregion
    }
}
