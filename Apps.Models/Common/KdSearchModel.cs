using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models.Common
{
   public class KdSearchModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string EBusinessID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OrderCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShipperCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LogisticCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<TracesItem> Traces { get; set; }
    }

    public class TracesItem
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime AcceptTime { get; set; }

        public string AcceptStation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }
    }
}
