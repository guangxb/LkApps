//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apps.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AR_UPLOAD_ORDER_STATUS
    {
        public decimal INTERFACE_RECORD_ID { get; set; }
        public string INTERFACE_ACTION_CODE { get; set; }
        public string INTERFACE_CONDITION { get; set; }
        public string INTERFACE_ERROR { get; set; }
        public string COMPANY { get; set; }
        public string WAREHOUSE { get; set; }
        public string SHIPMENT_ID { get; set; }
        public Nullable<decimal> LEADING_STS { get; set; }
        public Nullable<decimal> TRAILING_STS { get; set; }
        public string PROCESS_TYPE { get; set; }
        public string PROCESS_STAMP { get; set; }
        public System.DateTime DATE_TIME_STAMP { get; set; }
        public string USER_STAMP { get; set; }
        public string TRACKING_NUMBER { get; set; }
        public string CONTAINER_ID { get; set; }
        public string CARRIER { get; set; }
    }
}