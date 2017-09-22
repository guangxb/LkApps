using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// ReturnorderCreateResponse.
    /// </summary>
    public class ReturnorderCreateResponse : QimenResponse
    {
        /// <summary>
        /// 仓储系统退货单编码
        /// </summary>
        [XmlElement("returnOrderId")]
        public string ReturnOrderId { get; set; }

    }
}
