using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// EntryorderQueryResponse.
    /// </summary>
    public class EntryorderQueryResponse : QimenResponse
    {
        /// <summary>
        /// 入库单信息
        /// </summary>
        [XmlElement("entryOrder")]
        public EntryOrderDomain EntryOrder { get; set; }

        /// <summary>
        /// 入库单单据信息
        /// </summary>
        [XmlArray("orderLines")]
        [XmlArrayItem("orderLine")]
        public List<OrderLineDomain> OrderLines { get; set; }

        /// <summary>
        /// orderLines总条数
        /// </summary>
        [XmlElement("totalLines")]
        public long TotalLines { get; set; }

	/// <summary>
/// EntryOrderDomain Data Structure.
/// </summary>
[Serializable]

public class EntryOrderDomain : TopObject
{
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
	        /// 操作时间(YYYY-MM-DD HH:MM:SS;当status=FULFILLED;operateTime为入库时间)
	        /// </summary>
	        [XmlElement("operateTime")]
	        public string OperateTime { get; set; }
	
	        /// <summary>
	        /// 货主编码
	        /// </summary>
	        [XmlElement("ownerCode")]
	        public string OwnerCode { get; set; }
	
	        /// <summary>
	        /// 入库单状态(NEW-未开始处理;ACCEPT-仓库接单;PARTFULFILLED-部分收货完成;FULFILLED-收货完成;EXCEPTION-异 常;CANCELED-取消;CLOSED-关闭;REJECT-拒单;CANCELEDFAIL-取消失败;只传英文编码)
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
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

public class OrderLineDomain : TopObject
{
	        /// <summary>
	        /// 实收数量
	        /// </summary>
	        [XmlElement("actualQty")]
	        public long ActualQty { get; set; }
	
	        /// <summary>
	        /// 批次编码
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// 商品过期日期(YYYY-MM-DD)
	        /// </summary>
	        [XmlElement("expireDate")]
	        public string ExpireDate { get; set; }
	
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
	        /// 入库单的行号
	        /// </summary>
	        [XmlElement("orderLineNo")]
	        public string OrderLineNo { get; set; }
	
	        /// <summary>
	        /// 应收商品数量
	        /// </summary>
	        [XmlElement("planQty")]
	        public long PlanQty { get; set; }
	
	        /// <summary>
	        /// 生产批号
	        /// </summary>
	        [XmlElement("produceCode")]
	        public string ProduceCode { get; set; }
	
	        /// <summary>
	        /// 商品生产日期(YYYY-MM-DD)
	        /// </summary>
	        [XmlElement("productDate")]
	        public string ProductDate { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
}

    }
}
