using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models.Common
{
    public class Shippers
    {
        /// <summary>
        /// YD
        /// </summary>
        public string ShipperCode { get; set; }
        /// <summary>
        /// 韵达快递
        /// </summary>
        public string ShipperName { get; set; }
    }

    public class OrderDistinguishModel
    {
        /// <summary>
        /// 1257021
        /// </summary>
        public string EBusinessID { get; set; }
        /// <summary>
        /// Success
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 3967950525457
        /// </summary>
        public string LogisticCode { get; set; }
        /// <summary>
        /// Shippers
        /// </summary>
        public List<Shippers> Shippers { get; set; }
    }

    public class KdApiSubscribeModel
    {
        /// <summary>
        /// 1257021
        /// </summary>
        public string EBusinessID { get; set; }
        /// <summary>
        /// Success
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 3967950525457
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// Shippers
        /// </summary>
    }

}
