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
    
    public partial class RECEIVING_PREFERENCE
    {
        public decimal INTERNAL_PREF_NUM { get; set; }
        public string PREFERENCE_NAME { get; set; }
        public string WAREHOUSE { get; set; }
        public string AUTO_ASSIGN_LPN { get; set; }
        public string AUTO_PUTAWAY { get; set; }
        public string ALLOW_OVER_RECEIVING { get; set; }
        public string ACTIVE { get; set; }
        public string AUTO_LOCATE { get; set; }
        public string AUTO_CHECKIN { get; set; }
        public string SHOW_OPEN_QTY { get; set; }
        public string RECEIPT_TYPES { get; set; }
        public string USER_DEF1 { get; set; }
        public string USER_DEF2 { get; set; }
        public string USER_DEF3 { get; set; }
        public string USER_DEF4 { get; set; }
        public string USER_DEF5 { get; set; }
        public string USER_DEF6 { get; set; }
        public string USER_DEF7 { get; set; }
        public string USER_DEF8 { get; set; }
        public string GROUP_PUTAWAY { get; set; }
        public string NEST_DURING_CHECKIN { get; set; }
        public string MANUALLY_BUILD_LPN { get; set; }
        public Nullable<System.DateTime> CREATE_DATE_TIME { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<System.DateTime> LAST_MODIFY_DATE_TIME { get; set; }
        public string LAST_MODIFY_USER { get; set; }
        public string RULE_ASSIGNMENT { get; set; }
        public string RECEIPT_BY_PIECE { get; set; }
        public string RECEIPT_AUTOMATIC_CONFIRM { get; set; }
    
        public virtual WAREHOUSE WAREHOUSE1 { get; set; }
    }
}
