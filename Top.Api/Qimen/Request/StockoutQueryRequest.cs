using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.stockout.query
    /// </summary>
    public class StockoutQueryRequest : QimenRequest<Qimen.Api.Response.StockoutQueryResponse>
    {
        /// <summary>
        /// 出库单号
        /// </summary>
        public string DeliveryOrderCode { get; set; }

        /// <summary>
        /// 仓储系统出库单号
        /// </summary>
        public string DeliveryOrderId { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

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
        /// 仓库编码
        /// </summary>
        public string WarehouseCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.stockout.query";
        }


        #endregion
    }
}
