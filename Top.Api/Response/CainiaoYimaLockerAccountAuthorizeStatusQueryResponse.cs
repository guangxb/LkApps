using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// CainiaoYimaLockerAccountAuthorizeStatusQueryResponse.
    /// </summary>
    public class CainiaoYimaLockerAccountAuthorizeStatusQueryResponse : TopResponse
    {
        /// <summary>
        /// response
        /// </summary>
        [XmlElement("result")]
        public SingleResultDomain Result { get; set; }

	/// <summary>
/// AuthInfoDomain Data Structure.
/// </summary>
[Serializable]

public class AuthInfoDomain : TopObject
{
	        /// <summary>
	        /// companyCode
	        /// </summary>
	        [XmlElement("company_code")]
	        public string CompanyCode { get; set; }
	
	        /// <summary>
	        /// linkAppkey
	        /// </summary>
	        [XmlElement("link_appkey")]
	        public string LinkAppkey { get; set; }
}

	/// <summary>
/// SingleResultDomain Data Structure.
/// </summary>
[Serializable]

public class SingleResultDomain : TopObject
{
	        /// <summary>
	        /// data
	        /// </summary>
	        [XmlElement("data")]
	        public AuthInfoDomain Data { get; set; }
	
	        /// <summary>
	        /// errorCode
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// errorDesc
	        /// </summary>
	        [XmlElement("error_desc")]
	        public string ErrorDesc { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
