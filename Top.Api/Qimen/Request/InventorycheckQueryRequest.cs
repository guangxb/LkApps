using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.inventorycheck.query
    /// </summary>
    public class InventorycheckQueryRequest : QimenRequest<Qimen.Api.Response.InventorycheckQueryResponse>
    {
        /// <summary>
        /// 盘点单编码
        /// </summary>
        public string CheckOrderCode { get; set; }

        /// <summary>
        /// 仓储系统的盘点单编码
        /// </summary>
        public string CheckOrderId { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

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
        /// 仓库编码
        /// </summary>
        public string WarehouseCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.inventorycheck.query";
        }


        #endregion
    }
}
