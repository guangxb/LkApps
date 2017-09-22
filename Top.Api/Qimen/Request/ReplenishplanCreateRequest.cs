using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.replenishplan.create
    /// </summary>
    public class ReplenishplanCreateRequest : QimenRequest<Qimen.Api.Response.ReplenishplanCreateResponse>
    {
        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        /// <summary>
        /// 最晚入库时间(YYYY-MM-DD HH:MM:SS)
        /// </summary>
        public string GmtDeadTime { get; set; }

        public List<ReplenishplanCreateItemDomain> Items { get; set; }

        /// <summary>
        /// 外部系统单号(ERP单号)
        /// </summary>
        public string OrderCode { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        public string WarehouseCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.replenishplan.create";
        }


	/// <summary>
/// ReplenishplanCreateItemDomain Data Structure.
/// </summary>
[Serializable]

public class ReplenishplanCreateItemDomain
{
	        /// <summary>
	        /// 后端商品编码
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 计划入库数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public Nullable<long> Quantity { get; set; }
}

        #endregion
    }
}
