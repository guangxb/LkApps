using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models.Common.Trackingmore
{
    public class TrackingBatchModel
    {
        public Meta meta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }

        public class Meta
        {
            /// <summary>
            /// 
            /// </summary>
            public int code { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string message { get; set; }
        }

        public class TrackingsItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tracking_number { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string carrier_code { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string status { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string created_at { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string customer_email { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string customer_name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string order_id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string title { get; set; }
        }

        public class ErrorsItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string tracking_number { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int code { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string message { get; set; }
        }

        public class Data
        {
            /// <summary>
            /// 
            /// </summary>
            public int submitted { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int added { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<TrackingsItem> trackings { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<ErrorsItem> errors { get; set; }
        }
    }
}
