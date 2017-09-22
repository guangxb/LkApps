using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// ItemsSynchronizeResponse.
    /// </summary>
    public class ItemsSynchronizeResponse : QimenResponse
    {
        /// <summary>
        /// 商品同步批量接口中单商品信息
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("batch_item_syn_item")]
        public List<BatchItemSynItemDomain> Items { get; set; }

	/// <summary>
/// BatchItemSynItemDomain Data Structure.
/// </summary>
[Serializable]

public class BatchItemSynItemDomain : TopObject
{
	        /// <summary>
	        /// 没有同步成功的商品的编码
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 出错信息
	        /// </summary>
	        [XmlElement("message")]
	        public string Message { get; set; }
}

    }
}
