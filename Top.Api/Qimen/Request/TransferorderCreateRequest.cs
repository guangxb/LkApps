using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.transferorder.create
    /// </summary>
    public class TransferorderCreateRequest : QimenRequest<Qimen.Api.Response.TransferorderCreateResponse>
    {
        /// <summary>
        /// 扩展属性,HZ1234,string(500),,
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// 外部ERP订单号,HZ1234,string(50),必填,
        /// </summary>
        public string ErpOrderCode { get; set; }

        /// <summary>
        /// 期望调拨开始时间,Item1234,string(50),,
        /// </summary>
        public string ExpectStartTime { get; set; }

        /// <summary>
        /// 出库仓编码,Item1234,string(50),必填,
        /// </summary>
        public string FromStoreCode { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        public string OwnerCode { get; set; }

        /// <summary>
        /// 入库仓编码,HZ1234,string(50),必填,
        /// </summary>
        public string ToStoreCode { get; set; }

        public TransferItemsDomain TransferItems { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.transferorder.create";
        }


	/// <summary>
/// TransferItemDomain Data Structure.
/// </summary>
[Serializable]

public class TransferItemDomain
{
	        /// <summary>
	        /// 数量,Item1234,string(50),必填,
	        /// </summary>
	        [XmlElement("count")]
	        public string Count { get; set; }
	
	        /// <summary>
	        /// 库存类型(1:可销售库存.101:残次),HZ1234,string(500),必填,
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
	        /// <summary>
	        /// 货品编码,HZ1234,string(50),必填,
	        /// </summary>
	        [XmlElement("scItemCode")]
	        public string ScItemCode { get; set; }
}

	/// <summary>
/// TransferItemsDomain Data Structure.
/// </summary>
[Serializable]

public class TransferItemsDomain
{
	        /// <summary>
	        /// 项目
	        /// </summary>
	        [XmlElement("transferItem")]
	        public TransferItemDomain TransferItem { get; set; }
}

        #endregion
    }
}
