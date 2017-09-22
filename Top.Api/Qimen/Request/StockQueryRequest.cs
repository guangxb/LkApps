using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.stock.query
    /// </summary>
    public class StockQueryRequest : QimenRequest<Qimen.Api.Response.StockQueryResponse>
    {
        /// <summary>
        /// 批次编码
        /// </summary>
        public string BatchCode { get; set; }

        /// <summary>
        /// 商品过期日期(YYYY-MM-DD)
        /// </summary>
        public string ExpireDate { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        /// <summary>
        /// 库存类型(ZP=正品;CC=残次;JS=机损;XS=箱损;ZT=在途库存;默认为查所有类型的库存)
        /// </summary>
        public string InventoryType { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// 仓储系统商品ID
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// 货主编码
        /// </summary>
        public string OwnerCode { get; set; }

        /// <summary>
        /// 当前页(从1开始)
        /// </summary>
        public Nullable<long> Page { get; set; }

        /// <summary>
        /// 每页条数(最多100条)
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 商品生产日期(YYYY-MM-DD)
        /// </summary>
        public string ProductDate { get; set; }

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
            return "taobao.qimen.stock.query";
        }


        #endregion
    }
}
