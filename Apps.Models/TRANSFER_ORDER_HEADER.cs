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
    
    public partial class TRANSFER_ORDER_HEADER
    {
        public decimal INTERNAL_TRANSFER_NUM { get; set; }
        public string TRANSFER_ID { get; set; }
        public Nullable<decimal> LEADING_STS { get; set; }
        public string CART_ID { get; set; }
        public Nullable<System.DateTime> BEGIN_DATE_TIME { get; set; }
        public Nullable<System.DateTime> END_DATE_TIME { get; set; }
        public string CREATED_USER { get; set; }
        public Nullable<System.DateTime> CREATED_DATE_TIME { get; set; }
        public string LAST_MODIFIED_USER { get; set; }
        public Nullable<System.DateTime> LAST_MODIFIED_DATE_TIME { get; set; }
        public string USER_DEF1 { get; set; }
        public string USER_DEF2 { get; set; }
        public string USER_DEF3 { get; set; }
        public string USER_DEF4 { get; set; }
        public string USER_DEF5 { get; set; }
        public string USER_DEF6 { get; set; }
        public string USER_DEF7 { get; set; }
        public string USER_DEF8 { get; set; }
        public string WAREHOUSE { get; set; }
        public string COMPANY { get; set; }
        public Nullable<decimal> TRAILING_STS { get; set; }
    }
}