using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;

namespace Top.Api.Qimen.Custom.Request
{
    [XmlRoot("request")]
    public class DeliveryorderConfirmRequest : Custom.CustomRequest<Response.DeliveryorderConfirmResponse>
    {
        [XmlElement("deliveryOrder")]
        public DeliveryOrderDomain DeliveryOrder { get; set; }

        [XmlArray("orderLines"), XmlArrayItem("orderLine")]
        public List<OrderLineDomain> OrderLines { get; set; }

        [XmlArray("packages"), XmlArrayItem("package")]
        public List<PackageDomain> Packages { get; set; }

        [XmlElement("extendProps")]
        public string ExtendProps { get; set; }

        public override string GetApiName()
        {
            return "taobao.qimen.deliveryorder.confirm";
        }

        #region DeliveryOrderDomain
        /// <summary>
        /// DeliveryOrderDomain
        /// </summary>
        [Serializable]
        public class DeliveryOrderDomain
        {
            /// <summary>
            /// 支持出库单多次发货(多次发货后确认时;0表示发货单最终状态确认;1表示发货单中间状态确认)
            /// </summary>
            [XmlElement("confirmType")]
            [DefaultValue(0)]
            public Nullable<long> ConfirmType { get; set; }

            public bool ShouldSerializeConfirmType()
            {
                return ConfirmType != null;
            }

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
            /// 仓库编码
            /// </summary>
            [DefaultValue("LK01")]
            [XmlElement("warehouseCode")]
            public string WarehouseCode { get; set; }

            /// <summary>
            /// 出库单类型(JYCK=一般交易出库;HHCK=换货出库;BFCK=补发出库;QTCK=其他出库单)
            /// </summary>
            [XmlElement("orderType")]
            public string OrderType { get; set; }

            /// <summary>
            /// 出库单状态(NEW-未开始处理;ACCEPT-仓库接单;PARTDELIVERED-部分发货完成;DELIVERED-发货完成;EXCEPTION-异 常;CANCELED-取消;CLOSED-关闭;REJECT-拒单;CANCELEDFAIL-取消失败;只传英文编码)
            /// </summary>
            [XmlElement("status")]
            public string Status { get; set; }

            /// <summary>
            /// 外部业务编码(消息ID;用于去重;ISV对于同一请求;分配一个唯一性的编码。用来保证因为网络等原因导致重复传输;请求 不会被重复处理;条件必填;条件为一单需要多次确认时)
            /// </summary>
            [XmlElement("outBizCode")]
            public string OutBizCode { get; set; }

            /// <summary>
            /// 订单完成时间(YYYY-MM-DD HH:MM:SS)
            /// </summary>
            [XmlElement("orderConfirmTime")]
            public string OrderConfirmTime { get; set; }

            /// <summary>
            /// 仓储费用
            /// </summary>
            [XmlElement("storageFee")]
            public string StorageFee { get; set; }
        }
        #endregion

        #region OrderLineDomain
        /// <summary>
        /// OrderLineDomain
        /// </summary>
        [Serializable]
        public class OrderLineDomain
        {
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
            /// 平台交易子订单编码
            /// </summary>
            [XmlElement("subSourceCode")]
            public string SubSourceCode { get; set; }

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
            /// 库存类型(ZP=正品;CC=残次;JS=机损;XS=箱损;ZT=在途库存;默认为查所有类型的库存)
            /// </summary>
            [XmlElement("inventoryType")]
            public string InventoryType { get; set; }

            /// <summary>
            /// 货主编码
            /// </summary>
            [XmlElement("ownerCode")]
            public string OwnerCode { get; set; }

            /// <summary>
            /// 商品名称
            /// </summary>
            [XmlElement("itemName")]
            public string ItemName { get; set; }

            /// <summary>
            /// 交易平台商品编码
            /// </summary>
            [XmlElement("extCode")]
            public string ExtCode { get; set; }

            /// <summary>
            ///应发商品数量
            /// </summary>
            [XmlElement("planQty")]
            public string PlanQty { get; set; }

            /// <summary>
            /// 实发商品数量
            /// </summary>
            [XmlElement("actualQty")]
            public string ActualQty { get; set; }

            /// <summary>
            /// 生产日期(YYYY-MM-DD)
            /// </summary>
            [XmlElement("productDate")]
            public string ProductDate { get; set; }

            /// <summary>
            /// 过期日期(YYYY-MM-DD)
            /// </summary>
            [XmlElement("expireDate")]
            public string ExpireDate { get; set; }

            /// <summary>
            /// 生产批号
            /// </summary>
            [XmlElement("produceCode")]
            public string ProduceCode { get; set; }

            /// <summary>
            /// 商品的二维码(类似电子产品的SN码;用来进行商品的溯源;多个二维码之间用分号;隔开)
            /// </summary>
            [XmlElement("qrCode")]
            public string QrCode { get; set; }
        }
        #endregion

        #region PackageDomain
        [Serializable]
        public class PackageDomain
        {
            /// <summary>
            /// 物流公司编码(SF=顺丰、EMS=标准快递、EYB=经济快件、ZJS=宅急送、YTO=圆通、ZTO=中通 (ZTO)、HTKY=百世汇通、 UC=优速、STO=申通、TTKDEX=天天快递、QFKD=全峰、FAST=快捷、POSTB=邮政小包、GTO=国通、YUNDA=韵达、JD=京东配送、DD=当当宅配、 AMAZON=亚马逊物流、OTHER=其他;只传英文编码)
            /// </summary>
            [XmlElement("logisticsCode")]
            public string LogisticsCode { get; set; }

            /// <summary>
            /// 物流公司名称
            /// </summary>
            [XmlElement("logisticsName")]
            public string LogisticsName { get; set; }

            /// <summary>
            /// 运单号
            /// </summary>
            [XmlElement("expressCode")]
            public string ExpressCode { get; set; }

            /// <summary>
            /// 包裹编号
            /// </summary>
            [XmlElement("packageCode")]
            public string PackageCode { get; set; }

            [XmlArray("items"), XmlArrayItem("item")]
            public List<ItemDomain> Items { get; set; }

        } 
        #endregion

        #region ItemDomain
        /// <summary>
        /// ItemDomain Data Structure.
        /// </summary>
        [Serializable]
        public class ItemDomain
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
            /// 数量
            /// </summary>
            [XmlElement("quantity")]
            public Nullable<long> Quantity { get; set; }

        } 
        #endregion
    }
}
