using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// CainiaoEndpointLockerSpiAccountAuthorizeResponse.
    /// </summary>
    public class CainiaoEndpointLockerSpiAccountAuthorizeResponse : TopResponse
    {
        /// <summary>
        /// {}
        /// </summary>
        [XmlElement("response")]
        public ResponseDomain Response { get; set; }

	/// <summary>
/// ResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ResponseDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("err_code")]
	        public string ErrCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("err_desc")]
	        public string ErrDesc { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
