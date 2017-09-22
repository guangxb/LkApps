using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// CainiaoYimaLockerAccountAuthorizeResponse.
    /// </summary>
    public class CainiaoYimaLockerAccountAuthorizeResponse : TopResponse
    {
        /// <summary>
        /// response
        /// </summary>
        [XmlElement("result")]
        public SingleResultDomain Result { get; set; }

	/// <summary>
/// SingleResultDomain Data Structure.
/// </summary>
[Serializable]

public class SingleResultDomain : TopObject
{
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
