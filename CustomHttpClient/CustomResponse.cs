using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CustomHttpClient
{
    [Serializable]
    public abstract class CustomResponse
    {

        [XmlElement("flag"),JsonProperty(PropertyName = "flag")]
        public string Flag { get; set; }

        [XmlElement("code"), JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [XmlElement("message"), JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        [XmlElement("body"), JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        public bool IsError
        {
            get
            {
                return !"success".Equals(Flag, StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}
