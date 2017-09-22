using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// CainiaoEndpointLockerSpiAccountLoginResponse.
    /// </summary>
    public class CainiaoEndpointLockerSpiAccountLoginResponse : TopResponse
    {
        /// <summary>
        /// {}
        /// </summary>
        [XmlElement("response")]
        public ResponseDomain Response { get; set; }

	/// <summary>
/// DataDomain Data Structure.
/// </summary>
[Serializable]

public class DataDomain : TopObject
{
	        /// <summary>
	        /// 柜子公司code
	        /// </summary>
	        [XmlElement("company_code")]
	        public string CompanyCode { get; set; }
	
	        /// <summary>
	        /// 柜子id
	        /// </summary>
	        [XmlElement("gui_id")]
	        public string GuiId { get; set; }
	
	        /// <summary>
	        /// 柜子登陆码
	        /// </summary>
	        [XmlElement("post_code")]
	        public string PostCode { get; set; }
}

	/// <summary>
/// ResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ResponseDomain : TopObject
{
	        /// <summary>
	        /// 柜子信息
	        /// </summary>
	        [XmlElement("data")]
	        public DataDomain Data { get; set; }
	
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
