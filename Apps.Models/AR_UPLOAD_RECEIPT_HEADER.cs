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
    
    public partial class AR_UPLOAD_RECEIPT_HEADER
    {
        public string INTERFACE_RECORD_ID { get; set; }
        public string INTERFACE_ACTION_CODE { get; set; }
        public string INTERFACE_CONDITION { get; set; }
        public string PROCESS_STAMP { get; set; }
        public string WAREHOUSE { get; set; }
        public string COMPANY { get; set; }
        public string RECEIPT_ID { get; set; }
        public string RECEIPT_TYPE { get; set; }
        public Nullable<decimal> PRIORITY { get; set; }
        public Nullable<decimal> LEADING_STS { get; set; }
        public Nullable<decimal> TRAILING_STS { get; set; }
        public string ERP_ORDER_ID { get; set; }
        public string SHIP_FROM { get; set; }
        public string SHIP_FROM_ADDRESS1 { get; set; }
        public string SHIP_FROM_ADDRESS2 { get; set; }
        public string SHIP_FROM_CITY { get; set; }
        public string SHIP_FROM_STATE { get; set; }
        public string SHIP_FROM_COUNTRY { get; set; }
        public string SHIP_FROM_POSTAL_CODE { get; set; }
        public string SHIP_FROM_NAME { get; set; }
        public string SHIP_FROM_ATTENTION_TO { get; set; }
        public string SHIP_FROM_EMAIL_ADDRESS { get; set; }
        public string SHIP_FROM_PHONE_NUM { get; set; }
        public string SHIP_FROM_FAX_NUM { get; set; }
        public Nullable<System.DateTime> SCHEDULED_ARRIVE_DATE { get; set; }
        public Nullable<System.DateTime> ACTUAL_ARRIVE_DATE { get; set; }
        public string USER_STAMP { get; set; }
        public Nullable<System.DateTime> DATE_TIME_STAMP { get; set; }
        public string RECV_DOCK { get; set; }
        public Nullable<System.DateTime> CLOSE_DATE { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public Nullable<System.DateTime> START_CHECKIN_DATE { get; set; }
        public Nullable<System.DateTime> END_CHECKIN_DATE { get; set; }
        public string USER_DEF1 { get; set; }
        public string USER_DEF2 { get; set; }
        public string USER_DEF3 { get; set; }
        public string USER_DEF4 { get; set; }
        public string USER_DEF5 { get; set; }
        public string USER_DEF6 { get; set; }
        public string USER_DEF7 { get; set; }
        public string USER_DEF8 { get; set; }
        public Nullable<decimal> TOTAL_QTY { get; set; }
        public Nullable<decimal> TOTAL_LINES { get; set; }
    }
}
