using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// SingleitemSynchronizeResponse.
    /// </summary>
    public class SingleitemSynchronizeResponse : QimenResponse
    {
        /// <summary>
        /// 仓储系统商品Id(当这个字段不为空的时候;所有erp传输的时候都碰到itemid必传)
        /// </summary>
        [XmlElement("itemId")]
        public string ItemId { get; set; }

    }
}
