using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.orderstatus.batchquery
    /// </summary>
    public class OrderstatusBatchqueryRequest : QimenRequest<Qimen.Api.Response.OrderstatusBatchqueryResponse>
    {
        /// <summary>
        /// 当前第几页(从1开始)
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 订单最后操作时间(查询截止时间点;格式:YYYY-MM-DD hh:mm:ss)
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        /// <summary>
        /// 单据类型(JYCK=一般交易出库单;HHCK=换货出库;BFCK=补发出库;PTCK=普通出库单;DBCK=调拨出库;QTCK=其他出库;B2BRK=B2B入库;B2BCK=B2B出库;CGRK=采购入库;DBRK=调拨入库;QTRK=其他入库;XTRK=销退入库;HHRK= 换货入库;CNJG= 仓内加工单)
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 货主编码
        /// </summary>
        public string OwnerCode { get; set; }

        /// <summary>
        /// 页面大小(建议不超过100条)
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 订单最后操作时间(查询起始时间点;格式:YYYY-MM-DD hh:mm:ss)
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        public string WarehouseCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.orderstatus.batchquery";
        }


        #endregion
    }
}
