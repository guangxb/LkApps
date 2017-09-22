using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.order.pending
    /// </summary>
    public class OrderPendingRequest : QimenRequest<Qimen.Api.Response.OrderPendingResponse>
    {
        /// <summary>
        /// 操作类型(pending=挂起;restore=恢复)
        /// </summary>
        public string ActionType { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        /// <summary>
        /// 单据编码
        /// </summary>
        public string OrderCode { get; set; }

        /// <summary>
        /// 仓储系统单据编码
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 单据类型(JYCK=一般交易出库单;HHCK=换货出库;BFCK=补发出库;PTCK=普通出库单;DBCK=调拨出库;QTCK=其他出库;B2BRK=B2B入库;B2BCK=B2B出库;CGRK=采购入库;DBRK=调拨入库;QTRK=其他入库;XTRK=销退入库;HHRK=换货入库;CNJG=仓内加工单)
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 货主编码
        /// </summary>
        public string OwnerCode { get; set; }

        /// <summary>
        /// 挂起/恢复原因
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 仓库编码(统仓统配等无需ERP指定仓储编码的情况填OTHER)
        /// </summary>
        public string WarehouseCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.order.pending";
        }


        #endregion
    }
}
