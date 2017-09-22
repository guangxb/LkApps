using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apps.WebApi.Areas.Spm.Models
{
  
    public class Datas {
        public string RequestType { get; set; }
        public string DataSign { get; set; }

        public string RequestData { get; set; }

    }

    public class Traces
    {
        /// <summary>
        /// 深圳市横岗速递营销部已收件，（揽投员姓名：钟某某;联系电话：18000000000）
        /// </summary>
        public string AcceptStation { get; set; }
        /// <summary>
        /// 2017-04-24 16:55:53
        /// </summary>
        public DateTime AcceptTime { get; set; }
    }

    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public string CallBack { get; set; }
        /// <summary>
        /// 1284625
        /// </summary>
        public string EBusinessID { get; set; }
        /// <summary>
        /// 00000000201704240
        /// </summary>
        public string LogisticCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OrderCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// ZJS
        /// </summary>
        public string ShipperCode { get; set; }
        /// <summary>
        /// 3
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Success
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// Traces
        /// </summary>
        public List<Traces> Traces { get; set; }
    }

    public class RequestData
    {
        /// <summary>
        /// Count
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        public List<Data> Data { get; set; }
        /// <summary>
        /// 1284625
        /// </summary>
        public string EBusinessID { get; set; }
        /// <summary>
        /// 2017-04-25 16:55:53
        /// </summary>
        public DateTime PushTime { get; set; }
    }
    public class Root
    {
        /// <summary>
        /// 1109259
        /// </summary>
        public string EBusinessID { get; set; }
        /// <summary>
        /// 2015-03-11 16: 26: 11
        /// </summary>
        public string UpdateTime { get; set; }
        /// <summary>
        /// Success
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Reason { get; set; }
    }


}