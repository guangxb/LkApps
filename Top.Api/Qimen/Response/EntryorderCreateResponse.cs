using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// EntryorderCreateResponse.
    /// </summary>
    public class EntryorderCreateResponse : QimenResponse
    {
        /// <summary>
        /// 仓储系统入库单编码
        /// </summary>
        [XmlElement("entryOrderId")]
        public string EntryOrderId { get; set; }

    }
}
