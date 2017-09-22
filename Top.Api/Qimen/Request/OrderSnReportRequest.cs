using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.order.sn.report
    /// </summary>
    public class OrderSnReportRequest : QimenRequest<Qimen.Api.Response.OrderSnReportResponse>
    {
        /// <summary>
        /// 当前页(从1开始)
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        public ItemsDomain Items { get; set; }

        public OrderDomain Order { get; set; }

        /// <summary>
        /// 每页记录的条数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public Nullable<long> TotalPage { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.order.sn.report";
        }


	/// <summary>
/// OrderDomain Data Structure.
/// </summary>
[Serializable]

public class OrderDomain
{
	        /// <summary>
	        /// 单据编号
	        /// </summary>
	        [XmlElement("orderCode")]
	        public string OrderCode { get; set; }
	
	        /// <summary>
	        /// 单据类型(JYCK=一般交易出库单;HHCK=换货出库;BFCK=补发出库;PTCK=普通出库单;DBCK=调拨出库;B2BCK=B2B出库;QTCK=其他出库;SCRK=生产入库;LYRK=领用入库;CCRK=残次品入库;CGRK=采购入库;B2BRK=B2B入库;DBRK=调拨入库;QTRK=其他入库;XTRK=销退入库;THRK=退货入库;HHRK=换货入库;CNJG=仓内加工单;CGTH=采购退货出库单;)
	        /// </summary>
	        [XmlElement("orderType")]
	        public string OrderType { get; set; }
	
	        /// <summary>
	        /// 外部业务编码(消息ID;用于去重;ISV对于同一请求;分配一个唯一性的编码。用来保证因为网络等原因导致重复传输;请求不会被重复处理;条件必填;条件为一单需要多次确认时)
	        /// </summary>
	        [XmlElement("outBizCode")]
	        public string OutBizCode { get; set; }
	
	        /// <summary>
	        /// 货主编码
	        /// </summary>
	        [XmlElement("ownerCode")]
	        public string OwnerCode { get; set; }
	
	        /// <summary>
	        /// 仓库编码
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
}

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
	        /// 商品序列号
	        /// </summary>
	        [XmlElement("sn")]
	        public string Sn { get; set; }
}

	/// <summary>
/// ItemsDomain Data Structure.
/// </summary>
[Serializable]

public class ItemsDomain
{
	        /// <summary>
	        /// 商品信息
	        /// </summary>
	        [XmlElement("item")]
	        public ItemDomain Item { get; set; }
}

        #endregion
    }
}
