using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// TransferorderCreateResponse.
    /// </summary>
    public class TransferorderCreateResponse : QimenResponse
    {
        /// <summary>
        /// 调拨单信息
        /// </summary>
        [XmlElement("transferExecuteInfo")]
        public TransferExecuteInfoDomain TransferExecuteInfo { get; set; }

	/// <summary>
/// TransferExecuteInfoDomain Data Structure.
/// </summary>
[Serializable]

public class TransferExecuteInfoDomain : TopObject
{
	        /// <summary>
	        /// 预计入库时间,0,string(50),,
	        /// </summary>
	        [XmlElement("expectInStoreTime")]
	        public string ExpectInStoreTime { get; set; }
	
	        /// <summary>
	        /// 预计出库时间,0,string(50),,
	        /// </summary>
	        [XmlElement("expectOutStoreTime")]
	        public string ExpectOutStoreTime { get; set; }
	
	        /// <summary>
	        /// 调拨单号,0,string(50),,
	        /// </summary>
	        [XmlElement("transferOrderCode")]
	        public string TransferOrderCode { get; set; }
}

    }
}
