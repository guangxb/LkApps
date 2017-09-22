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
    public class EntryorderConfirmRequest: CustomRequest<Response.EntryorderConfirmResponse>
    {
        [XmlElement("entryOrder")]
        public EntryOrderDomain EntryOrder { get; set; }

        [XmlArray("orderLines"), XmlArrayItem("orderLine")]
        public List<OrderLineDomain> OrderLines { get; set; }

        [XmlElement("extendProps")]
        public string ExtendProps { get; set; }

        public override string GetApiName()
        {
            return "taobao.qimen.entryorder.confirm";
        }

        #region EntryOrderDomain
        [Serializable]
        public class EntryOrderDomain
        {

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
            /// 订单编码
            /// </summary>
            [XmlElement("orderCode")]
            public string OrderCode { get; set; }

            /// <summary>
            /// 后端订单id
            /// </summary>
            [XmlElement("orderId")]
            public string OrderId { get; set; }

            /// <summary>
            /// 入库单类型(SCRK=生产入库;LYRK=领用入库;CCRK=残次品入库;CGRK=采购入库;DBRK=调拨入库;QTRK=其他入 库;B2BRK=B2B入库)
            /// </summary>
            [XmlElement("entryOrderType")]
            public string EntryOrderType { get; set; }

            /// <summary>
            /// 订单类型
            /// </summary>
            [XmlElement("orderType")]
            public string OrderType { get; set; }

            /// <summary>
            /// 仓库名称
            /// </summary>
            [DefaultValue("LK01")]

            [XmlElement("warehouseName")]
            public string WarehouseName { get; set; }

            /// <summary>
            /// 仓库编码(统仓统配等无需ERP指定仓储编码的情况填OTHER)
            /// </summary>
            [XmlElement("warehouseCode")]
            public string WarehouseCode { get; set; }

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
            /// 采购单号(当orderType=CGRK时使用)
            /// </summary>
            [XmlElement("purchaseOrderCode")]
            public string PurchaseOrderCode { get; set; }

            /// <summary>
            /// 货主编码
            /// </summary>
            [XmlElement("ownerCode")]
            public string OwnerCode { get; set; }

            /// <summary>
            /// 外部业务编码(消息ID;用于去重;ISV对于同一请求;分配一个唯一性的编码。用来保证因为网络等原因导致重复传输;请求 不会被重复处理)
            /// </summary>
            [XmlElement("outBizCode")]
            public string OutBizCode { get; set; }

            /// <summary>
            /// 入库单状态(NEW-未开始处理;ACCEPT-仓库接单;PARTFULFILLED-部分收货完成;FULFILLED-收货完成;EXCEPTION-异 常;CANCELED-取消;CLOSED-关闭;REJECT-拒单;CANCELEDFAIL-取消失败;只传英文编码)
            /// </summary>
            [XmlElement("status"),DefaultValue("FULFILLED")]
            public string Status { get; set; }

            /// <summary>
            /// 操作时间(YYYY-MM-DD HH:MM:SS;当status=FULFILLED;operateTime为入库时间)
            /// </summary>
            [XmlElement("operateTime")]
            public string OperateTime { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [XmlElement("remark")]
            public string Remark { get; set; }

        }
        #endregion

        #region OrderLineDomain
        [Serializable]
        public class OrderLineDomain
        {
            /// <summary>
            /// 外部业务编码(消息ID;用于去重;当单据需要分批次发送时使用)
            /// </summary>
            [XmlElement("outBizCode")]
            public string OutBizCode { get; set; }

            /// <summary>
            /// 入库单的行号
            /// </summary>
            [XmlElement("orderLineNo")]
            public string OrderLineNo { get; set; }

            /// <summary>
            /// 货主编码
            /// </summary>
            [XmlElement("ownerCode")]
            public string OwnerCode { get; set; }

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
            /// 应收商品数量
            /// </summary>
            [XmlElement("planQty")]
            public Nullable<long> PlanQty { get; set; }

            /// <summary>
            /// 实收数量
            /// </summary>
            [XmlElement("actualQty")]
            public Nullable<long> ActualQty { get; set; }

            /// <summary>
            /// 库存类型(ZP=正品;CC=残次;JS=机损;XS=箱损;默认为ZP)
            /// </summary>
            [XmlElement("inventoryType"),DefaultValue("ZP")]
            public string InventoryType { get; set; }

            /// <summary>
            /// 商品生产日期(YYYY-MM-DD)
            /// </summary>
            [XmlElement("productDate")]
            public string ProductDate { get; set; }

            /// <summary>
            /// 商品过期日期(YYYY-MM-DD)
            /// </summary>
            [XmlElement("expireDate")]
            public string ExpireDate { get; set; }

            /// <summary>
            /// 生产批号
            /// </summary>
            [XmlElement("produceCode")]
            public string ProduceCode { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [XmlElement("remark")]
            public string Remark { get; set; }

        }
        #endregion
    }
}
