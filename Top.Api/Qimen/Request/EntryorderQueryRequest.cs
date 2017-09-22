using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.entryorder.query
    /// </summary>
    public class EntryorderQueryRequest : QimenRequest<Qimen.Api.Response.EntryorderQueryResponse>
    {
        /// <summary>
        /// 入库单编码
        /// </summary>
        public string EntryOrderCode { get; set; }

        /// <summary>
        /// 仓储系统入库单ID
        /// </summary>
        public string EntryOrderId { get; set; }

        /// <summary>
        /// extOrderCode
        /// </summary>
        public string ExtOrderCode { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        /// <summary>
        /// orderType
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 货主编码
        /// </summary>
        public string OwnerCode { get; set; }

        /// <summary>
        /// 当前页(从1开始)
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
        /// 仓库编码
        /// </summary>
        public string WarehouseCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.entryorder.query";
        }


        #endregion
    }
}
