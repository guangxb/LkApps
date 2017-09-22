using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace QiMenApi.Models
{

    public class DeliveryorderQueryModel
    {
    }


    [XmlRoot("request")]
    public class DeliveryorderQueryRequestModel
    {
        /// <summary>
        /// 奇门仓储字段,说明,string(50),,
        /// </summary>
        public string DeliveryOrderCode { get; set; }

        /// <summary>
        /// 奇门仓储字段,说明,string(50),,
        /// </summary>
        public string DeliveryOrderId { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        /// <summary>
        /// 发库单号
        /// </summary>
        public string OrderCode { get; set; }

        /// <summary>
        /// 仓储系统发库单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>
        public string OrderSourceCode { get; set; }

        /// <summary>
        /// 货主编码
        /// </summary>
        public string OwnerCode { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        public Nullable<long> Page { get; set; }

        /// <summary>
        /// 每页orderLine条数(最多100条)
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 奇门仓储字段,说明,string(50),,
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        public string WarehouseCode { get; set; }
    }

    [XmlRoot("response")]
    public class DeliveryorderQueryResponseModel
    {

        [XmlElement("flag")]
        public string Flag { get; set; }

        [XmlElement("code")]
        public string Code { get; set; }

        [XmlElement("message")]
        public string Message { get; set; }
        /// <summary>
        /// 发货单信息
        /// </summary>
        [XmlElement("deliveryOrder")]
        public DeliveryOrderDomain DeliveryOrder { get; set; }

        /// <summary>
        /// 单据列表
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
        /// ItemDomain Data Structure.
        /// </summary>
        [Serializable]

        public class ItemDomain
        {
            /// <summary>
            /// 金额
            /// </summary>
            [XmlElement("amount")]
            public string Amount { get; set; }

            /// <summary>
            /// 商品名称
            /// </summary>
            [XmlElement("itemName")]
            public string ItemName { get; set; }

            /// <summary>
            /// 商品单价
            /// </summary>
            [XmlElement("price")]
            public string Price { get; set; }

            /// <summary>
            /// 数量
            /// </summary>
            [XmlElement("quantity")]
            public long Quantity { get; set; }

            /// <summary>
            /// 商品单位
            /// </summary>
            [XmlElement("unit")]
            public string Unit { get; set; }
        }

        /// <summary>
        /// DetailDomain Data Structure.
        /// </summary>
        [Serializable]

        public class DetailDomain
        {
            /// <summary>
            /// 商品列表
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
            /// 发货详情
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
        }

        /// <summary>
        /// DeliveryOrderDomain Data Structure.
        /// </summary>
        [Serializable]

        public class DeliveryOrderDomain
        {
            /// <summary>
            /// 支持出库单多次发货(多次发货后确认时;0表示发货单最终状态确认;1表示发货单中间状态确 认)
            /// </summary>
            [XmlElement("confirmType")]
            public long ConfirmType { get; set; }

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
            /// 发票信息
            /// </summary>
            [XmlArray("invoices")]
            [XmlArrayItem("invoice")]
            public List<InvoiceDomain> Invoices { get; set; }

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
            /// 出库单类型(JYCK=一般交易出库;HHCK=换货出库;BFCK=补发出库;QTCK=其他出库单)
            /// </summary>
            [XmlElement("orderType")]
            public string OrderType { get; set; }

            /// <summary>
            /// 外部业务编码(消息ID;用于去重;ISV对于同一请求;分配一个唯一性的编码。用来保证因为网络等原因导致重复传输;请 求 不会被重复处理;条件必填;条件为一单需要多次确认时)
            /// </summary>
            [XmlElement("outBizCode")]
            public string OutBizCode { get; set; }

            /// <summary>
            /// 出库单状态(NEW-未开始处理;ACCEPT-仓库接单;PARTDELIVERED-部分发货完成;DELIVERED-发货完成;EXCEPTION-异 常;CANCELED-取消;CLOSED-关闭;REJECT-拒单;CANCELEDFAIL-取消失败;只传英文编码)
            /// </summary>
            [XmlElement("status")]
            public string Status { get; set; }

            /// <summary>
            /// 仓储费用
            /// </summary>
            [XmlElement("storageFee")]
            public string StorageFee { get; set; }

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

        public class PackageMaterialDomain
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
        /// PackageDomain Data Structure.
        /// </summary>
        [Serializable]

        public class PackageDomain
        {
            /// <summary>
            /// 运单号
            /// </summary>
            [XmlElement("expressCode")]
            public string ExpressCode { get; set; }

            /// <summary>
            /// 包裹高度(单位：厘米)
            /// </summary>
            [XmlElement("height")]
            public string Height { get; set; }

            /// <summary>
            /// 发票号
            /// </summary>
            [XmlElement("invoiceNo")]
            public string InvoiceNo { get; set; }

            /// <summary>
            /// 商品列表
            /// </summary>
            [XmlArray("items")]
            [XmlArrayItem("item")]
            public List<ItemDomain> Items { get; set; }

            /// <summary>
            /// 包裹长度(单位：厘米)
            /// </summary>
            [XmlElement("length")]
            public string Length { get; set; }

            /// <summary>
            /// 物流公司编码(SF=顺丰、EMS=标准快递、EYB=经济快件、ZJS=宅急送、YTO=圆通、ZTO=中通 (ZTO)、HTKY=百世汇 通、 UC=优速、STO=申通、TTKDEX=天天快递、QFKD=全峰、FAST=快捷、POSTB=邮政小包、GTO=国通、YUNDA=韵达、JD=京东配送、DD=当当宅 配、 AMAZON=亚马逊物流、OTHER=其他;只传英文编码)
            /// </summary>
            [XmlElement("logisticsCode")]
            public string LogisticsCode { get; set; }

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
            /// 包裹理论重量(单位：千克)
            /// </summary>
            [XmlElement("theoreticalWeight")]
            public string TheoreticalWeight { get; set; }

            /// <summary>
            /// 包裹体积(单位：升)
            /// </summary>
            [XmlElement("volume")]
            public string Volume { get; set; }

            /// <summary>
            /// 包裹重量(单位：千克)
            /// </summary>
            [XmlElement("weight")]
            public string Weight { get; set; }

            /// <summary>
            /// 包裹宽度(单位：厘米)
            /// </summary>
            [XmlElement("width")]
            public string Width { get; set; }
        }

        /// <summary>
        /// BatchDomain Data Structure.
        /// </summary>
        [Serializable]

        public class BatchDomain
        {
            /// <summary>
            /// 实发数量(要求batchs节点下所有的实发数量之和等于orderline中的实发数量)
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
            /// 库存类型(ZP=正品;CC=残次;JS=机损;XS=箱损;ZT=在途库存;默认为查所有类型的库存)
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
        }

        /// <summary>
        /// OrderLineDomain Data Structure.
        /// </summary>
        [Serializable]

        public class OrderLineDomain
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
            /// 批次列表
            /// </summary>
            [XmlArray("batchs")]
            [XmlArrayItem("batch")]
            public List<BatchDomain> Batchs { get; set; }

            /// <summary>
            /// 过期日期(YYYY-MM-DD)
            /// </summary>
            [XmlElement("expireDate")]
            public string ExpireDate { get; set; }

            /// <summary>
            /// 交易平台商品编码
            /// </summary>
            [XmlElement("extCode")]
            public string ExtCode { get; set; }

            /// <summary>
            /// 库存类型(ZP=正品;CC=残次;JS=机损;XS=箱损;ZT=在途库存;默认为查所有类型的库存)
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
            /// 平台交易订单编码
            /// </summary>
            [XmlElement("orderSourceCode")]
            public string OrderSourceCode { get; set; }

            /// <summary>
            /// 货主编码
            /// </summary>
            [XmlElement("ownerCode")]
            public string OwnerCode { get; set; }

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
            /// 生产日期(YYYY-MM-DD)
            /// </summary>
            [XmlElement("productDate")]
            public string ProductDate { get; set; }

            /// <summary>
            /// 商品的二维码(类似电子产品的SN码;用来进行商品的溯源;多个二维码之间用分号;隔开)
            /// </summary>
            [XmlElement("qrCode")]
            public string QrCode { get; set; }

            /// <summary>
            /// 平台交易子订单编码
            /// </summary>
            [XmlElement("subSourceCode")]
            public string SubSourceCode { get; set; }
        }

    }
}