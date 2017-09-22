using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models.Common
{
    public class DataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime time { get; set; }
       
        public string context { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string location { get; set; }
    }

    public class Kd100Model
    {
        /// <summary>
        /// 
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ischeck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string condition { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string com { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int state { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string comcontact { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string comurl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<DataItem> data { get; set; }
    }
}
