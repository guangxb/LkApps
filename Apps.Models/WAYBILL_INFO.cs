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
    
    public partial class WAYBILL_INFO
    {
        public decimal INTERNAL_NUM { get; set; }
        public string TRACKING_NUMBER { get; set; }
        public string CARRIER { get; set; }
        public string SHORT_ADDRESS { get; set; }
        public string SHIPPING_BRANCH_CODE { get; set; }
        public string SHIPPING_BRANCH_NAME { get; set; }
        public string CONSIGNEE_BRANCH_CODE { get; set; }
        public string CONSIGNEE_BRANCH_NAME { get; set; }
        public Nullable<decimal> INTERNAL_SHIPMENT_NUM { get; set; }
        public Nullable<decimal> INTERNAL_CONTAINER_NUM { get; set; }
        public string NOTICE_CODE { get; set; }
        public string PRINT_QUANTITY { get; set; }
        public string NOTICE_MESSAGE { get; set; }
        public string STATUS { get; set; }
        public string REAL_USER_ID { get; set; }
        public string VOLUME { get; set; }
        public string WEIGHT { get; set; }
        public string USER_DEF1 { get; set; }
        public string USER_DEF2 { get; set; }
        public string USER_DEF3 { get; set; }
        public string USER_DEF4 { get; set; }
        public string USER_DEF5 { get; set; }
        public string USER_DEF6 { get; set; }
        public Nullable<decimal> USER_DEF7 { get; set; }
        public Nullable<decimal> USER_DEF8 { get; set; }
        public string USER_STAMP { get; set; }
        public Nullable<System.DateTime> DATE_TIME_STAMP { get; set; }
        public Nullable<System.DateTime> CREATE_TIME { get; set; }
        public Nullable<System.DateTime> PICKUP_TIME { get; set; }
        public Nullable<System.DateTime> SIGN_TIME { get; set; }
    }
}