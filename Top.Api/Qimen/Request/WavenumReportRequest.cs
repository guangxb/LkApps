using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.wavenum.report
    /// </summary>
    public class WavenumReportRequest : QimenRequest<Qimen.Api.Response.WavenumReportResponse>
    {
        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        public List<OrderDomain> Orders { get; set; }

        /// <summary>
        /// 波次号
        /// </summary>
        public string WaveNum { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.wavenum.report";
        }


	/// <summary>
/// OrderDomain Data Structure.
/// </summary>
[Serializable]

public class OrderDomain
{
	        /// <summary>
	        /// 出库单号
	        /// </summary>
	        [XmlElement("deliveryOrderCode")]
	        public string DeliveryOrderCode { get; set; }
	
	        /// <summary>
	        /// 出库单仓储系统编码
	        /// </summary>
	        [XmlElement("deliveryOrderId")]
	        public string DeliveryOrderId { get; set; }
	
	        /// <summary>
	        /// 波次中的次序号
	        /// </summary>
	        [XmlElement("num")]
	        public string Num { get; set; }
}

        #endregion
    }
}
