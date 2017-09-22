using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Apps.WebApi.Areas.QiMen.Models
{
    public class response
    {
        public string flag { get; set; }

        public string code { get; set; }

        public string message { get; set; }

        public string entryOrderId { get; set; }
    }
}