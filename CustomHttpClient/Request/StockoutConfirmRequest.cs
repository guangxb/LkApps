using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CustomHttpClient.Request
{
    [XmlRoot("request")]
    public class StockoutConfirmRequest : CustomRequest<Response.StockoutConfirmResponse>
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
            return "taobao.qimen.stockout.confirm";
        }

        #region DeliveryOrderDomain
        [Serializable]
        public class DeliveryOrderDomain
        {

            /// <summary>
            /// 单据总行数
            /// </summary>
            [XmlElement("totalOrderLines")]
            public Nullable<long> TotalOrderLines { get; set; }
            public bool ShouldSerializeTotalOrderLines()
            {
                return TotalOrderLines != null;
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
            /// 仓库编码
            /// </summary>
            [XmlElement("warehouseCode")]
            public string WarehouseCode { get; set; }

            /// <summary>
            /// 出库单类型
            /// </summary>
            [XmlElement("orderType")]
            public string OrderType { get; set; }

            /// <summary>
            /// 出库单状态
            /// </summary>
            [XmlElement("status"), DefaultValue("FULFILLED")]
            public string Status { get; set; }

            /// <summary>
            /// 外部业务编码
            /// </summary>
            [XmlElement("outBizCode")]
            public string OutBizCode { get; set; }

            /// <summary>
	        /// 支持出入库单多次收货(多次收货后确认时:0:表示入库单最终状态确认;1:表示入库单中间状态确认;每次入库传入的数量为增 量;特殊情况;同一入库单;如果先收到0;后又收到1;允许修改收货的数量)
	        /// </summary>
	        [XmlElement("confirmType"), DefaultValue(0)]
            public Nullable<long> ConfirmType { get; set; }

            public bool ShouldSerializeConfirmType()
            {
                return ConfirmType != null;
            }

            /// <summary>
            /// 物流公司编码
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
            /// 订单完成时间
            /// </summary>
            [XmlElement("orderConfirmTime")]
            public string OrderConfirmTime { get; set; }

        }
        #endregion

        #region PackageDomain

        [Serializable]

        public class PackageDomain
        {
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

            /// <summary>
            /// items
            /// </summary>
            [XmlArray("items"), XmlArrayItem("item")]
            public List<ItemDomain> Items { get; set; }

        }

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
            /// 包裹内该商品的数量
            /// </summary>
            [XmlElement("quantity")]
            public long Quantity { get; set; }

        }

        #endregion

        #region OrderLineDomain
        [Serializable]

        public class OrderLineDomain
        {
            /// <summary>
            /// 商品编码
            /// </summary>
            [XmlElement("itemCode")]
            public string ItemCode { get; set; }
            /// <summary>
            /// 外部业务编码
            /// </summary>
            [XmlElement("outBizCode")]
            public string OutBizCode { get; set; }

            /// <summary>
            /// 单据行号
            /// </summary>
            [XmlElement("orderLineNo")]
            public string OrderLineNo { get; set; }

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
            /// 库存类型
            /// </summary>
            [XmlElement("inventoryType"), DefaultValue("ZP")]
            public string InventoryType { get; set; }

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
            /// 生产日期
            /// </summary>
            [XmlElement("productDate")]
            public string ProductDate { get; set; }

            /// <summary>
            /// 过期日期
            /// </summary>
            [XmlElement("expireDate")]
            public string ExpireDate { get; set; }

            /// <summary>
            /// 生产批号
            /// </summary>
            [XmlElement("produceCode")]
            public string ProduceCode { get; set; }

        } 
        #endregion
    }
}
