using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// CombineitemQueryResponse.
    /// </summary>
    public class CombineitemQueryResponse : QimenResponse
    {
        /// <summary>
        /// 奇门仓储字段
        /// </summary>
        [XmlArray("combItems")]
        [XmlArrayItem("comb_item")]
        public List<CombItemDomain> CombItems { get; set; }

	/// <summary>
/// CombItemDomain Data Structure.
/// </summary>
[Serializable]

public class CombItemDomain : TopObject
{
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("count")]
	        public string Count { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
}

    }
}
