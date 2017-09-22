using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// StoreprocessCreateResponse.
    /// </summary>
    public class StoreprocessCreateResponse : QimenResponse
    {
        /// <summary>
        /// 仓储系统处理单ID
        /// </summary>
        [XmlElement("processOrderId")]
        public string ProcessOrderId { get; set; }

    }
}
