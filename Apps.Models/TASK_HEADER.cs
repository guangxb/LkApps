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
    
    public partial class TASK_HEADER
    {
        public decimal INTERNAL_TASK_NUM { get; set; }
        public string WAREHOUSE { get; set; }
        public string COMPANY { get; set; }
        public string TASK_ID { get; set; }
        public string TASK_TYPE { get; set; }
        public string INTERNAL_TASK_TYPE { get; set; }
        public Nullable<decimal> REFERENCE_NUM { get; set; }
        public string REFERENCE_ID { get; set; }
        public string REFERENCE_NUM_TYPE { get; set; }
        public string ASSIGNED_USER { get; set; }
        public string CONFIRM_USER { get; set; }
        public string CONDITION { get; set; }
        public string HOLD_CODE { get; set; }
        public string USER_STAMP { get; set; }
        public Nullable<System.DateTime> DATE_TIME_STAMP { get; set; }
        public Nullable<decimal> INTERNAL_WAVE_NUM { get; set; }
        public string PICKING_CART_ID { get; set; }
        public string TRANS_CONT_ID { get; set; }
        public string USER_DEF1 { get; set; }
        public string USER_DEF2 { get; set; }
        public string USER_DEF3 { get; set; }
        public string USER_DEF4 { get; set; }
        public string USER_DEF5 { get; set; }
        public string USER_DEF6 { get; set; }
        public string USER_DEF7 { get; set; }
        public string USER_DEF8 { get; set; }
        public Nullable<System.DateTime> AGING_DATE_TIME { get; set; }
        public Nullable<System.DateTime> START_DATE_TIME { get; set; }
        public Nullable<System.DateTime> END_DATE_TIME { get; set; }
        public string LOCKED { get; set; }
        public string PICKING_CART_POS { get; set; }
        public string REBATCH_LOC { get; set; }
        public string FINISH_REBATCH { get; set; }
        public string BATCH_ID { get; set; }
        public string ALLOW_BATCH { get; set; }
        public string TASK_CATEGORY1 { get; set; }
        public string TASK_CATEGORY2 { get; set; }
        public string TASK_CATEGORY3 { get; set; }
        public string TASK_CATEGORY4 { get; set; }
        public string TASK_CATEGORY5 { get; set; }
        public string TASK_CATEGORY6 { get; set; }
        public string TASK_CATEGORY7 { get; set; }
        public string TASK_CATEGORY8 { get; set; }
        public string IS_SINGLE { get; set; }
        public string REBIN_BENCH { get; set; }
        public string REBINED { get; set; }
        public Nullable<System.DateTime> REBIN_START_DATE_TEME { get; set; }
        public Nullable<System.DateTime> REBIN_END_DATE_TIME { get; set; }
        public string REBIN_USER1 { get; set; }
        public string REBIN_USER2 { get; set; }
    
        public virtual TASK_HEADER TASK_HEADER1 { get; set; }
        public virtual TASK_HEADER TASK_HEADER2 { get; set; }
    }
}