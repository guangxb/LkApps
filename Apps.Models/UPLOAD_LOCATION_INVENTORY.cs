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
    
    public partial class UPLOAD_LOCATION_INVENTORY
    {
        public decimal INTERNAL_LOCATION_INV { get; set; }
        public string WAREHOUSE { get; set; }
        public string LOCATION { get; set; }
        public string ITEM { get; set; }
        public string ITEM_DESC { get; set; }
        public string COMPANY { get; set; }
        public string PERMANENT { get; set; }
        public Nullable<decimal> ATTRIBUTE_NUM { get; set; }
        public decimal ON_HAND_QTY { get; set; }
        public decimal IN_TRANSIT_QTY { get; set; }
        public decimal ALLOCATED_QTY { get; set; }
        public string QUANTITY_UM { get; set; }
        public string INVENTORY_STS { get; set; }
        public Nullable<System.DateTime> AGING_DATE { get; set; }
        public string USER_STAMP { get; set; }
        public System.DateTime DATE_TIME_STAMP { get; set; }
        public string LPN { get; set; }
        public string PARENT_LPN { get; set; }
        public string ATTRIBUTE1 { get; set; }
        public string ATTRIBUTE2 { get; set; }
        public string ATTRIBUTE3 { get; set; }
        public string ATTRIBUTE4 { get; set; }
        public string ATTRIBUTE5 { get; set; }
        public string ATTRIBUTE6 { get; set; }
        public string ATTRIBUTE7 { get; set; }
        public string ATTRIBUTE8 { get; set; }
        public string USER_DEF1 { get; set; }
        public string USER_DEF2 { get; set; }
        public string USER_DEF3 { get; set; }
        public string USER_DEF4 { get; set; }
        public string USER_DEF5 { get; set; }
        public string USER_DEF6 { get; set; }
        public string USER_DEF7 { get; set; }
        public string USER_DEF8 { get; set; }
    
        public virtual UPLOAD_LOCATION_INVENTORY UPLOAD_LOCATION_INVENTORY1 { get; set; }
        public virtual UPLOAD_LOCATION_INVENTORY UPLOAD_LOCATION_INVENTORY2 { get; set; }
    }
}
