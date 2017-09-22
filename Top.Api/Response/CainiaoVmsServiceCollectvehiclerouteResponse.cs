using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// CainiaoVmsServiceCollectvehiclerouteResponse.
    /// </summary>
    public class CainiaoVmsServiceCollectvehiclerouteResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public CollectVehicleRouteResponseDomain Result { get; set; }

	/// <summary>
/// CollectVehicleRouteResponseDomain Data Structure.
/// </summary>
[Serializable]

public class CollectVehicleRouteResponseDomain : TopObject
{
	        /// <summary>
	        /// message
	        /// </summary>
	        [XmlElement("message")]
	        public string Message { get; set; }
	
	        /// <summary>
	        /// statusCode
	        /// </summary>
	        [XmlElement("status_code")]
	        public long StatusCode { get; set; }
}

    }
}
