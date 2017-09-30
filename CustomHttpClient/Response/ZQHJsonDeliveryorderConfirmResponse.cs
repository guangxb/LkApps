using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHttpClient.Response
{
    public class ZQHJsonDeliveryorderConfirmResponse:CustomResponse
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "err")]
        public string Err { get; set; }

        [JsonProperty(PropertyName = "outvalue")]
        public string OutValue { get; set; }

        [JsonProperty(PropertyName = "outcontext")]
        public string OutContext { get; set; }
    }
}
