using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// CainiaoCntmsLogisticsOrderConsignResponse.
    /// </summary>
    public class CainiaoCntmsLogisticsOrderConsignResponse : TopResponse
    {
        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("logistics_order_code")]
        public string LogisticsOrderCode { get; set; }

    }
}
