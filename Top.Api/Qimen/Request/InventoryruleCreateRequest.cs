using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.inventoryrule.create
    /// </summary>
    public class InventoryruleCreateRequest : QimenRequest<Qimen.Api.Response.InventoryruleCreateResponse>
    {
        public List<InventoryRuleDomain> InventoryRules { get; set; }

        /// <summary>
        /// 奇门仓储字段,C1223,string(50),,
        /// </summary>
        public string OwnerCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.inventoryrule.create";
        }


	/// <summary>
/// ChannelRatioRuleDomain Data Structure.
/// </summary>
[Serializable]
[Top.Api.Util.ApiListType("channelRatioRule")]
public class ChannelRatioRuleDomain
{
	        /// <summary>
	        /// 奇门仓储字段,C1223,string(50),,
	        /// </summary>
	        [XmlElement("channelCode")]
	        public string ChannelCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,C1223,string(50),,
	        /// </summary>
	        [XmlElement("ratio")]
	        public string Ratio { get; set; }
}

	/// <summary>
/// InventoryRuleDomain Data Structure.
/// </summary>
[Serializable]
[Top.Api.Util.ApiListType("inventoryRule")]
public class InventoryRuleDomain
{
	        /// <summary>
	        /// 奇门仓储字段,C1223,string(50),,
	        /// </summary>
	        [XmlElement("actionType")]
	        public string ActionType { get; set; }
	
	        /// <summary>
	        /// channelRatioRules
	        /// </summary>
	        [XmlArray("channelRatioRules")]
	        [XmlArrayItem("channelRatioRule")]
	        public List<ChannelRatioRuleDomain> ChannelRatioRules { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段,C1223,string(50),,
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
}

        #endregion
    }
}
