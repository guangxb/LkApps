using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models.Common.Trackingmore
{
    public class TrackingInfoModel
    {
        public Meta meta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public VerifyInfo verifyInfo { get; set; }
    }

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

    public class TrackinfoItem
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 未妥投
        /// </summary>
        public string StatusDescription { get; set; }
        /// <summary>
        /// 瑞典
        /// </summary>
        public string Details { get; set; }
    }

    public class Origin_info
    {
        /// <summary>
        /// 
        /// </summary>
        public string weblink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string carrier_code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<TrackinfoItem> trackinfo { get; set; }
    }

    public class Destination_info
    {
        /// <summary>
        /// 
        /// </summary>
        public string weblink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string carrier_code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<TrackinfoItem> trackinfo { get; set; }
    }

    public class Data
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
        public string updated_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string order_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string customer_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string customer_email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string original_country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string destination_country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int itemTimeLength { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Origin_info origin_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Destination_info destination_info { get; set; }
    }

    public class VerifyInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public int timeStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string signature { get; set; }
    }
}
