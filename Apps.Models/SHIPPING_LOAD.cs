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
    
    public partial class SHIPPING_LOAD
    {
        public decimal INTERNAL_LOAD_NUM { get; set; }
        public string WAREHOUSE { get; set; }
        public decimal TRAILING_STS { get; set; }
        public Nullable<decimal> LEADING_STS { get; set; }
        public string CARRIER { get; set; }
        public string CARRIER_SERVICE { get; set; }
        public Nullable<System.DateTime> SCHEDULED_SHIP_DATE { get; set; }
        public Nullable<System.DateTime> ACTUAL_SHIP_DATE { get; set; }
        public string LOAD_SIZE_DEF { get; set; }
        public string LOAD_CLOSED { get; set; }
        public string SEAL_ID { get; set; }
        public string TRAILER_ID { get; set; }
        public Nullable<decimal> TOTAL_SHIPMENTS { get; set; }
        public Nullable<decimal> TOTAL_CONTAINERS { get; set; }
        public Nullable<decimal> TOTAL_WEIGHT { get; set; }
        public string WEIGHT_UM { get; set; }
        public Nullable<decimal> TOTAL_VOLUME { get; set; }
        public string VOLUME_UM { get; set; }
        public string USER_STAMP { get; set; }
        public System.DateTime DATE_TIME_STAMP { get; set; }
        public string ROUTE { get; set; }
        public string DOCK_DOOR { get; set; }
        public string DRIVER { get; set; }
        public Nullable<decimal> MAX_WEIGHT { get; set; }
        public Nullable<decimal> MAX_VOLUME { get; set; }
        public string USER_DEF1 { get; set; }
        public string USER_DEF2 { get; set; }
        public string USER_DEF3 { get; set; }
        public string USER_DEF4 { get; set; }
        public string USER_DEF5 { get; set; }
        public string USER_DEF6 { get; set; }
        public string USER_DEF7 { get; set; }
        public string USER_DEF8 { get; set; }
        public string IN_CONFIRM { get; set; }
    
        public virtual WAREHOUSE WAREHOUSE1 { get; set; }
    }
}
