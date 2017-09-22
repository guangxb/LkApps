using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// ExpressinfoQueryResponse.
    /// </summary>
    public class ExpressinfoQueryResponse : QimenResponse
    {
        /// <summary>
        /// 奇门仓储字段
        /// </summary>
        [XmlArray("expressInfos")]
        [XmlArrayItem("express_info")]
        public List<ExpressInfoDomain> ExpressInfos { get; set; }

	/// <summary>
/// ExpressInfoDomain Data Structure.
/// </summary>
[Serializable]

public class ExpressInfoDomain : TopObject
{
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("brandCode")]
	        public string BrandCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("brandName")]
	        public string BrandName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("expressCode")]
	        public string ExpressCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("expressName")]
	        public string ExpressName { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
}

    }
}
