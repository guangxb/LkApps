using CustomHttpClient.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHttpClient.Request
{
    public class ZQHJsonDeliveryorderConfirmRequest : CustomRequest<Response.ZQHJsonDeliveryorderConfirmResponse>
    {

        [JsonProperty(PropertyName = "db")]
        public string Db { get; set; }
        [JsonProperty(PropertyName = "function")]
        public string Function { get; set; }
        [JsonProperty(PropertyName = "intype")]
        public string Intype { get; set; }
        [JsonProperty(PropertyName = "inpara")]
        public string Inpara { get; set; }
       


        public override string GetApiName()
        {
            return "http://106.75.66.42:8020/restful/rpc";
        }
    }
}
